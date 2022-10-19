using AzureContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ILocationRepository
    {
        public ICollection<Location> GetManyLocation();

        public Location GetSingleLocation(int Id);

        public bool AddLocation(Location Location);
        public bool UpdateLocation(Location Location);
        public bool DeleteLocation(int Id);

        public bool Save();
    }
}
