using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureContext.Repository
{
    public class LocationRepository : ILocationRepository
    {
        public readonly sellfish_dbContext _context;

        public LocationRepository(sellfish_dbContext context)
        {
            _context = context;
        }

        public bool AddLocation(Location Location)
        {
            _context.Locations.Add(Location);
            return Save();
        }

        public ICollection<Location> GetManyLocation()
        {
            return _context.Locations.ToList();
        }

        public Location GetSingleLocation(int Id)
        {
            return _context.Locations.SingleOrDefault( o => o.Id == Id);
        }

        public bool DeleteLocation(int Id)
        {
            var Location = _context.Locations.FirstOrDefault(o => o.Id == Id);
            _context.Locations.Remove(Location);
            return Save();
        }

        public bool Save()
        {
            var IsSaved = _context.SaveChanges();

            return IsSaved > 0 ? true : false;
        }

        public bool UpdateLocation(Location Location)
        {
            _context.Locations.Update(Location);
            return Save();
        }
    }
}
