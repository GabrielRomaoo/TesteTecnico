using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Domain.Abstractions;
using Teste.Domain.Entities;
using Teste.Infraestructure.Data.Context;
using Teste.Infraestructure.Data.Repository;
using Teste.Service.Service;
using Teste.Service.Service.Service;

namespace TesteTecnicoApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
                
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRazorPages();
            services.AddDbContext<TesteTecnicoDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IBaseRepository<User>, UserRepository>();

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
