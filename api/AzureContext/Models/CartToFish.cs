using System;
using System.Collections.Generic;

#nullable disable

namespace AzureContext
{
    public partial class CartToFish
    {
        public long CartId { get; set; }
        public long ItemId { get; set; }
        public long Id { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Fish Item { get; set; }
    }
}
