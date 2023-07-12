using Web_Api_CRUD.Models.Usuarios;

namespace Web_Api_CRUD.Repository.Interfaces.Usuarios
{
    public interface IUsuarioRepository
    {
        Task<Usuario> ObterPorEmail(string email);
    }
}