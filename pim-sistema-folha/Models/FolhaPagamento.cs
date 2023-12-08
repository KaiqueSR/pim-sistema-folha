using System;
using System.Collections.Generic;

namespace pim_sistema_folha.Models
{
    public class FolhaPagamento
    {
        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal TotalLiquido { get; set; }
        public decimal TotalExtra { get; set; }
        public decimal TotalDesconto { get; set; }
        public int IdFuncionario { get; set; }

        public List<ExtraDesconto> ExtrasDescontos { get; set; } = new List<ExtraDesconto>();
        public Funcionario Funcionario { get; set; }
    }
}
