using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL
{
    public class User
    {
        [Key()]
        public int ID { get; set; }

        public string Account { get; set; }

        public string DefaultGroup { get; set; }
    }
}
