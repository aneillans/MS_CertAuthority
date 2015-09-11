using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DAL.Repositories
{
    public interface IUserRepository : IDisposable
    {
        List<User> GetUsers();

        List<User> GetUsers(string team);

        User GetUser(string accountName);
    }
}
