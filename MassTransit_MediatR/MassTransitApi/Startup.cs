namespace MassTransitApi
{
    using Commands;
    using Events;
    using MassTransit;
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
            services.AddMvc();

            services.AddMediator(config =>
            {
                config.AddConsumer<UserConsumer>();
                config.AddConsumer<InformAboutUserCreation>();
                config.AddConsumer<EmailCreatedUser>();

                config.AddRequestClient<CreateUser>();
                config.AddRequestClient<UserCreated>();
            });

            services.AddMassTransit(x => { x.UsingInMemory(); });

            services.AddOpenApiDocument(config => config.PostProcess = d => d.Info.Title = "Sample API");
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