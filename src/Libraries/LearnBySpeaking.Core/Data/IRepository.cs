using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnBySpeaking.Core.Domain;

namespace LearnBySpeaking.Core.Data
{
    public interface IRepository<in TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        IQueryable<TEntity> Table { get; }

        Task DeleteAsync(TEntity entity);

        ValueTask<TEntity> GetAsync(TKey id);

        Task InsertAsync(TEntity entity);

        Task InsertRangeAsync(List<TEntity> entities);
    }
}