

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

        public List<Consumed> GetByUserName(string id)
        {
            return _dbContext.Consumeds.Where(s => s.UserID == id).ToList();
        }

        public List<Consumed> GetByDate(string id, DateTime D)
        {
            return _dbContext.Consumeds.Where(c=> c.Date == D &&  c.UserID == id).ToList<Consumed>();
        }

        //public List<Consumed> GetByDate(string usesname, DateTime D)
        //{
        //    return _dbContext.Consumeds.Where(c => c.Date == D && c.UserName == usesname).ToList<Consumed>();
        //}

        //public List<Consumed> GetByName(string users)
        //{
        //    var a = from Consumed in _dbContext.Consumeds
        //            where Consumed.UserN == users
        //            select Consumed;

        //    return a.ToList<Consumed>();


        //}

        public IEnumerable<Consumed> OrderByDate()
        {
            var query = (from Consumed in _dbContext.Consumeds
                         orderby Consumed.Date
                         select Consumed).ToList();
            return query;
        }
        public IEnumerable<Consumed> OrderById()
        {
            var query = (from Consumed in _dbContext.Consumeds
                         orderby Consumed.ConsumedID
                         select Consumed).ToList();
            _dbContext.SaveChanges();
            return query;
        }
        public Consumed FirstEntry()
        {

            var query = from Consumed in _dbContext.Consumeds select Consumed;
            return query.ToList<Consumed>().ElementAt<Consumed>(0);

        }
        public Consumed FindEntry(int i)
        {

            var query = from Consumed in _dbContext.Consumeds select Consumed;
            return query.ToList<Consumed>().ElementAt<Consumed>(i);

        }
        public void Delete(Consumed E)
        {
            throw new NotImplementedException();
        }
        

        public IEnumerable<Consumed> PastConsumeds()
        {
            throw new NotImplementedException();
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
