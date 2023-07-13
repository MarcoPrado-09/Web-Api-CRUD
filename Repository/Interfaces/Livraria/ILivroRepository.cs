using Web_Api_CRUD.Models.Livraria;

namespace Web_Api_CRUD.Repository.Interfaces.Livraria
{
    public interface ILivroRepository: IRepository<Livro>
    {
        Task<List<Livro>> ObterPorLocalizacao (Guid localizacaoId);
    }
}