using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class DetalhesVendaProduto
    {
        public int DetalhesVendaProdutoId { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Detalhes Venda Id deve conter somente números")]
        public int DetalhesVendaId { get; set; }
        public DetalhesVenda? DetalhesVenda { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Produto Id deve conter somente números")]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do Produto é obrigatório.")]
        [Display(Name = "Nome do Produto")]
        public Produto? Produto { get; set; }
    }
}
