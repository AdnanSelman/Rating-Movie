using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MovieRatingTask.Core.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection, Assembly[] assemblies)
        {
            const string marker = "Repository";
            return serviceCollection.AddServicesAsImplementedInterface(marker, ServiceLifetime.Transient, assemblies, i => i.Name.Contains(marker));
        }

        public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
        {
            return AddRepositories(serviceCollection, new[] { Assembly.GetExecutingAssembly() });
        }
    }
}
