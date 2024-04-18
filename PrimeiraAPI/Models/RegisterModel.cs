using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class RegisterModel
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório.")]
        [Display(Name = "Email")]
        public string? Email { get; set; }
        public string Password { get; set; }
    }
}
