using Web_Api_CRUD.Data;
using Web_Api_CRUD.Models.Livraria;
using Web_Api_CRUD.Repository.Interfaces.Livraria;

namespace Web_Api_CRUD.Repository.Livraria
{
    public class EstoqueRepository: RepositoryBase<Estoque>, IEstoqueRepository
    {
        public EstoqueRepository(LivrariaDbContext dbContext) : base(dbContext)
        {}
    }
}