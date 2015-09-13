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

        public Certificate Update(Certificate certificate)
        {
            Certificate cer = DbContext.Certificates.FirstOrDefault(s=>s.ID == certificate.ID);
            if (cer == null)
            {
                cer = new Certificate();
                DbContext.Certificates.Add(cer);

            }
            cer.DistingishedName = certificate.DistingishedName;
            cer.HashAlgorithm = certificate.HashAlgorithm;
            cer.PublicKeyLength = certificate.PublicKeyLength;
            cer.CER = certificate.CER;
            cer.LinkedGroupId = certificate.LinkedGroupId;
            cer.RequestedByUser = certificate.RequestedByUser;
            cer.RequestedOn = certificate.RequestedOn;
            cer.UserFriendlyName = certificate.UserFriendlyName;

            if (cer.LinkedGroupId == 0)
            {
                cer.LinkedGroupId = 1; // Default to everyone
            }

            DbContext.SaveChanges();

            return cer;
        }
    }
}
