using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ChamadaSystem.Conexão
{
    class Bd
    {
        private static string host = "localhost";

        private static string port = "3306";

        private static string user = "root";

        private static string password = "root";

        private static string dbname = "chamada_bd";

        private static MySqlConnection connection;

        private static MySqlCommand cmd;

        public Bd()
        {
            try
            {
                connection = new MySqlConnection($"server={host};database={dbname};port={port};user={user};password={password};Convert Zero Datetime=True");
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro 3306 : Contate o suporte");
                throw;
            }
        }

        public MySqlCommand Query()
        {
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;

                return cmd;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro 3306 : Contate o suporte");
                throw;
            }
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
