using LicentaTest.Data.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LicentaTest.Data.Repositories
{
    public class BaseRepository<TC, T> : IRepository<T>
        where TC : LicentaTestDbContext
        where T : TrackedModelBase
    {
        #region Properties

        public TC Context { get; set; }

        #endregion

        #region Constructors

        public BaseRepository(TC context) { this.Context = context; }

        #endregion

        #region Methods

        public virtual void Add(T entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            this.Context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity) { this.Context.Set<T>().Remove(entity); }

        public virtual void Edit(T entity)
        {
            entity.ModifiedAt = DateTime.UtcNow;
            this.Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = this.Context.Set<T>().Where(predicate).OrderByDescending(t => t.CreatedAt);

            return query;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = this.Context.Set<T>().Where(predicate).OrderByDescending(t => t.CreatedAt);

            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = this.Context.Set<T>().OrderByDescending(t => t.CreatedAt);

            return query;
        }


        public virtual async Task Save() { await this.Context.SaveChangesAsync(); }

        #endregion
    }
}
