namespace Restaurant.Service;

using Restaurant.Service.Configurations;

public class Startup(IConfiguration configuration)
{
    public void ConfigureServices(IServiceCollection services)
    {
        _ = services.ConfigureServices(configuration);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        _ = app.ConfigureApplication(env);
    }
}
