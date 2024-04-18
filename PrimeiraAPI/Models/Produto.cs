using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O campo Descrição do Produto é obrigatório.")]
        [Display(Name = "Descrição do Produto")]
        public string? ProdutoDescricao { get; set; }

        [Required(ErrorMessage = "O Nome do Produto é obrigatório.")]
        [Display(Name = "Nome do Produto")]
        public string? ProdutoNome { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O campo Produto Preço deve conter somente números")]
        public decimal ProdutoPreco { get; set; }

    }
}
