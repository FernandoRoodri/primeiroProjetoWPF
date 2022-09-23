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
    /// Interaction logic for viewProduto.xaml
    /// </summary>
    public partial class viewProduto : Window
    {
        public viewProduto()
        {
            InitializeComponent();
        }

        private void btnCadastroProduto(object sender, RoutedEventArgs e)
        {
            cadastroProduto janela = new cadastroProduto();
            janela.Show();
        }
    }
}
