using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Animais
    {
        public int AnimaisId { get; set; }

        [Required(ErrorMessage = "O nome do Animal é obrigatório.")]
        [Display(Name = "Nome do Animal")]
        public string AnimaisNome { get; set; }

        [Required(ErrorMessage = "O campo Animais Espécie é obrigatório.")]
        [Display(Name = "Nome da Espécie")]
        public string AnimaisEspecie { get; set; }

        [RegularExpression(@"^\d+(2)", ErrorMessage = "O campo Animais Idade deve conter somente números")]
        public int AnimaisIdade { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Cliente Id deve conter somente números")]
        public Guid ClientId { get; set; }

        [Required(ErrorMessage = "O nome do Cliente é obrigatório.")]
        [Display(Name = "Nome do Cliente")]
        public Cliente? Cliente { get; set; }

    }
}
