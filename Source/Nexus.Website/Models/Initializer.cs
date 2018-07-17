using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Nexus.Website.Models
{
    public class Initializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var adminRole = new IdentityRole { Name = "admin" };
            var customerRole = new IdentityRole { Name = "customer" };
            var salerRole = new IdentityRole { Name = "saler" };
            roleManager.Create(adminRole);
            roleManager.Create(customerRole);
            roleManager.Create(salerRole);
            base.Seed(context);
        }
    }
}