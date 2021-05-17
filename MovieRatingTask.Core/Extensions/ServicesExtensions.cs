using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace MovieRatingTask.Core.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServicesAsSelf(this IServiceCollection services, string marker, ServiceLifetime lifetime, Assembly[] assemblies)
        {
            var assemblyServices = assemblies
                .SelectMany(assembly => assembly.GetTypes().Where(type => type.GetInterfaces().Any(i => i.Name.Contains(marker))))
                .Select(t => t).ToList();

            foreach (var service in assemblyServices)
            {
                switch (lifetime)
                {
                    case ServiceLifetime.Singleton:
                        services.AddSingleton(service); continue;
                    case ServiceLifetime.Scoped:
                        services.AddScoped(service); continue;
                    case ServiceLifetime.Transient:
                        services.AddTransient(service); continue;
                }
            }

            return services;
        }

        public static IServiceCollection AddServicesAsImplementedInterface(this IServiceCollection services, string marker, ServiceLifetime lifetime, Assembly[] assemblies, Func<Type, bool> filter = null)
        {
            if (filter == null)
            {
                filter = type => type.Name.Contains(marker);
            }

            var assemblyServices = assemblies
                .SelectMany(assembly => assembly.GetTypes().Where(type => !type.IsInterface && type.GetInterfaces().Any(filter)))
                .SelectMany(t => t.GetInterfaces().Where(x => !x.IsGenericType).Where(filter).Select(x => new Tuple<Type, Type>(t, x)).ToList());

            foreach (var (assemblyServiceAbstraction, assemblyServicesImplementation) in assemblyServices)
            {
                if (assemblyServiceAbstraction == null || assemblyServicesImplementation == null)
                    continue;

                switch (lifetime)
                {
                    case ServiceLifetime.Singleton:
                        services.AddSingleton(assemblyServicesImplementation, assemblyServiceAbstraction); continue;
                    case ServiceLifetime.Scoped:
                        services.AddScoped(assemblyServicesImplementation, assemblyServiceAbstraction); continue;
                    case ServiceLifetime.Transient:
                        services.AddTransient(assemblyServicesImplementation, assemblyServiceAbstraction); continue;
                }
            }

            return services;
        }
    }
}
