using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Web_Api_CRUD.Data;
using Web_Api_CRUD.Models;
using Web_Api_CRUD.Repository.Interfaces;

namespace Web_Api_CRUD.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        private readonly DbSet<TEntity> _dbSet;    

        protected readonly LivrariaDbContext DbContext;

        protected RepositoryBase(LivrariaDbContext dbContext)
        {
            DbContext = dbContext;
            _dbSet = DbContext.Set<TEntity>();
        }

        public void Dispose()
        {
            DbContext?.Dispose();
        }


        #region [ Métodos privados ] 

        private async Task<int> SaveChanges()
        {            
            return await DbContext.SaveChangesAsync();
        }

        #endregion

        #region [ Métodos protegidos ]

        #endregion

        #region [ Métodos públicos ]

        public virtual async Task<List<TEntity>> ObterTodos()
        {            
            return _dbSet.AsNoTracking()
                .ToList();
        }

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }  

        public virtual async Task Adicionar(TEntity entity)
        {
            _dbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task AdicionarLista(List<TEntity> entities)
        {
            _dbSet.AddRange(entities);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            _dbSet.Update(entity);
            await SaveChanges();
        }


        public virtual async Task Remover(TEntity entity)
        {
            _dbSet.Remove(entity);
            await SaveChanges();
        }

        #endregion
    }
}
