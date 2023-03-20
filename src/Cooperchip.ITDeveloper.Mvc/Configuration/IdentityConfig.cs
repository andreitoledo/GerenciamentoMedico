using Cooperchip.ITDeveloper.Mvc.Data;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cooperchip.ITDeveloper.Mvc.Configuration
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfig(this IServiceCollection services, IConfiguration configuration)
        {

            // contexto para autenticação e autorização            
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultITDeveloper")));

            // Todo: Controlar o fluxo de identidade entre outras coisas com cockie

            services.ConfigureApplicationCookie(c =>
            {
                c.AccessDeniedPath = "/Identity/Account/AccessDenied";
                c.Cookie.Name = "ManagementMedical";
                c.Cookie.HttpOnly = true;
                c.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                c.SlidingExpiration = true;
                c.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                c.LoginPath = "/Identity/Account/Login";
                c.LogoutPath = "/Identity/Account/Logout";

            });

            services.AddDefaultIdentity<ApplicationUser>(
                opt =>
            {
                    // User Config
                    opt.User.RequireUniqueEmail = true;
                    opt.User.AllowedUserNameCharacters =
                    "abcdefghijlmnopqrstuvwxyzABCDEFGHIJLMNOPQRSTUVWXYZ0123456789-._@+";

                    // Lockout Config

                    opt.Lockout.AllowedForNewUsers = true;
                    opt.Lockout.MaxFailedAccessAttempts = 4;
                    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(4);

                    // SignIn Config
                    opt.SignIn.RequireConfirmedPhoneNumber = false;
                    opt.SignIn.RequireConfirmedAccount = false;
                    opt.SignIn.RequireConfirmedEmail = true; // Pay Attention

                    // Password Config                
                    opt.Password.RequireUppercase = true;        //A
                    opt.Password.RequireLowercase = true;        // dmin
                    opt.Password.RequireNonAlphanumeric = true;  //@
                    opt.Password.RequireDigit = true;            // 123
                    opt.Password.RequiredLength = 8;
                    opt.Password.RequiredUniqueChars = 2;        // aa

                }).AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


            return services;

        }
    }
}
