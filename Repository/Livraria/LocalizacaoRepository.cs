using Web_Api_CRUD.Data;
using Web_Api_CRUD.Models.Livraria;
using Web_Api_CRUD.Repository.Interfaces.Livraria;

namespace Web_Api_CRUD.Repository.Livraria
{
    public class LocalizacaoRepository: RepositoryBase<Localizacao>, ILocalizacaoRepository
    {
        public LocalizacaoRepository(LivrariaDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}