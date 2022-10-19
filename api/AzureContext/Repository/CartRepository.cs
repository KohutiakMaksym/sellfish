using AzureContext;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CartRepository : ICartRepository
    {
        public readonly sellfish_dbContext _context;
        public CartRepository(sellfish_dbContext context)
        {
            _context = context;
        }

        public bool AddCart(Cart Cart)
        {
            var user = _context.Users.FirstOrDefault(o => o.Id == Cart.UserId);

            if (user == null)
            {
                return false;
            }

            Cart.User = user;

            _context.Carts.Add(Cart);
            
            return Save();
        }

        public ICollection<Cart> GetCarts()
        {
            return _context.Carts.ToList();
        }

        public Cart GetCart(int Id)
        {
            return _context.Carts.FirstOrDefault(o => o.Id == Id);  
        }

        public bool Save()
        {
            var IsSaved = _context.SaveChanges();

            return IsSaved > 0 ? true : false;
        }

        public bool UpdateCart(Cart Cart)
        {
            _context.Carts.Update(Cart);
            return Save();
        }

        public bool DeleteCart(Cart Cart)
        {
            _context.Carts.Remove(Cart);
            return Save();
        }
    }
}
