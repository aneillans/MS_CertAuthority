using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.Portal.Models
{
    public class RequestCertificateModel
    {
        public int PublicKeyLength { get; set; }
        public string HashAlgorithm { get; set; }
        public string DistingishedName { get; set; }

        [DisplayName("Requested By")]
        public string RequestedBy { get; set; }

        [DisplayName("User Friendly Name")]
        [Required]
        public string FriendlyName { get; set; }

        [DisplayName("Assigned to Group")]
        public string AssignedGroup { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string CSR { get; set; }

        public bool Issued { get; set; }

        public int CertificateId { get; set; }

    }
}
