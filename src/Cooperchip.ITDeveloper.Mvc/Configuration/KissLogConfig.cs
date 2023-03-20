using KissLog.AspNetCore;
using KissLog.CloudListeners.RequestLogsListener;
using KissLog;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Diagnostics;
using KissLog.Formatters;

namespace Cooperchip.ITDeveloper.Mvc.Configuration
{
    public static class KissLogConfig
    {
        public static void AddLoggerConfig(this IServiceCollection services)
        {
            // logger ========= inicio
            services.AddHttpContextAccessor();

            // Optional. Register IKLogger if you use KissLog.IKLogger instead of Microsoft.Extensions.Logging.ILogger<>
            services.AddScoped<IKLogger>((provider) => Logger.Factory.Get());

            services.AddLogging(logging =>
            {
                logging.AddKissLog(options =>
                {
                    options.Formatter = (FormatterArgs args) =>
                    {
                        if (args.Exception == null)
                            return args.DefaultValue;

                        string exceptionStr = new ExceptionFormatter().Format(args.Exception, args.Logger);
                        return string.Join(Environment.NewLine, new[] { args.DefaultValue, exceptionStr });
                    };
                });
            });
            // logger ========= fim            

        }

    }

}
