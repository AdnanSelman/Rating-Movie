using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MovieRatingTask.Data.Extensions
{
    public static class CqrsExtensions
    {
        public static IServiceCollection AddCommandHandlers(this IServiceCollection serviceCollection,
            Assembly[] assemblies)
        {
            return serviceCollection.AddMediatR(assemblies);
        }
    }
}