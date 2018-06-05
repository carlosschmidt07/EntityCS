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

namespace WpfView
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtNome.Text = "Olá Mundo";
        }

        private void btnTela_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vai  curintia");
        }

        private void checkBoxTela_Checked(object sender, RoutedEventArgs e)
        {
            btnTela.Visibility = Visibility.Hidden;
        }

        private void checkBoxTela_Unchecked(object sender, RoutedEventArgs e)
        {
            btnTela.Visibility = Visibility.Visible;
        }

        private void btnCarregaTela2_Click(object sender, RoutedEventArgs e)
        {
            CadastroUsuario cadUsu = new CadastroUsuario();
            //cadUsu.Show();
            cadUsu.ShowDialog();
        }
    }
}
