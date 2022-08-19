
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models; //add for swagger documentation
using System;   //Add for swagger documentation
using System.Reflection; //add for swagger documentation
using AnimalShelter.Models;
using System.IO; //Adds definition for path, use to ad swagger documentation
namespace AnimalShelter
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

            services.AddDbContext<AnimalShelterContext>(opt =>
                opt.UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
            services.AddControllers();

            services.AddSwaggerGen(options =>
            {
              options.SwaggerDoc("v1", new OpenApiInfo
              {
                Version = "v1",
                Title = "AnimalShelter Api",
                Description = "An ASP.NET Core Web API for displaying animals at an animal shelter",
                Contact = new OpenApiContact
                {
                  Name = "Justin Peters", 
                  Url = new Uri("https://github.com/jpeters25")
                },
                License = new OpenApiLicense
                {
                  Name = "MIT License",
                  Url = new Uri("https://github.com/jpeters25/AnimalShelter.Solution/blob/main/LICENSE")
                }
              });
              var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
              options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
              options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
              options.RoutePrefix = string.Empty;
            });
        }
    }
}