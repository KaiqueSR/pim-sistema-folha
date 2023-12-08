using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using pim_sistema_folha.Models;
using pim_sistema_folha.Models.Enums;
using pim_sistema_folha.Services;
using System;
using System.Data.SqlClient;

namespace pim_sistema_folha.Controllers
{
    public class HomeController : Controller
    {
        private readonly CookieOptions cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddHours(2)
        };

        private readonly ConnectionService _connectionService;

        public HomeController(ConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public IActionResult Index()
        {
            if (Request.Cookies["funcionarioLogado"] != null)
            {
                return RedirectToAction("Index", "Logged");
            }

            IndexViewModel viewModel;
            if (TempData["IndexViewModel"] == null)
            {
                viewModel = new IndexViewModel(new Funcionario(), LoginErrorStatus.SemErros);
            }
            else
            {
                viewModel = JsonConvert.DeserializeObject<IndexViewModel>(TempData["IndexViewModel"].ToString());
            }

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Funcionario funcionario)
        {
            // VALIDAÇÃO DO USUÁRIO
            try
            {
                SqlConnection connection = _connectionService.GetConnection();
                connection.Open();

                string sql = $"SELECT * FROM funcionarios WHERE nome_usuario = '{funcionario.NomeUsuario}'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.GetString(5) == funcionario.SenhaUsuario)
                            {
                                funcionario.Id = reader.GetInt32(0);
                                funcionario.Cpf = reader.GetString(1);
                                funcionario.Nome = reader.GetString(2);
                                funcionario.Sobrenome = reader.GetString(3);
                                funcionario.DataNasc = reader.GetDateTime(6);
                                funcionario.Cargo = reader.GetString(7);
                                funcionario.SalarioBruto = reader.GetDecimal(8);
                                funcionario.Telefone = reader.GetString(9);
                                funcionario.Email = reader.GetString(10);
                                funcionario.Endereco = reader.GetString(11);

                                Response.Cookies.Append("funcionarioLogado", JsonConvert.SerializeObject(funcionario), cookieOptions);

                                connection.Close();

                                return RedirectToAction("Index", "Logged");
                            }
                            else
                            {
                                connection.Close();
                                TempData["IndexViewModel"] = JsonConvert.SerializeObject(new IndexViewModel(funcionario, LoginErrorStatus.SenhaIncorreta));
                                return RedirectToAction(nameof(Index));
                            }
                        }
                        else
                        {
                            connection.Close();
                            TempData["IndexViewModel"] = JsonConvert.SerializeObject(new IndexViewModel(funcionario, LoginErrorStatus.UsuarioNaoEncontrado));
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                return RedirectToAction(nameof(Error), new { message = sqlEx.Message });
            }
        }

        public IActionResult Error(string message)
        {
            return View(message);
        }
    }
}
