namespace pim_sistema_folha.Models
{
    public class AlterarViewModel
    {
        public Funcionario FuncionarioLogado { get; set; }
        public Funcionario FuncionarioAlterar { get; set; }

        public AlterarViewModel(Funcionario funcionarioLogado, Funcionario funcionarioAlterar)
        {
            FuncionarioLogado = funcionarioLogado;
            FuncionarioAlterar = funcionarioAlterar;
        }
    }
}
