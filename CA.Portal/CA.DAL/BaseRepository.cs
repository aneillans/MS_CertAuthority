using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL
{
    public abstract class BaseRepository : IDisposable
    {
        protected ApplicationDbContext DbContext { get; set; }

        protected BaseRepository(ApplicationDbContext context)
        {
            DbContext = context;
        }

        public virtual void Dispose()
        {
            if (DbContext != null)
            {
                DbContext.Dispose();
            }
        }
    }
}
