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

namespace primeiroProjeto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPessoas_Click(object sender, RoutedEventArgs e)
        {
            viewPessoas janela = new viewPessoas();
            janela.Show();
        }
        private void btnProdutos_Click(object sender, RoutedEventArgs e)
        {
            viewProduto telaproduto = new viewProduto();
            telaproduto.Show();
        }

        private void btnPedidos_Click(object sender, RoutedEventArgs e)
        {
            viewPedido telapedido = new viewPedido();
            telapedido.Show();
        }
    }
}
