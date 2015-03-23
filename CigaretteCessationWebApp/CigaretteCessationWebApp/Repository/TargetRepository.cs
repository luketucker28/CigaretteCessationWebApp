

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CigaretteCessationWebApp.Models;
using System.Data.Entity;


namespace CigaretteCessationWebApp.Repository
{

    public class TargetRepository
    {
        private CigaretteCessationContext _dbContext;

        public TargetRepository()
        {
            _dbContext = new CigaretteCessationContext();
            _dbContext.Targets.Load();

        }
        public CigaretteCessationContext Context()
        {
            return _dbContext;
        }

        public DbSet<Target> GetDbSet()
        {
            return _dbContext.Targets;
        }

        public int GetCount()
        {
            return _dbContext.Targets.Count<Target>();

        }

        public void Add(Target E)
        {
            _dbContext.Targets.Add(E);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var b = this.All();
            _dbContext.Targets.RemoveRange(b);
        }

        public IEnumerable<Target> All()
        {
            var qu = from Target in _dbContext.Targets select Target;
            return qu.ToList<Target>();
        }

        public Target GetById(int id)
        {
            var query = from Target in _dbContext.Targets
                        where Target.TargetID == id
                        select Target;
            return query.First<Target>();

        }

        //public Target GetByDate(DateTime D)
        //{
        //    var query = from Target in _dbContext.Targets
        //                where Target.Date == D
        //                select Target;
        //    return query.ToList<Target>();
        //}

        public List<Target> GetByName(string users)
        {
            var a = from Target in _dbContext.Targets
                    where Target.UserName == users
                    select Target;

            return a.ToList<Target>();


        }

        public IEnumerable<Target> OrderByName()
        {
            var query = (from Target in _dbContext.Targets
                         orderby Target.UserName
                         select Target).ToList();
            return query;
        }
        public IEnumerable<Target> OrderById()
        {
            var query = (from Target in _dbContext.Targets
                         orderby Target.TargetID
                         select Target).ToList();
            _dbContext.SaveChanges();
            return query;
        }
        public Target FirstEntry()
        {

            var query = from Target in _dbContext.Targets select Target;
            return query.ToList<Target>().ElementAt<Target>(0);

        }
        public Target FindEntry(int i)
        {

            var query = from Target in _dbContext.Targets select Target;
            return query.ToList<Target>().ElementAt<Target>(i);

        }
        public void Delete(Target E)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Target> PastTargets()
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {

            _dbContext.Dispose();
        }
    }
}
