using LearnBySpeaking.Core;
using LearnBySpeaking.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBySpeaking.Data
{
    public class LearnBySpeakingRepository<TKey, TEntity> : IRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        private readonly LearnBySpeakingContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public LearnBySpeakingRepository(LearnBySpeakingContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> Table => _dbSet;

        public Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);

            return _context.SaveChangesAsync();
        }

        public Task EditAsync(TEntity entity)
        {
            _dbSet.Update(entity);

            return _context.SaveChangesAsync();
        }

        public TEntity FindBy(Func<TEntity, bool> predicate)
        {
            return _dbSet.Where(predicate).FirstOrDefault();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return _dbSet.ToListAsync();
        }

        public ValueTask<TEntity> GetAsync(TKey id)
        {
            return _dbSet.FindAsync(id);
        }

        public Task InsertAsync(TEntity entity)
        {
            _dbSet.Add(entity);

            return _context.SaveChangesAsync();
        }

        public Task InsertRangeAsync(List<TEntity> entities)
        {
            _dbSet.AddRange(entities);

            return _context.SaveChangesAsync();
        }
    }
}