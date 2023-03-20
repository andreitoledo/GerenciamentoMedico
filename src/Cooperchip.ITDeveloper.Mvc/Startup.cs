using Cooperchip.ITDeveloper.Data.ORM;
using Cooperchip.ITDeveloper.Mvc.Configuration;
using Cooperchip.ITDeveloper.Mvc.Data;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity.Service;
using Cooperchip.ITDeveloper.Mvc.Identity.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

using KissLog;
using KissLog.AspNetCore;
using KissLog.CloudListeners.Auth;
using KissLog.CloudListeners.RequestLogsListener;
using KissLog.Formatters;
using Cooperchip.ITDeveloper.Mvc.Extensions.Filters;
using Cooperchip.ITDeveloper.Mvc.Extensions.Middlewares;
using System.Text;

namespace Cooperchip.ITDeveloper.Mvc
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

            services.AddMvcAndRazorConfig(); // in MvcAndRazorConfig            
            services.AddDbContextConfig(Configuration); // in DbContextConfig            
            services.AddIdentityConfig(Configuration); // in IdentityConfig            
            services.AddDependencyInjectConfig(Configuration); // in DependencyInjectConfig
            services.AddLoggerConfig(); // in KissLogConfig            
            // Prover Suporte para Code Page (1252) (windows-1252)            
            services.AddCodePageProviderNotSupportedInDotNetCoreForAnsi();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                app.UseExceptionHandler("/Logger/Index");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // inicio Logger / filtro
            // só roda o Logger se o executar em produção.
            if (env.IsProduction())
            {
                app.UseKissLogMiddleware(options =>
                {
                    KissLogConfiguration.Listeners.Add(new RequestLogsApiListener(new Application(
                 Configuration["KissLog.OrganizationId"],    //  "c6437481-03e3-4553-8485-deb42b71f029"
                 Configuration["KissLog.ApplicationId"])     //  "eb025f17-13a8-4f81-b3e8-7aff415594b2"
             )
                    {
                        ApiUrl = Configuration["KissLog.ApiUrl"]    //  "https://api.kisslog.net"
                    });
                });
            }

            // configura o envio de emails
            var authMsgSenderOpt = new AuthMessageSenderOptions
            {
                SendGridUser = Configuration["SendGridUser"],
                SendGridKey = Configuration["SendGridKey"]
            };
            // fim Logger / filtro
            
            // Uma maneira de criar usuários roles - middleware            
            //app.UseAddUserAndRoles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });


        }      

    }
}
