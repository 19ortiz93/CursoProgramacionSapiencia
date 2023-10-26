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

namespace MiPrimerFormulario
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            //mostrar en una label el resultado 2
            //mostrar en una ventana 1
            //mostrar en un textbox o textblock el resultado 3
            int num1 = 0, num2 = 0, suma = 0;
            //num1 = Convert.ToInt32(txtNumero1.Text);
            //num2 = Convert.ToInt32(txtNumero2.Text);

            //validar los datos TryParse = intente pasar tipo
            if (!int.TryParse(txtNumero1.Text, out num1))
            {
                MessageBox.Show("Debe ingresar un número valido");
                txtNumero1.Focus();
                txtNumero1.Text = "";
                return;
            }
            if (!int.TryParse(txtNumero2.Text, out num2))
            {
                MessageBox.Show("Debe ingresar un número valido");
                txtNumero2.Focus();
                txtNumero2.Text = "";
                return;
            }

            suma = num1 + num2; //int
            // ventanas de mensajes
            //MessageBox.Show($"La suma es: {suma}"); //string
            //label de mensaje
            lblResultado.Content = "La suma es: " + suma; //content
            txtResultado.Text = suma.ToString();
            txtResultado.IsEnabled = false;
        }
    }
}
