using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class VendaFornecedor
    {
        public int VendaFornecedorId { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Venda Id deve conter somente números")]
        public int VendaId { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Venda deve conter somente números")]
        public Venda? Venda { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Fornecedor Id deve conter somente números")]
        public int FornecedorId { get; set; }
        public FornecedorProduto? FornecedorProduto { get; set; }
    }
}
