using Cooperchip.ITDeveloper.Mvc.Extensions.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Cooperchip.ITDeveloper.Mvc.Configuration
{
    public static class MvcAndRazorConfig
    {
        public static IServiceCollection AddMvcAndRazorConfig(this IServiceCollection services)
        {

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(AuditoriaIloggerFilter));
                // Todo: add >> AutoValidateAntiforgeryTokenAttribute

            });

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddRazorPages();

            services.AddScoped<AuditoriaIloggerFilter>();

            return services;

        }
    }
}
