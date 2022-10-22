using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SelfishBackendMySql.DTO
{
    public class LocationDTO
    {
        [JsonIgnore]
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }

    }
}
