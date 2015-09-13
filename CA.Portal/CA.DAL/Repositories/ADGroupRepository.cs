using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL.Repositories
{
    public class ADGroupRepository : BaseRepository, IADGroupRepository
    {
        public ADGroupRepository(ApplicationDbContext context) : base(context)
        {

        }


        public List<User> GetUsersInGroup(string groupName)
        {
            throw new NotImplementedException();
        }
    }
}
