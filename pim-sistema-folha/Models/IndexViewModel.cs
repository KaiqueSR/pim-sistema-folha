using pim_sistema_folha.Models.Enums;

namespace pim_sistema_folha.Models
{
    public class IndexViewModel
    {
        public Funcionario Funcionario { get; set; }
        public LoginErrorStatus LoginErrorStatus { get; set; }

        public IndexViewModel(Funcionario funcionario, LoginErrorStatus loginErrorStatus)
        {
            Funcionario = funcionario;
            LoginErrorStatus = loginErrorStatus;
        }
    }
}
