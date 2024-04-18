using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Teste
    {
        public Guid TesteId { get; set; }

        [Required(ErrorMessage = "O Nome do Produto é obrigatório.")]
        [Display(Name = "Nome do Produto")]
        public string TesteNome { get; set; }
    }
}
