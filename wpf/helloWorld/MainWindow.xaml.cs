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

namespace helloWorld
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sum = "";
            try
            {
                sum = Convert.ToString(Convert.ToDouble(textBoxPrimeiroNumero.Text) + Convert.ToDouble(textBoxSegundoNumero.Text));
                labelResultado.Content = sum;
            }
            catch
            {
                labelResultado.Content = "Entrada incorreta";
            }
        }
        private void Button_ClickApagar(object sender, RoutedEventArgs e)
        {
            labelResultado.Content = "";
            textBoxPrimeiroNumero.Text = "0";
            textBoxSegundoNumero.Text = "0";

        }
    }
}
