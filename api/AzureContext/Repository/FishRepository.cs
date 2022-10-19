using AzureContext;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class FishRepository : IFishRepository
    {
        public readonly sellfish_dbContext _context;
        public FishRepository(sellfish_dbContext context)
        {
            _context = context;
        }

        public bool AddFish(Fish fish)
        {
            _context.Fish.Add(fish);
            Save(); 

            return true;
        }

        

        public ICollection<Fish> GetManyFish()
        {
            return _context.Fish.ToList();
        }

        public Fish GetSingleFish(int Id)
        {
            return _context.Fish.FirstOrDefault(o => o.Id == Id);
        }

        public bool Save()
        {
            var IsSaved = _context.SaveChanges();

            return IsSaved > 0 ? true : false;
        }

        public bool UpdateFish(Fish fish)
        {
            _context.Fish.Update(fish);
            return Save();
        }

        public bool DeleteFish(int Id)
        {
            var fish = _context.Fish.FirstOrDefault(o => o.Id == Id);
            _context.Fish.Remove(fish);
            return Save();
        }
    }
}
