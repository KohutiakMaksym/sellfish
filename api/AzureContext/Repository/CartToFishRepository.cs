using AzureContext;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CartToFishRepository : ICartToFishRepository
    {
        public readonly sellfish_dbContext _context;
        
        public CartToFishRepository(sellfish_dbContext context)
        {
            _context = context;
        }
        public bool AddCartToFish(CartToFish CartToFish)
        {
            _context.CartToFishes.Add(CartToFish);   
            return Save();
        }

        public bool DeleteCartToFish(int Id)
        {
            throw new NotImplementedException();
        }

        public CartToFish GetCartToFish(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<CartToFish> GetCartToFishs()
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var IsSaved = _context.SaveChanges();
            return IsSaved > 0 ? true : false;
        }

        public bool UpdateCartToFish(CartToFish cartToFish)
        {
            throw new NotImplementedException();
        }
    }
}
