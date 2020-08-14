namespace Lib.Mapping
{
    using System.Reflection;
    using AutoMapper;
    using Microsoft.Extensions.DependencyInjection;

    public static class Mapping
    {
        public static IServiceCollection AddMappings(
            this IServiceCollection services,
            Assembly assembly)
        {
            services.AddAutoMapper(assembly);

            return services;
        }
    }
}