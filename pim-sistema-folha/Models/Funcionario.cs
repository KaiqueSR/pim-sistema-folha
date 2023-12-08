using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace pim_sistema_folha.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Display(Name = "CPF")]
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        public string NomeUsuario { get; set; }

        [PasswordPropertyText]
        public string SenhaUsuario { get; set; }

        [Display(Name = "Data de nascimento")]
        [Required]
        public DateTime DataNasc { get; set; }
        [Required]
        public string Cargo { get; set; }

        [Display(Name = "Salário Bruto")]
        [Required]
        public decimal SalarioBruto { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Endereco { get; set; }
    }
}
