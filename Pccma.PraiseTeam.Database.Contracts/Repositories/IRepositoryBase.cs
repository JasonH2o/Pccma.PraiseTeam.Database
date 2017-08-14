using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pccma.PraiseTeam.Database.Contracts.Repositories
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> Find();
        T Add(T entity);
        T Update(T entity);
        bool Delete(int id);
    }
}
