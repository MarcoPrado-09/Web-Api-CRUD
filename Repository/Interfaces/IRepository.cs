using System.Linq.Expressions;
using Web_Api_CRUD.Models;

namespace Web_Api_CRUD.Repository.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {

        Task<List<TEntity>> ObterTodos();
        Task<TEntity> ObterPorId(Guid id);
        Task Adicionar(TEntity entity);
        Task AdicionarLista(List<TEntity> entities);
        Task Atualizar(TEntity entity);
        Task Remover(TEntity entity);
    }
}

