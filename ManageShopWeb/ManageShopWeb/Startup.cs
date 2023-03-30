namespace ManageShopWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseSession();
            app.UseMvc();
            app.Run(context => {
                return context.Response.WriteAsync("Hello World!");
            });
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
            });
        }
    }
}
