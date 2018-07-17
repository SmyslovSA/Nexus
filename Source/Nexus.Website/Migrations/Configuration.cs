namespace Nexus.Website.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Nexus.Website.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Nexus.Website.Models.ApplicationDbContext";
        }

        protected override void Seed(Nexus.Website.Models.ApplicationDbContext context)
        {
        }
    }
}
