namespace Application
{
    using System;
    using System.Reflection;
    using Commands;
    using Lib.Mapping;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, Assembly assembly)
        {
            services.AddMappings(
                Assembly.GetExecutingAssembly(), 
                Assembly.GetExecutingAssembly());

            services.AddScoped<GetFooCommand>();
            services.AddScoped<GetBarCommand>();
            
            return services;
        }
    }
}