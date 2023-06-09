﻿using Microsoft.AspNetCore.Builder;

namespace Cooperchip.ITDeveloper.Mvc.Extensions.Middlewares
{
    public static class UseAddUsersAndRolesExtension
    {
        public static IApplicationBuilder UseAddUserAndRoles(this IApplicationBuilder app)
        {
            return app.UseMiddleware<DefaultUsersAndRolesMiddeware>();
        }
    }
}
