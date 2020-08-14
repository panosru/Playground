namespace Application
{
    using System.Reflection;
    using AutoMapper;
    using Commands;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // services.AddMappings(Assembly.GetExecutingAssembly());

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<GetFoo>();

            return services;
        }
    }
}