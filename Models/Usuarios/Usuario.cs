using Web_Api_CRUD.Models.Enum;

namespace Web_Api_CRUD.Models.Usuarios
{
    public class Usuario: Entity
    {
        public string Nome { get; set; }
        public string Login {get; set;}
        public string Email { get; set; }
        public TipoPerfil Perfil { get; set; }
        public string Senha { get; set; }
    }
}