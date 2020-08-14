namespace Application
{
    using System.Reflection;
    using AutoMapper;
    using Commands;
    using Lib.Mapping;
    using Mappers;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, Assembly assembly)
        {
            services.AddAutoMapper(
                cfg =>
                {
                    cfg.AddProfile(new MappingProfile(Assembly.GetExecutingAssembly()));
                }, typeof(BarProfile).Assembly);

            services.AddScoped<GetFooCommand>();
            services.AddScoped<GetBarCommand>();
            
            return services;
        }
    }
}