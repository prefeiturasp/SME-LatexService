using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;

namespace LatexService.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // CORS (Cross-Origin Requests)
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyOrigin() // Ulilizar a função abaixo e comentar essa para definir permissão de acesso de determinadas origens, caso contrário será aceito qualquer origem da requisição
                                          //.WithOrigins("https://mydomain.com", "http://outroendereco.com.br")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .Build());
            });

            // Registra o Swagger Generator (OpenAPI)
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("documentation", new Swashbuckle.AspNetCore.Swagger.Info()
                {
                    Title = "LatexService.API",
                    Version = "v1.0.0",
                    Description = "Documentação das APIs do LatexService.API (.NET Core v2.2 + LaTeX)",
                });

                string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("CorsPolicy");
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/documentation/swagger.json", "LatexService.API");
                options.RoutePrefix = "";
            });

            app.UseMvc();
        }
    }
}