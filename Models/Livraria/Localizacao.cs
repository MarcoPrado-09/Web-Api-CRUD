using Web_Api_CRUD.Models.Enum;

namespace Web_Api_CRUD.Models.Livraria
{
    public class Localizacao: Entity
    {
        public string Descricao { get; set; }
        public TipoLocalizacao Tipo { get; set; }
        public int CapacidadeTotal { get; set; }
        public int CapacidadeUsada { get; set; }
    }
}