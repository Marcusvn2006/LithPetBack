using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class DetalhesVenda
    {
        public int DetalhesVendaId { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Quantidade deve conter somente números")]
        public int Quantidade { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O campo Preço Unitário deve conter somente números")]
        public int PrecoUnitario { get; set; }
    }
}
