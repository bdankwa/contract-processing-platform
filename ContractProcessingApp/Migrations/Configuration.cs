namespace ContractProcessingApp.Migrations
{
    using ContractProcessingApp.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContractProcessingApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ContractProcessingApp.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(u => u.UserName == "admin@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "admin@gmail.com", Email = "admin@gmail.com" };
                IdentityResult result = userManager.Create(user, "Pyramid$1777");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Admin" });
                context.SaveChanges();

                userManager.AddToRole(user.Id, "Admin");
                context.SaveChanges();
            }

            if (!context.Users.Any(u => u.UserName == "bdankwa@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "bdankwa@gmail.com", Email = "bdankwa@gmail.com" };
                IdentityResult result = userManager.Create(user, "Pyramid$1777");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Cust" });
                context.SaveChanges();

                userManager.AddToRole(user.Id, "Cust");
                context.SaveChanges();
            }

            if (!context.Users.Any(u => u.UserName == "okodua@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "okodua@gmail.com", Email = "okodua@gmail.com" };
                IdentityResult result = userManager.Create(user, "Pyramid$1777");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Cust" });
                context.SaveChanges();

                userManager.AddToRole(user.Id, "Cust");
                context.SaveChanges();
            }

            if (!context.Users.Any(u => u.UserName == "kkdankwa@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "kkdankwa@gmail.com", Email = "kkdankwa@gmail.com" };
                IdentityResult result = userManager.Create(user, "Pyramid$1777");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Empl" });
                context.SaveChanges();

                userManager.AddToRole(user.Id, "Empl");
                context.SaveChanges();
            }

            if (!context.Users.Any(u => u.UserName == "bill@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "bill@gmail.com", Email = "bill@gmail.com" };
                IdentityResult result = userManager.Create(user, "Pyramid$1777");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "Cont" });
                context.SaveChanges();

                userManager.AddToRole(user.Id, "Cont");
                context.SaveChanges();
            }

            CityOrTown koforidua = new CityOrTown { CityOrTownID = 1, City = "Koforidua" };
            CityOrTown accra = new CityOrTown { CityOrTownID = 2, City = "Accra" };
            CityOrTown legos = new CityOrTown { CityOrTownID = 3, City = "Legos" };
            CityOrTown takoradi = new CityOrTown { CityOrTownID = 4, City = "Takoradi" };

            List<CityOrTown> easterncities = new List<CityOrTown>
            {
                koforidua, accra
            };

            List<CityOrTown> westerncities = new List<CityOrTown>
            {
                takoradi
            };


            List<CityOrTown> nigeriacities = new List<CityOrTown>
            {
                legos
            };

            Region eastern = new Region() { RegionID = 1, RegionName = "Eastern", CityOrTowns = easterncities };
            Region western = new Region() { RegionID = 3, RegionName = "Western", CityOrTowns = westerncities };
            Region south = new Region() { RegionID = 2, RegionName = "South", CityOrTowns = nigeriacities };

            List<Region> ghanaregions = new List<Region>
            {
                eastern,
                western
            };


            List<Region> nigeriaregions = new List<Region>
            {
                south
            };

            Country ghana = new Country() { CountryID = 1, CountryName = "Ghana", Regions = ghanaregions };
            Country nigeria = new Country() { CountryID = 2, CountryName = "Nigeria", Regions = nigeriaregions };

            context.Countries.AddOrUpdate(x => x.CountryID,
               ghana,
               nigeria
                );
            context.SaveChanges();

            context.Regions.AddOrUpdate(x => x.RegionID,
                eastern,
                western,
                south
                );
            context.SaveChanges();

            context.CityOrTown.AddOrUpdate(x => x.CityOrTownID,
                koforidua,
                legos,
                accra,
                takoradi);
            context.SaveChanges();


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
        }
    }
}
