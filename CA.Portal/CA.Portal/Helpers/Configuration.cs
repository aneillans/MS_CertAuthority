using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.Portal.Helpers
{
    public static class Configuration
    {
        public static string Domain
        {
            get
            {
                return ConfigurationManager.AppSettings["Domain"];
            }
        }

        public static string AdminGroup
        {
            get
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["AdminGroup"]))
                {
                    return ConfigurationManager.AppSettings["AdminGroup"];
                }
                return "Domain Users";
            }
        }

        public static string CAServer
        {
            get
            {
                return ConfigurationManager.AppSettings["CAServer"];
            }
        }
    }
}
