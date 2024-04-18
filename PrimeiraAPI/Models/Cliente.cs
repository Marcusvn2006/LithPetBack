using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "O e-mail do cliente é obrigatório.")]
        [Display(Name = "Email do Cliente")]
        public string EmailCliente { get; set; }

        [Required(ErrorMessage = "O endereço do cliente é obrigatório.")]
        [Display(Name = "Endereço do Cliente")]
        public string EnderecoCliente { get; set; }

    }
}
