using Personal_Calendar.Models;

namespace Personal_Calendar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Personal_Calendar.Models.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Personal_Calendar.Models.ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Events.AddOrUpdate(
                e => e.ID,
                new DbEvent
                {
                    Description = "THIS IS A TEST PLEASE IGNORE!",
                    EndTime = DateTime.Now.AddDays(1),
                    StartTime = DateTime.Now,
                    Location = "YO MOMMA'S HOUSE!",
                    Priority = 1,
                    Title = "LOVE YOU MOMMA"
                });
        }
    }
}
