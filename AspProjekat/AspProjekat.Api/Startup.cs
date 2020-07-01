using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspProjekat.Api.Core;
using AspProjekat.Application;
using AspProjekat.Application.Commands;
using AspProjekat.Application.Queries;
using AspProjekat.EfDataAccess;
using AspProjekat.Implementation.Commands;
using AspProjekat.Implementation.Logging;
using AspProjekat.Implementation.Queries;
using AspProjekat.Implementation.Validators;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace AspProjekat.Api
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

            var appSettings = new AppSettings();

            Configuration.Bind(appSettings);

            services.AddTransient<AspProjekatContext>();
            services.AddTransient<ICreateRoleCommand, EfCreateRoleCommand>();

            services.AddAutoMapper(this.GetType().Assembly);

            services.AddTransient<ICreateRoleCommand, EfCreateRoleCommand>();
            services.AddTransient<IDeleteRoleCommand, EfDeleteRoleCommand>();
            services.AddTransient<ICreateCategoryCommand, EfCreateCategoryCommand>();
            services.AddTransient<ICreateProductCommand, EfCreateProductCommand>();
            services.AddTransient<IDeleteProductCommand, EfDeleteProductCommand>();
            services.AddTransient<IDeleteCategoryCommand, EfDeleteCategoryCommand>();

            services.AddHttpContextAccessor();
            services.AddTransient<IApplicationActor>(x =>
            {
                var accessor = x.GetService<IHttpContextAccessor>();


                var user = accessor.HttpContext.User;

                if (user.FindFirst("ActorData") == null)
                {
                    throw new InvalidOperationException("Actor data doesnt exist in token.");
                }

                var actorString = user.FindFirst("ActorData").Value;

                var actor = JsonConvert.DeserializeObject<JwtActor>(actorString);

                return actor;

            });
            services.AddTransient<IGetRolesQuery, EfGetRolesQuery>();
            services.AddTransient<IGetCategoriesQuery, EfGetCateogryQuery>();
            services.AddTransient<IGetProductQuery, EfGetProductQuery>();
            services.AddTransient<IUseCaseLogger, ConsoleUseCaseLogger>();
            services.AddTransient<UseCaseExecutor>();
            services.AddTransient<CreateRoleValidator>();
            services.AddTransient<CreateProductValidator>();
            services.AddTransient<CreateCategoryValidator>();
            services.AddTransient<JwtManager>();

            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = "asp_api",
                    ValidateIssuer = true,
                    ValidAudience = "Any",
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsMyVerySecretKey")),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });

            


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseMiddleware<GlobalExceptionHandler>();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
