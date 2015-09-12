using CA.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.Portal.Migrations
{
   internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "CA.DAL.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // Initialise anything we need here.
            if (!context.Users.Any())
            {
                User user = new User();
                user.Account = "Administrator";
                user.DefaultGroup = "Everyone";
                user.ID = 1;
                context.Users.Add(user);
                context.SaveChanges();
            }

            if (!context.ADGroups.Any())
            {
                ADGroup defaultGroup = new ADGroup();
                defaultGroup.Group = "Everyone";
                defaultGroup.LinkedUserId = 1;
                context.ADGroups.Add(defaultGroup);
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}
