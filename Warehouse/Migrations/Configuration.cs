namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.WarehouseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.WarehouseContext context)
        {
            context.Products.AddOrUpdate(
                p => p.Name,
                new Models.Product { Name = "Waffler", Category = "appliances", Price = 578, Count = 30 },
                new Models.Product { Name = "Somsang GX-1000", Category = "electronics", Price = 2099, Count = 3 },
                new Models.Product { Name = "Trilobite", Category = "appliances", Price = 5098, Count = 6 },
                new Models.Product { Name = "Toaster", Category = "appliances", Price = 499, Count = 45,
                    Description = "Br�drost fr�n Acme, med br�dfack som kan justeras i bredd f�r perfekt rostning. J�mn, gyllenbrun rostning p� b�de tjocka och tunna skivor. Praktisk med funktioner f�r upptining och �teruppv�rmning. S�ker att anv�nda med h�g upplyftningsfunktion, avbryt-knapp och sval utsida." }
                );

        }
    }
}
