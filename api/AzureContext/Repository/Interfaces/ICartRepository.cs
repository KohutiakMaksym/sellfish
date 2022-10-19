using AzureContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ICartRepository
    {
        public ICollection<Cart> GetCarts();

        public Cart GetCart(int Id);

        public bool AddCart(Cart Cart);

        public bool UpdateCart(Cart Cart);

        public bool DeleteCart(Cart Cart);

        public bool Save();
    }
}
