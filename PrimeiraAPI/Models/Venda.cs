using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Venda
    {
        public int VendaId { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Data Venda deve conter somente números")]
        public DateTime DataVenda { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O campo Valor Total deve conter somente números")]
        public int ValorTotal { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Cliente Id deve conter somente números")]
        public Guid ClientId { get; set; }

        [Required(ErrorMessage = "O Nome do cliente é obrigatório.")]
        [Display(Name = "Nome do Cliente")]
        public Cliente? Cliente { get; set; }
    }
}
