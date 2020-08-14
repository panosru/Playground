namespace Application
{
    using System.Reflection;
    using AutoMapper;
    using Lib.Mapping;
    using MediatR;
    // using Commands;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, Assembly assembly)
        {
            // services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMappings(Assembly.GetExecutingAssembly());
            
            services.AddMediatR(Assembly.GetExecutingAssembly());
    
            // services.AddScoped<GetFoo>();
    
            return services;
        }
    }
}