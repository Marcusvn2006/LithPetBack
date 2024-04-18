using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class DetalhesVendaServico
    {
        public int DetalhesVendaServicoId { get; set; }

        [Required(ErrorMessage = "O campo Detalhes Venda Id é obrigatório.")]
        [Display(Name = "Detalhes Venda Id")]
        public int? DetalhesVendaId { get; set; }

        [Required(ErrorMessage = "O campo Detalhes Venda é obrigatório.")]
        [Display(Name = "Detalhes Venda")]
        public DetalhesVenda? DetalhesVenda { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Serviços Id deve conter somente números")]
        public int ServicosId { get; set; }

        [Required(ErrorMessage = "O Tipo de Serviço é obrigatório.")]
        [Display(Name = "Tipo de Serviço")]
        public Servicos? Servicos { get; set; }
    }
}
