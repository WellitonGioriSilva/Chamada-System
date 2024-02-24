using ChamadaSystem.Views;
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

namespace ChamadaSystem
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCadTurma_Click(object sender, RoutedEventArgs e)
        {
            fmFrame.Navigate(new CadTurma());
        }

        private void btSair_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Tem certeza que deseja sair?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question))
            {
                this.Close();
            }
        }

        private void btVoltar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Tem certeza que deseja voltar?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question))
            {
                fmFrame.Navigate(null);
            }
        }
    }
}
