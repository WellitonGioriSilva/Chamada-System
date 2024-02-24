using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChamadaSystem.Conexão;
using ChamadaSystem.Models;

namespace ChamadaSystem.Views
{
    /// <summary>
    /// Interação lógica para CadTurma.xam
    /// </summary>
    public partial class CadTurma : Page
    {
        public CadTurma()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            Turma turmaDados = new Turma();
            turmaDados.curso = tbCurso.Text;
            turmaDados.periodo = tbPeriodo.Text;

            TurmaDAO turmaDAO = new TurmaDAO();
            turmaDAO.Insert(turmaDados);
        }
    }
}
