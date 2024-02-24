using ChamadaSystem.Conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChamadaSystem.Models
{
    internal class TurmaDAO
    {
        private static Bd conn;
        public TurmaDAO()
        {
            conn = new Bd();
        }

        public void Insert(Turma turma)
        {
            try
            {
                var query = conn.Query();

                query.CommandText = $"INSERT INTO Turma VALUES(null, @curso, @periodo);";

                query.Parameters.AddWithValue("@curso", turma.curso);
                query.Parameters.AddWithValue("@periodo", turma.periodo);

                query.ExecuteNonQuery();

                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: Contate o Suporte!");
            }
        }
    }
}
