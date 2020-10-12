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
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using BilanceExchange.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Bilance_Exchange.Domain.Interfaces;
using Bilance_Exchange.Repository.Repositories;
using Bilance_Exchange.Domain.Validators;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Bilance_Exchange.Domain.Services;
using Bilance_Exchange.Domain.Interfaces.Service;
using Bilance_Exchange.Domain.Services.Security;

namespace BilanceExchange
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional: false, reloadOnChange: true );
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var connectionString = Configuration.GetConnectionString("BilanceExchangeDB");
            services.AddDbContext<BilanceExchangeContext>(option => option.UseLazyLoadingProxies().UseMySql(connectionString,
                                                        m => m.MigrationsAssembly("BilanceExchange.Repository")));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ValidateModelAttribute));
            })
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<UserValidator>());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
