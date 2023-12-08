using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using pim_sistema_folha.Models;
using pim_sistema_folha.Services;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace pim_sistema_folha.Controllers
{
    public class LoggedController : Controller
    {
        private readonly ConnectionService _connectionService;

        public LoggedController(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public IActionResult Index()
        {
            if (Request.Cookies["funcionarioLogado"] != null)
            {
                if (JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]).NomeUsuario == "kaique_santana")
                {
                    return RedirectToAction(nameof(Administrador));
                }
                else
                {
                    return RedirectToAction(nameof(Funcionario));
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Funcionario()
        {
            if (Request.Cookies["funcionarioLogado"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Funcionario funcionario = JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]);
            return View(funcionario);
        }

        public IActionResult GerarFolhaDePagamento()
        {
            if (Request.Cookies["funcionarioLogado"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Funcionario funcionario = JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]);

            try
            {
                SqlConnection connection = _connectionService.GetConnection();
                connection.Open();

                FolhaPagamento folhaPagamento = new FolhaPagamento();

                string sql = $"SELECT TOP 1 * FROM folhas_pagamento WHERE folhas_pagamento.id_funcionario_folha_pag = {funcionario.Id} ORDER BY folhas_pagamento.data_emissao_folha_pag DESC;";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();

                        folhaPagamento.Id = reader.GetInt32(0);
                        folhaPagamento.DataEmissao = reader.GetDateTime(1);
                        folhaPagamento.TotalLiquido = reader.GetDecimal(2);
                        folhaPagamento.TotalExtra = reader.GetDecimal(3);
                        folhaPagamento.TotalDesconto = reader.GetDecimal(4);
                        folhaPagamento.IdFuncionario = reader.GetInt32(5);
                    }
                }

                sql = $"SELECT * FROM extras_descontos WHERE id_folha_pag_extras_descontos = {folhaPagamento.Id};";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            ExtraDesconto extraDesconto = new ExtraDesconto
                            {
                                Id = r.GetInt32(0),
                                Descricao = r.GetString(1),
                                Valor = r.GetDecimal(2),
                                IdFolha = r.GetInt32(3)
                            };

                            folhaPagamento.ExtrasDescontos.Add(extraDesconto);
                        }
                    }
                }

                FuncionarioFolhaViewModel viewModel = new FuncionarioFolhaViewModel(funcionario, folhaPagamento);

                connection.Close();

                return View(viewModel);
            }
            catch (SqlException sqlEx)
            {
                return RedirectToAction("Error", "Home", new { message = sqlEx.Message });
            }
        }

        public IActionResult HistoricoDeFolhaDePagamento(int id)
        {
            if (Request.Cookies["funcionarioLogado"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Funcionario funcionario = JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]);

            try
            {
                SqlConnection connection = _connectionService.GetConnection();

                connection.Open();

                List<FolhaPagamento> folhasPagamento = new List<FolhaPagamento>();

                string sql = $"SELECT * FROM folhas_pagamento WHERE id_funcionario_folha_pag = {funcionario.Id};";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FolhaPagamento folha = new FolhaPagamento
                            {
                                Id = reader.GetInt32(0),
                                DataEmissao = reader.GetDateTime(1),
                                TotalLiquido = reader.GetDecimal(2),
                                TotalExtra = reader.GetDecimal(3),
                                TotalDesconto = reader.GetDecimal(4),
                                IdFuncionario = reader.GetInt32(5),
                            };

                            folhasPagamento.Add(folha);
                        }
                    }
                }

                FolhaPagamento selected = null;

                foreach (FolhaPagamento folha in folhasPagamento)
                {
                    if (folha.Id == id)
                    {
                        selected = folha;
                    }
                    sql = $"SELECT * FROM extras_descontos WHERE id_folha_pag_extras_descontos = {folha.Id};";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader r = command.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                ExtraDesconto extraDesconto = new ExtraDesconto
                                {
                                    Id = r.GetInt32(0),
                                    Descricao = r.GetString(1),
                                    Valor = r.GetDecimal(2),
                                    IdFolha = r.GetInt32(3)
                                };

                                folha.ExtrasDescontos.Add(extraDesconto);
                            }
                        }
                    }
                }

                if (selected == null)
                {
                    selected = folhasPagamento.First();
                }

                connection.Close();

                FuncionarioFolhasViewModel viewModel = new FuncionarioFolhasViewModel(funcionario, folhasPagamento, selected);

                return View(viewModel);
            }
            catch (SqlException sqlEx)
            {
                return RedirectToAction("Error", "Home", new { message = sqlEx.Message });
            }
        }

        public IActionResult Logout()
        {
            Response.Cookies.Delete("funcionarioLogado");

            return RedirectToAction("Index");
        }

        public IActionResult Administrador()
        {
            if (Request.Cookies["funcionarioLogado"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Funcionario funcionario = JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]);
            return View(funcionario);
        }

        public IActionResult InserirFuncionario()
        {
            if (Request.Cookies["funcionarioLogado"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Funcionario funcionarioLogado = JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]);
            AlterarViewModel viewModel = new AlterarViewModel(funcionarioLogado, new Funcionario());
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult InserirNovoFuncionario(Funcionario funcionario)
        {
            funcionario.NomeUsuario = funcionario.Nome.ToLower() + "_" + funcionario.Sobrenome.Split(' ')[0].ToLower();
            funcionario.SenhaUsuario = funcionario.Nome.ToLower() + "123";

            try
            {
                SqlConnection connection = _connectionService.GetConnection();
                connection.Open();

                string sql = $"INSERT INTO funcionarios (cpf_funcionario, nome_funcionario, sobrenome_funcionario, nome_usuario, senha_usuario, data_nasc_funcionario, cargo_funcionario, salario_bruto_funcionario, telefone_funcionario, email_funcionario, endereco_funcionario) VALUES ('{funcionario.Cpf}', '{funcionario.Nome}', '{funcionario.Sobrenome}', '{funcionario.NomeUsuario}', '{funcionario.SenhaUsuario}', '{funcionario.DataNasc.Year}-{funcionario.DataNasc.Month}-{funcionario.DataNasc.Day}', '{funcionario.Cargo}', {funcionario.SalarioBruto.ToString().Replace(",", ".")}, '{funcionario.Telefone}', '{funcionario.Email}', '{funcionario.Endereco}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter
                    {
                        InsertCommand = command
                    };
                    adapter.InsertCommand.ExecuteNonQuery();
                }

                connection.Close();

                return RedirectToAction("Administrador");
            }
            catch (SqlException sqlEx)
            {
                return RedirectToAction("Error", "Home", new { message = sqlEx.Message });
            }
        }

        public IActionResult AlterarFuncionario(int id)
        {
            if (Request.Cookies["funcionarioLogado"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (id > 0)
            {
                try
                {
                    SqlConnection connection = _connectionService.GetConnection();
                    connection.Open();

                    string sql = "SELECT * FROM funcionarios WHERE id_funcionario = " + id + ";";
                    using (SqlCommand command = new SqlCommand(sql,connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();

                            Funcionario funcionario = new Funcionario
                            {
                                Id = reader.GetInt32(0),
                                Cpf = reader.GetString(1),
                                Nome = reader.GetString(2),
                                Sobrenome = reader.GetString(3),
                                DataNasc = reader.GetDateTime(6),
                                Cargo = reader.GetString(7),
                                SalarioBruto = reader.GetDecimal(8),
                                Telefone = reader.GetString(9),
                                Email = reader.GetString(10),
                                Endereco = reader.GetString(11)
                            };

                            connection.Close();

                            Funcionario funcionarioLogado = JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]);
                            AlterarViewModel viewModel = new AlterarViewModel(funcionarioLogado, funcionario);
                            return View(viewModel);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    return RedirectToAction("Error", "Home", new { message = sqlEx.Message });
                }
            }
            else
            {
                try
                {
                    SqlConnection connection = _connectionService.GetConnection();
                    connection.Open();

                    string sql = "SELECT * FROM funcionarios WHERE id_funcionario = 1";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();

                            Funcionario funcionario = new Funcionario
                            {
                                Id = reader.GetInt32(0),
                                Cpf = reader.GetString(1),
                                Nome = reader.GetString(2),
                                Sobrenome = reader.GetString(3),
                                DataNasc = reader.GetDateTime(6),
                                Cargo = reader.GetString(7),
                                SalarioBruto = reader.GetDecimal(8),
                                Telefone = reader.GetString(9),
                                Email = reader.GetString(10),
                                Endereco = reader.GetString(11)
                            };

                            connection.Close();

                            Funcionario funcionarioLogado = JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]);
                            AlterarViewModel viewModel = new AlterarViewModel(funcionarioLogado, funcionario);
                            return View(viewModel);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    return RedirectToAction("Error", "Home", new { message = sqlEx.Message });
                }
            }
        }

        [HttpPost]
        public IActionResult AlterarDadosFuncionario(Funcionario funcionario)
        {
            try
            {
                SqlConnection connection = _connectionService.GetConnection();
                connection.Open();

                string sql = $"UPDATE funcionarios WHERE id_funcionario = {funcionario.Id} SET cpf_funcionario = '{funcionario.Cpf}', nome_funcionario = '{funcionario.Nome}', sobrenome_funcionario = '{funcionario.Sobrenome}', data_nasc_funcionario = '{funcionario.DataNasc.Year}-{funcionario.DataNasc.Month}-{funcionario.DataNasc.Day}', cargo_funcionario = '{funcionario.Cargo}', salario_bruto_funcionario = {funcionario.SalarioBruto.ToString().Replace(",", ".")}, telefone_funcionario = '{funcionario.Telefone}', email_funcionario = '{funcionario.Email}', endereco_funcionario = '{funcionario.Endereco}';";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter
                    {
                        UpdateCommand = command
                    };
                    adapter.UpdateCommand.ExecuteNonQuery();
                }

                connection.Close();

                return RedirectToAction("Administrador");
            }
            catch (SqlException sqlEx)
            {
                return RedirectToAction("Error", "Home", new { message = sqlEx.Message });
            }
        }

        public IActionResult HistoricoFolhasAdministrador(int id)
        {
            if (Request.Cookies["funcionarioLogado"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                SqlConnection connection = _connectionService.GetConnection();
                connection.Open();

                List<FolhaPagamento> folhasPagamento = new List<FolhaPagamento>();

                string sql = "SELECT * FROM folhas_pagamento";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FolhaPagamento folha = new FolhaPagamento
                            {
                                Id = reader.GetInt32(0),
                                DataEmissao = reader.GetDateTime(1),
                                TotalLiquido = reader.GetDecimal(2),
                                TotalExtra = reader.GetDecimal(3),
                                TotalDesconto = reader.GetDecimal(4),
                                IdFuncionario = reader.GetInt32(5),
                            };

                            folhasPagamento.Add(folha);
                        }
                    }
                }

                FolhaPagamento selected = null;

                foreach (FolhaPagamento folha in folhasPagamento)
                {
                    if (folha.Id == id)
                    {
                        selected = folha;
                    }
                    sql = $"SELECT * FROM extras_descontos WHERE id_folha_pag_extras_descontos = {folha.Id};";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader r = command.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                ExtraDesconto extraDesconto = new ExtraDesconto
                                {
                                    Id = r.GetInt32(0),
                                    Descricao = r.GetString(1),
                                    Valor = r.GetDecimal(2),
                                    IdFolha = r.GetInt32(3)
                                };

                                folha.ExtrasDescontos.Add(extraDesconto);
                            }
                        }
                    }

                    sql = $"SELECT * FROM funcionarios WHERE id_funcionario = {folha.IdFuncionario};";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader r = command.ExecuteReader())
                        {
                            r.Read();

                            Funcionario f = new Funcionario
                            {
                                Id = r.GetInt32(0),
                                Cpf = r.GetString(1),
                                Nome = r.GetString(2),
                                Sobrenome = r.GetString(3),
                                DataNasc = r.GetDateTime(6),
                                Cargo = r.GetString(7),
                                SalarioBruto = r.GetDecimal(8),
                                Telefone = r.GetString(9),
                                Email = r.GetString(10),
                                Endereco = r.GetString(11)
                            };

                            folha.Funcionario = f;
                        }
                    }
                }

                if (selected == null)
                {
                    selected = folhasPagamento.First();
                }

                connection.Close();
                Funcionario funcionario = JsonConvert.DeserializeObject<Funcionario>(Request.Cookies["funcionarioLogado"]);
                FuncionarioFolhasViewModel viewModel = new FuncionarioFolhasViewModel(funcionario, folhasPagamento, selected);

                return View(viewModel);
            }
            catch (SqlException sqlEx)
            {
                return RedirectToAction("Error", "Home", new { message = sqlEx.Message });
            }
        }
    }
}
