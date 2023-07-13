namespace Web_Api_CRUD.Models.Livraria
{
    public class Estoque: Entity
    {
        public Guid LivroId { get; set; }
        public Livro Livro { get; set; }
        public int EstoqueLocalizacao { get; set; }
        public int ValorEstoque { get; set; }
    }
}