namespace Restaurant.Service.Configurations;

public static class ApplicationConfiguration
{
    public static IApplicationBuilder ConfigureApplication(
        this IApplicationBuilder app,
        IWebHostEnvironment env
    )
    {
        return app.UseExceptionHandler()
            .ConfigureProductionMode(env)
            .ConfigureDevelopmentMode(env)
            .UseRouting()
            .UseEndpoints(static endpoints => endpoints.MapControllers());
    }

    private static IApplicationBuilder ConfigureProductionMode(
        this IApplicationBuilder app,
        IWebHostEnvironment env
    )
    {
        if (env.IsProduction())
        {
            _ = app.UseHttpsRedirection();
        }

        return app;
    }

    private static IApplicationBuilder ConfigureDevelopmentMode(
        this IApplicationBuilder app,
        IWebHostEnvironment env
    )
    {
        if (env.IsDevelopment())
        {
            _ = app.UseSwagger().UseSwaggerUI();
        }

        return app;
    }
}
