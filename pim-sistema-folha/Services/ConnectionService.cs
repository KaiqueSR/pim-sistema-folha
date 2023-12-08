using System;
using System.Data.SqlClient;

namespace pim_sistema_folha.Services
{
    public class ConnectionService
    {
        public SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=sistema_folha;Integrated Security=True;Encrypt=False");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
