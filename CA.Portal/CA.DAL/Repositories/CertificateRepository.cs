using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL.Repositories
{
    public class CertificateRepository : BaseRepository, ICertificateRepository
    {
        public CertificateRepository(ApplicationDbContext context) : base(context)
        {

        }

        public Certificate Get()
        {
            throw new NotImplementedException();
        }
    }
}
