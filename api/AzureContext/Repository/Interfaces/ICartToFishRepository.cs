using AzureContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ICartToFishRepository
    {
        public ICollection<CartToFish> GetCartToFishs();

        public CartToFish GetCartToFish(int Id);

        public bool AddCartToFish(CartToFish CartToFish);

        public bool UpdateCartToFish(CartToFish cartToFish);

        public bool DeleteCartToFish(int Id);

        public bool Save();
    }
}
