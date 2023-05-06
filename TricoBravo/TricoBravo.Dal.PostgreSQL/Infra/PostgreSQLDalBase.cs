using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricoBravo.Dal.PostgreSQL.Infra
{
    public class PostgreSQLDalBase
    {
        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection connection = null;

            try
            {
                connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=TricoBravo");
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de conexão: " + e.Message);
            }
            return connection;
        }

        public static void setConnectionClose(NpgsqlConnection connection)
        {
            if (connection != null)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao fechar a conexão" + e.Message);
                }
            }
        }
    }
}