using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL.Repositories
{
    public interface IADGroupRepository
    {
        List<User> GetUsersInGroup(string groupName);
        
    }
}
