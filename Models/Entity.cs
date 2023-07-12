namespace Web_Api_CRUD.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCriacao { get; set; }
        public Guid UsuarioCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public Guid? UsuarioAtualizacao { get; set; }

    protected Entity()
    {
        Ativo = true;
    }
    //public abstract bool Validar();

    }
}