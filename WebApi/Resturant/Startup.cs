using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Interfaces.Client;
using WebAPI.Interfaces.Repo;
using WebAPI.Interfaces.Services;
using WebAPI.Repository;
using WebAPI.Repository.Client;
using WebAPI.Repository.Repo;
using WebAPI.Services;


namespace Resturant
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //Register AutoMapper
            services.AddAutoMapper(typeof(Startup));
            //Register swagger service
            services.AddSwaggerDocument();

            services.AddSingleton<IloggerManager, LoggerManager>();

            var connectionString = Configuration["ConnectionStrings:ConnectionStr"];
            services.AddDbContext<compassContext>(option =>
            {
                option.UseMySQL(connectionString);
                option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });



            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            services.AddTransient<IBrandsRepo, BrandsRepo>();
            services.AddTransient<IBrandService, BrandsService>();

            services.AddTransient<IItemsRepo, ItemsRepo>();
            services.AddTransient<IItemService, ItemsService>();

            services.AddTransient<IMenusRepo, MenusRepo>();
            services.AddTransient<IMenusService, MenusService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }            
            app.UseMvc();
        }
    }
}
