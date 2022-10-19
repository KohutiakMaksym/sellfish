using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfishBackendMySql.DTO
{
    public class FishDTO
    {
        public long Id { get; set; }
        public string FishName { get; set; }
        public double FishWeight { get; set; }
        public int FishAmount { get; set; }
        public double FishPrice { get; set; }
        public string Description { get; set; }
            
    }
}
