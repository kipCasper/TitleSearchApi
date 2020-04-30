using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using TitleSearchApi.Models;
using TitleSearchApi.Services;

namespace TitleSearchApi
{
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
            services.AddCors(options => 
            {
                options.AddPolicy("EnableCORS",
                          builder =>
                              {
                                  builder.WithOrigins("http://localhost:4200",
                                                      "http://www.contoso.com");
                              });
            });

            services.AddOptions();
            
            // requires using Microsoft.Extensions.Options
            services.Configure<TurnerDatabaseSettings>(
            Configuration.GetSection(nameof(TurnerDatabaseSettings)));

            services.AddSingleton<ITurnerDatabaseSettings>(sp =>
            sp.GetRequiredService<IOptions<TurnerDatabaseSettings>>().Value);

            services.AddSingleton<TitleService>();


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("EnableCORS");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
