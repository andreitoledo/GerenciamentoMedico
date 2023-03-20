using Cooperchip.ITDeveloper.Mvc.Extensions.ExtensionsMethods;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cooperchip.ITDeveloper.Mvc.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }       

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //builder.AddUserAndRole(); // Alt Systems
            //builder.AddGenericos(); // Generico.CSV            


            base.OnModelCreating(builder); 

        }
    }
}
