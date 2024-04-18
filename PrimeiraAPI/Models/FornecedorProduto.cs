using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class FornecedorProduto
    {
        public int FornecedorProdutoId { get; set; }

        [Required(ErrorMessage = "O Nome do Fornecedor é obrigatório.")]
        [Display(Name = "Nome do Fornecedor")]
        public string? NomeFornecedor { get; set; }

        [Required(ErrorMessage = "O Endereço do Fornecedor é obrigatório.")]
        [Display(Name = "Endereço do Fornecedor")]
        public string? EnderecoForn { get; set; }

        [Required(ErrorMessage = "O E-mail do Fornecedor é obrigatório.")]
        [Display(Name = "E-mail do Fornecedor")]
        public string? EmailForn { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O Campo Telefone do Fornecedor deve conter somente números")]
        public string? TelefoneForn { get; set; }
    }
}
