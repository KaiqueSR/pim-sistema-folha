using System.Collections.Generic;

namespace pim_sistema_folha.Models
{
    public class FuncionarioFolhasViewModel
    {
        public Funcionario Funcionario { get; set; }
        public List<FolhaPagamento> FolhasPagamento { get; set; }
        public FolhaPagamento FolhaPagamentoSelected { get; set; }

        public FuncionarioFolhasViewModel(Funcionario funcionario, List<FolhaPagamento> folhasPagamento, FolhaPagamento folhaPagamentoSelected)
        {
            Funcionario = funcionario;
            FolhasPagamento = folhasPagamento;
            FolhaPagamentoSelected = folhaPagamentoSelected;
        }
    }
}
