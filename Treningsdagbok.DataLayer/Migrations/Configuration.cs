namespace Treningsdagbok.DataLayer.Migrations
{
    using Newtonsoft.Json;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using Treningsdagbok.DataLayer.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Treningsdagbok.DataLayer.TreningsdagbokDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Treningsdagbok.DataLayer.TreningsdagbokDbContext context)
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
            context.MuscleGroup.AddOrUpdate(x => x.Name,
                new MuscleGroup {Name= "Neck" },
                new MuscleGroup { Name = "Traps" },
                new MuscleGroup { Name = "Shoulders" },
                new MuscleGroup { Name = "Chest" },
                new MuscleGroup { Name = "Biceps" },
                new MuscleGroup { Name = "Forearm" },
                new MuscleGroup { Name = "Abs" },
                new MuscleGroup { Name = "Quads" },
                new MuscleGroup { Name = "Calves" },
                new MuscleGroup { Name = "Lats" },
                new MuscleGroup { Name = "Triceps" },
                new MuscleGroup { Name = "Middle Back" },
                new MuscleGroup { Name = "Lower Back" },
                new MuscleGroup { Name = "Glutes" },
                new MuscleGroup { Name = "Hamstrings" }
                );
            
        }
    }
}
