using Microsoft.EntityFrameworkCore;
using Web_Api_CRUD.Data;
using Web_Api_CRUD.Models.Usuarios;
using Web_Api_CRUD.Repository.Interfaces.Usuarios;

namespace Web_Api_CRUD.Repository.Usuarios
{
    public class UsuarioRepository: RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(LivrariaDbContext dbContext) : base(dbContext)
        { }

        public async Task<Usuario> ObterPorEmail(string email)
        {              
            var usuario = await DbContext.Usuarios
                .SingleOrDefaultAsync(u => u.Email.ToUpper().Equals(email));

            return usuario;
        }
    }
}