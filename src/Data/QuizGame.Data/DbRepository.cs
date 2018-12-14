using System;
using System.Linq;
using System.Threading.Tasks;
using GuizGame.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace QuizGame.Data
{
    public class DbRepository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : class
    {
        private readonly QuizGameContext context;
        private DbSet<TEntity> dbSet;

        public DbRepository(QuizGameContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public Task AddAsync(TEntity entity)
        {
            return this.dbSet.AddAsync(entity);
        }

        public IQueryable<TEntity> All()
        {
            return this.dbSet;
        }
        public Task<TEntity> FindByIdAsync(object id)
        {
            return this.dbSet.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            this.dbSet.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
