using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class VendaProduto
    {
        public int VendaProdutoId { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Venda Id deve conter somente números")]
        public int VendaId { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Venda deve conter somente números")]
        public Venda? Venda { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Produto Id deve conter somente números")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O Nome do Produto é obrigatório.")]
        [Display(Name = "Nome do Produto")]
        public Produto? Produto { get; set; }
    }
}
