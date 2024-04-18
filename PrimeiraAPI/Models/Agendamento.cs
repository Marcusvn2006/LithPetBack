using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Agendamento
    {
        public int AgendamentoId { get; set; }
        [Required(ErrorMessage = "A Data de Agendamento é obrigatória.")]
        [Display(Name = "Data de Agendamento")]
        [DataType(DataType.Date)]
        public DateTime DataHoraAgendamento { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Cliente Id deve conter somente números")]
        public Guid ClientId { get; set; }

        [Required(ErrorMessage = "O nome do Cliente é obrigatório.")]
        [Display(Name = "Nome do Cliente")]
        public Cliente? Cliente { get; set; }

    }
}

