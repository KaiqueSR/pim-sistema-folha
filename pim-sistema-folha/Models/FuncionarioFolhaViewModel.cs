namespace pim_sistema_folha.Models
{
    public class FuncionarioFolhaViewModel
    {
        public Funcionario Funcionario { get; set; }
        public FolhaPagamento FolhaPagamento { get; set; }

        public FuncionarioFolhaViewModel(Funcionario funcionario, FolhaPagamento folhaPagamento)
        {
            Funcionario = funcionario;
            FolhaPagamento = folhaPagamento;
        }
    }
}
