using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }

        public User GetUser(string accountName)
        {
            return DbContext.Users.FirstOrDefault(s => s.Account.ToLower() == accountName.ToLower());
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers(string team)
        {
            throw new NotImplementedException();
        }

    }
}
