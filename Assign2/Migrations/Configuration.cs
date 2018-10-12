namespace Assign2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assign2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Assign2.Models.ApplicationDbContext context)
        {

            context.Sale.AddOrUpdate(i => i.Id,
               new Models.Sale()
               {
                   Id = 1,
                   Date = DateTime.Now,
               });

            context.Customer.AddOrUpdate(i => i.Id,
                new Models.Customer(){Id = 1,});

            context.Employee.AddOrUpdate(i => i.Id,
            new Models.Employee()
            {Id = 1,});
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
