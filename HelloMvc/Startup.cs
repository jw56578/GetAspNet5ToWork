using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.Http;

namespace HelloMvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole();

            //app.UseIISPlatformHandler();

            //app.UseDeveloperExceptionPage();

            //app.UseMvcWithDefaultRoute();

            //app.UseWelcomePage();
            app.Run(async (context) => {
                await context.Response.WriteAsync("hello world");
            });
        }
    }
}