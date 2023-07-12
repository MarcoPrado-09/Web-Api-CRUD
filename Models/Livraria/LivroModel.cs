namespace Web_Api_CRUD.Models.Livraria
{
    public class Livro: Entity
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }
        public int NumeroEdicao { get; set; }
        public string Idioma { get; set; }
        public int LocalizacaoID { get; set; }
        public Localizacao Localizacao { get; set; }
        public int AnoPublicacao { get; set; }
    }
}