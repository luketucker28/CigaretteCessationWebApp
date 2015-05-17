

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CigaretteCessationWebApp.Models;
using System.Data.Entity;


namespace CigaretteCessationWebApp.Repository
{

    public class ConsumedRepository
    {
        private CigaretteCessationContext _dbContext;

        public ConsumedRepository()
        {
            _dbContext = new CigaretteCessationContext();
            _dbContext.Consumeds.Load();

        }
        public CigaretteCessationContext Context()
        {
            return _dbContext;
        }

        public DbSet<Consumed> GetDbSet()
        {
            return _dbContext.Consumeds;
        }

        public int GetCount()
        {
            return _dbContext.Consumeds.Count<Consumed>();

        }
      
        public void Clear()
        {
            var b = this.All();
            _dbContext.Consumeds.RemoveRange(b);
        }

        public IEnumerable<Consumed>All()
        {
            var qu = from Consumed in _dbContext.Consumeds select Consumed;
            return qu.ToList<Consumed>();
        }
        public List<Consumed> GetById(int id)
        {
            return _dbContext.Consumeds.Where(s => s.ConsumedID == id).ToList<Consumed>();      

        }
        public IEnumerable<Consumed> GetByUserId(string id)
        {
            return _dbContext.Consumeds.Where(s => s.UserID == id).ToList<Consumed>();
        }

        public List<Consumed> GetByDate( DateTime D)
        {
            return _dbContext.Consumeds.Where(c => c.Date == D).ToList<Consumed>();
        }
        public List<Consumed> GetByDates(DateTime D, DateTime E)
        {
            var query = from Consumed in _dbContext.Consumeds
                        where (Consumed.Date >= D && Consumed.Date <= E)
                        select Consumed;
            return query.ToList<Consumed>();
        }
        public List<Consumed> GetByLocation(string location)
        {
            return _dbContext.Consumeds.Where(c => c.Location == location).ToList<Consumed>();
        }
        public List<Consumed> GetByReason(string reasons)
        {
            return _dbContext.Consumeds.Where(a => a.Reason == reasons).ToList<Consumed>();
        }
       

        public IEnumerable<Consumed> OrderByDate()
        {
            var query = (from Consumed in _dbContext.Consumeds
                         orderby Consumed.Date
                         select Consumed).ToList();
            return query;
        }

        public void Delete(int id)
        {
            var consumed = _dbContext.Consumeds.Where(x => x.ConsumedID == id);
            _dbContext.Consumeds.RemoveRange(consumed);
            _dbContext.SaveChanges();
        }
     

        public void Add(Consumed E)
            {
            _dbContext.Consumeds.Add(E);
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {

            _dbContext.Dispose();
        }
    }
}
