using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "O Nome do Funcionário é obrigatório.")]
        [Display(Name = "Nome do Funcionário")]
        public string FuncionarioNome { get; set; }

        [Required(ErrorMessage = "O Cargo do Funcionário é obrigatório.")]
        [Display(Name = "Cargo do Funcionário")]
        public string FuncionarioCargo { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O campo Salário do Funcionário deve conter somente números")]
        public decimal FuncionarioSalario { get; set; }
    }
}
