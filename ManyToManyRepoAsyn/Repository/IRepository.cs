using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ManyToManyCore.Models
{
    public interface IRepository<T> where T : class
    {
        IList<string> DistinctList(Expression<Func<T, string>> what);
        Task<IEnumerable<T>> Select(
                Expression<Func<T, bool>> where,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
                string includes
        );
        Task<T> Find(long? id);
        Task Insert(T entity);
        Task<bool> Delete(long? id);
        Task SaveVersionControl(T entityToUpdate, byte[] rowVersion);
        Task Update(T entityToUpdate);
        Task ExplicitLoading(T entity, string include);
        Task<T> FindExplicitLoading(long? id, string include);
        Task<bool> DeleteCascade(string junctionTable, string where, long? idToDelete);
     }
}
