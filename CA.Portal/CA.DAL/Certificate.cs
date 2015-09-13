using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL
{
    public class Certificate
    {
        [Key]
        public int ID { get; set; }

        public string RequestedByUser { get; set; }

        public int LinkedGroupId { get; set; }

        public virtual ADGroup LinkedGroup { get; set; }

        public DateTime RequestedOn { get; set; }

        public string UserFriendlyName { get; set; }

        public string CER { get; set; }

        public string DistingishedName { get; set; }
        public string HashAlgorithm { get; set; }
        public int PublicKeyLength { get; set; }
    }
}
