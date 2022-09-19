using SiteGabriel.Infra.Data.Context;
using System.Data.Entity.Migrations;

namespace SiteGabriel.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
