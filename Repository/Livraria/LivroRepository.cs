using Web_Api_CRUD.Data;
using Web_Api_CRUD.Models.Livraria;
using Web_Api_CRUD.Repository.Interfaces.Livraria;

namespace Web_Api_CRUD.Repository.Livraria
{
    public class LivroRepository: RepositoryBase<Livro>, ILivroRepository
    {
        public LivroRepository(LivrariaDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}