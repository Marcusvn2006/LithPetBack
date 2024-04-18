using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class AgendamentoServicos
    {
        public int AgendamentoServicosId { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Agendamento Id deve conter somente números")]
        public int AgendamentoId { get; set; }
        public Agendamento? Agendamento { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Serviços Id deve conter somente números")]
        public int ServicosId { get; set; }

        [Required(ErrorMessage = "O Tipo de Serviço é obrigatório.")]
        [Display(Name = "Tipo de Serviço")]
        public Servicos? Servicos { get; set; }
    }
}
