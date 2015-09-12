using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CA.Portal.Models
{
    public class BaseUserModel
    {
        public BaseUserModel()
        {

        }

        public BaseUserModel(string[] roles)
        {
            Roles = roles;
        }

        public string[] Roles { get; private set; }

        public string DefaultRole { get; set; }

        public List<SelectListItem> RolesForDropDown
        {
            get
            {
                List<SelectListItem> items = new List<SelectListItem>();
                if (Roles != null)
                {
                    foreach(var role in Roles)
                    {
                        SelectListItem item = new SelectListItem();
                        item.Value = role;
                        item.Text = role;

                        if (role.ToLower() == DefaultRole.ToLower())
                        {
                            item.Selected = true;
                        }

                        items.Add(item);
                    }
                }
                return items;
            }
        }

    }
}
