using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class DetalhesVendaVendas
    {
        public int DetalhesVendaVendasId { get; set; }
        public int DetalhesVendaId { get; set; }
        public DetalhesVenda? DetalhesVenda { get; set; }
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }
    }
}
