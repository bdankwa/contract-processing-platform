namespace ContractProcessingApp.Migrations
{
    using ContractProcessingApp.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
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
