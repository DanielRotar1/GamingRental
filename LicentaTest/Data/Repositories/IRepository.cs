using LicentaTest.Data.Entities.Common;
using System.Linq.Expressions;

namespace LicentaTest.Data.Repositories
{
    public interface IRepository<T> where T : ModelBase
    {
        #region Methods

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        IQueryable<T> GetAll();

        Task Save();

        #endregion Methods
    }
}
