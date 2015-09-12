using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<ADGroup> ADGroups { get; set; }
        public virtual IDbSet<Certificate> Certificates { get; set; }

    }
}
