using System;
using System.Collections.Generic;

#nullable disable

namespace AzureContext
{
    public partial class Fish
    {
        public Fish()
        {
            CartToFishes = new HashSet<CartToFish>();
        }

        public long Id { get; set; }
        public string FishName { get; set; }
        public double FishWeight { get; set; }
        public int FishAmount { get; set; }
        public double FishPrice { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<CartToFish> CartToFishes { get; set; }
    }
}
