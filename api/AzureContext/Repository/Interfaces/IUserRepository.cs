using AzureContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IUserRepository
    {
        public ICollection<User> GetUsers();

        public User GetUser(int Id);

        public bool AddUser(User user);

        public bool UpdateUser(User user);

        public bool DeleteUser(User user);

        public bool Save();
    }
}
