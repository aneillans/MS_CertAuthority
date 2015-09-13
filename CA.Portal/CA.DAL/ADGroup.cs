using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL
{
    public class ADGroup
    {
        [Key]
        public int ID { get; set; }

        public int LinkedUserId { get; set; }

        public virtual User LinkedUser { get; set; }

        public string Group { get; set; }

    }
}
