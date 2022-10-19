using AzureContext;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly sellfish_dbContext _context;
        public UserRepository(sellfish_dbContext context)
        {
            _context = context;
        }

        public bool AddUser(User User)
        {


            _context.Users.Add(User);
            return Save();
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUser(int Id)
        {
            return _context.Users.Include(u => u.Cart)
                                 .ThenInclude( u => u.CartToFishes).ThenInclude( f => f.Item)
                                 .FirstOrDefault(o => o.Id == Id);
        }

        public bool Save()
        {
            var IsSaved = _context.SaveChanges();

            return IsSaved > 0 ? true : false;
        }

        public bool UpdateUser(User user)
        {
            _context.Users.Update(user);
            return Save();
        }


        public bool DeleteUser(User user)
        {
            _context.Users.Remove(user);
            return Save();
        }
    }
}
