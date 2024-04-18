using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class AgendamentoFuncionario
    {
        public int AgendamentoFuncionarioId { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Agendamento Id deve conter somente números")]

        public int AgendamentoId { get; set; }
        public Agendamento? Agendamento { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "O campo Funcionário Id deve conter somente números")]

        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "O nome do Funcionário é obrigatório.")]
        [Display(Name = "Nome do Funcionário")]
        public Funcionario? Funcionario { get; set; }

    }
}
