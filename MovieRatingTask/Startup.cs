using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MovieRatingTask.Core;
using MovieRatingTask.Core.Extensions;
using MovieRatingTask.Data;
using MovieRatingTask.Data.Context;
using MovieRatingTask.Data.Extensions;
using System;
using System.Reflection;

namespace MovieRatingTask
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var assemblies = new[] { Assembly.GetExecutingAssembly(), Assembly.GetAssembly(typeof(DataAssembly)), Assembly.GetAssembly(typeof(CoreAssembly)) };

            var connectionString = Configuration.GetValue<string>("Database:ConnectionString");


            services.AddDbContext<DatabaseContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddControllers();

            services.AddCommandHandlers(assemblies);

            services.AddRepositories(assemblies);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper(assemblies);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MovieRatingTask.API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieRatingTask.API v1"));
            }

            app.UseRouting();
            app.UseCors(builder =>
            {
                builder.WithOrigins("http://localhost:4200");
                builder.AllowAnyHeader();
                builder.WithExposedHeaders("X-Pagination");
                builder.AllowAnyMethod();
                builder.AllowCredentials();
                builder.Build();
            });

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}