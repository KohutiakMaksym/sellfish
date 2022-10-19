using System;
using System.Collections.Generic;

#nullable disable

namespace AzureContext
{
    public partial class Location
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }

        public virtual User User { get; set; }
    }
}
