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
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "CA.DAL.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // Initialise anything we need here.

            base.Seed(context);
        }
    }
}
