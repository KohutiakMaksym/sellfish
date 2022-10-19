using System;
using System.Collections.Generic;

#nullable disable

namespace AzureContext
{
    public partial class Cart
    {
        public Cart()
        {
            CartToFishes = new HashSet<CartToFish>();
        }

        public long Id { get; set; }
        public double? ItemWeight { get; set; }
        public double? TotalPrice { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<CartToFish> CartToFishes { get; set; }
    }
}
