using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Web_Api_CRUD.Models.Livraria;
using Web_Api_CRUD.Models.Usuarios;

namespace Web_Api_CRUD.Data
{
    public class LivrariaDbContext: IdentityDbContext
    {
        public LivrariaDbContext(DbContextOptions<LivrariaDbContext> options)
            : base(options){ }
        
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}