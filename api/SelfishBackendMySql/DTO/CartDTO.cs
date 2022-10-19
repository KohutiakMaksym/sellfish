using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfishBackendMySql.DTO
{
    public class CartDTO
    {

        public long Id { get; set; }
        public double? ItemWeight { get; set; }
        public double? TotalPrice { get; set; }
        public long UserId { get; set; }
    }
}
