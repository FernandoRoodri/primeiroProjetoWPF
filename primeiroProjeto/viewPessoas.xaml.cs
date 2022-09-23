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
using System.Windows.Shapes;

namespace primeiroProjeto
{
    /// <summary>
    /// Interaction logic for viewPessoas.xaml
    /// </summary>
    public partial class viewPessoas : Window
    {
        public viewPessoas()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, RoutedEventArgs e)
        {
            cadastroPedido janela = new cadastroPedido();
            janela.Show();
        }

        private void btnNovaPessoa_Click(object sender, RoutedEventArgs e)
        {
            cadastroPessoa janela = new cadastroPessoa();
            janela.Show();
        }
    }
}
