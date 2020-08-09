namespace MassTransitApi
{
    using System.Reflection;
    using Commands;
    using Events;
    using MassTransit;
    using MassTransit.Mediator;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMediator(mediator =>
            {
                mediator.AddRequestClient<CreateUser>();
                
                mediator.AddConsumers(Assembly.GetExecutingAssembly());
            });

            services.AddMassTransit(transit =>
            {
                transit.UsingInMemory((context, cfg) =>
                {
                    cfg.TransportConcurrencyLimit = 100;
                    
                    cfg.ConfigureEndpoints(context);
                });
            });

            services.AddOpenApiDocument(config => config.PostProcess = d => d.Info.Title = "Sample API");

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}