using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pccma.PraiseTeam.Database.Contracts.Repositories;
using System.Data.Entity;
using Pccma.PraiseTeam.Database.DataAccess.Database;

namespace Pccma.PraiseTeam.Database.DataAccess.Repositories
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T: class
    {
        private PccmaPraiseTeamDatabase _pccmaPraiseTeamDb;
        protected DbSet<T> DbSet { get; private set; }

        public RepositoryBase(PccmaPraiseTeamDatabase pccmaPraiseTeamDb, DbSet<T> dbSet)
        {
            _pccmaPraiseTeamDb = pccmaPraiseTeamDb;
            DbSet = dbSet;
        }

        public IQueryable<T> Find()
        {
            return this.DbSet.AsQueryable<T>();
        }

        public T Add(T entity)
        {
            var dbSet = _pccmaPraiseTeamDb.Set<T>();
            dbSet.Add(entity);
            _pccmaPraiseTeamDb.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            //var dbSet = _pccmaPraiseTeamDb.Set<T>();
            //dbSet.Attach(entity);
            _pccmaPraiseTeamDb.Entry(entity).State = EntityState.Modified;
            _pccmaPraiseTeamDb.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            T entity = this.DbSet.Find((object)id);
            if ((object)entity == null)
            {
                return false;
            }

            this.DbSet.Remove(entity);
            _pccmaPraiseTeamDb.SaveChanges();
            return true;
        }
    }
}
