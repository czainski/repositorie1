using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManyToManyCore.Models
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
    {
        public DbContext            _context { set; get; }
        public DbSet<TEntity>   _dbSet;
        //   
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet   = context.Set<TEntity>();
        }
        //
        public virtual async Task<IEnumerable<TEntity>> Select(
                Expression<Func<TEntity, bool>> where = null,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                string includes = null
        )
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
                  query = query.Where(where);
            //
            if (includes != null) 
                //if (includes.Length > 0)
                {
                    String[] tab = includes.Split(',');
                    foreach (String s in tab)
                        query = query.Include(s.Trim());
                }
            //
            if (orderBy != null)
            {
                var var = await orderBy(query).ToListAsync();
                return var.AsQueryable().AsNoTracking();              
            }
            else
            {
                var var = await query.ToListAsync();
                return var.AsQueryable().AsNoTracking();  
            }
        }
        //
        public virtual async Task<TEntity> Find(long? id)
        {
            if (id != null)
            {
                TEntity entity =  await _dbSet.FindAsync(id);
                if (entity != null)
                        return entity;
            }
            Debug.Write("\n\nERROR :  Find: " + id);
            return null;
        }
        //
        public virtual async Task<TEntity> FindExplicitLoading(long? id, string include)
        {
            if (id != null)
            {
                TEntity entity = await _dbSet.FindAsync(id);
                if (entity != null) {
                    await _context.Entry(entity).Collection(include).LoadAsync();
                    return entity;
                }
            }
            Debug.Write("\n\nERROR :  FindExplicitLoading: "+id);
            return null;
        }
        //
        public virtual async Task  Insert(TEntity entity)
        {
          await _dbSet.AddAsync(entity);
          await _context.SaveChangesAsync();
        }
        //
        void SqlDelete(TEntity entityToRemove,string junctionTableName, string where, long? id)
        {
            if (id != null)
            {
                string sql = "DELETE FROM " + junctionTableName + " WHERE " + where + " = {0}";
                _context.Database.ExecuteSqlRaw(sql, id);
                _dbSet.Remove(entityToRemove);
                return;
            }
            Debug.Write("\n\nERROR :  SqlDelete: " + id);
            return;
        }
        //
        public virtual async Task<bool> DeleteCascade(string junctionTableName, string where, long? idToDelete)
        {
            if (idToDelete != null)
            {
                TEntity entityToRemove = await _dbSet.FindAsync(idToDelete);
                if (entityToRemove == null) return false;
                await Task.Run(() => SqlDelete(entityToRemove, junctionTableName, where, idToDelete));
                await _context.SaveChangesAsync();
            }
            Debug.Write("\n\nERROR :  DeleteCascade: " + idToDelete);
            return true;
        }
        //
        public virtual async Task<bool> Delete(long? id)
        {
            if (id != null)
            {
                TEntity entityToRemove = await _dbSet.FindAsync(id);
                if (entityToRemove == null) return false;
                _dbSet.Remove(entityToRemove);
                
                await _context.SaveChangesAsync();
                return true;
            }
            Debug.Write("\n\nERROR :  Delete: " + id);
            return false;
        }
        //
        public virtual async Task Update(TEntity entity)
        {
            _context.Entry(entity);
            await _context.SaveChangesAsync();
        }
        //
        public virtual async Task SaveVersionControl(TEntity entity, byte[] rowVersion)
        {
            _context.Entry(entity).Property("RowVersion").OriginalValue = rowVersion;
            await _context.SaveChangesAsync();
        }
        //
        public virtual async Task ExplicitLoading(TEntity entity, string include) =>
             await _context.Entry(entity).Collection(include).LoadAsync();
        //
        public void Dispose(bool disposing) => _context.Dispose();


        public IList<string> DistinctList ( Expression<Func<TEntity, string>> what )
        {
            return _dbSet.Select(what).Distinct().ToList(); ;
        }
        //
        

    }
}

