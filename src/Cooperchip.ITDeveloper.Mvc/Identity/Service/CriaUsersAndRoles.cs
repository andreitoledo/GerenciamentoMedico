using Cooperchip.ITDeveloper.Mvc.Data;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Identity.Service
{
    public class CriaUsersAndRoles
    {
        public static async Task Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
           RoleManager<IdentityRole> roleManager)
        {
            const string nomecompleto = "Elder Mutt";
            const string apelido = "Mutt";
            var datanascimento = DateTime.Now;
            const string email = "eldermutt@proton.me";
            const string password = "Admin@123";
            const string roleName = "Admin";
            const string username = email;


            context.Database.Migrate();

            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            if (await userManager.FindByNameAsync(username) == null)
            {
                var user = new ApplicationUser
                {
                    Apelido = apelido,
                    NomeCompleto = nomecompleto,
                    DataNascimento = datanascimento,
                    UserName = username,
                    Email = email,
                    PhoneNumber = "11989544786",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleName);
                }

            }

        }
    }
}
