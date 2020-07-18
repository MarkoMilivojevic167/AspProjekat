using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dd.Api.Core;
using dd.Application;
using dd.Application.Commands;
using dd.Application.Queries;
using dd.Implementation.Commands;
using dd.Implementation.Logging;
using dd.Implementation.Queries;
using dd.Implementation.Validators;
using EfDataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace dd.Api
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



            services.AddTransient<ChinookContext>();
            services.AddTransient<IGetInvoceQuery, EfGetInvoceQuery>();
            services.AddHttpContextAccessor();
            services.AddTransient<IApplicationActor, AdminFakeApiActor>();
            services.AddTransient<IUseCaseLogger, DatabaseUseCaseLogger>();
            services.AddTransient<IDeleteInvoceCommand, EfDeleteInvoceCommand>();
            services.AddTransient<ICreateTrackCommand, EfCreateTrackCommand>();
            services.AddTransient<CreateTrackValidator>();

            services.AddTransient<UseCaseExecutor>();

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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
