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

namespace MiPrimerFormulario
{
    /// <summary>
    /// Lógica de interacción para Formulario5.xaml
    /// </summary>
    public partial class Formulario5 : Window
    {
        public Formulario5()
        {
            InitializeComponent();
        }

        private void btnVerificarPrimo_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumPrimo.Text, out int numPrimo))
            {
                int divisiones = 0;
                for (int i = 1; i <= numPrimo; i++)
                {
                    if(numPrimo % i == 0)
                    {
                        divisiones++;
                    }
                }
                if (divisiones == 2)
                {
                    MessageBox.Show($"El numero {numPrimo} es primo", "Verificación",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"El numero {numPrimo} no es primo", "Verificación",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Número no valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnVerificarFactorial_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumFact.Text, out int numFactorial))
            {
                double factorial = 1;
                for (int i = 1; i <= numFactorial; i++)
                {
                    factorial *= i; //factorial = factorial * 1
                }
                MessageBox.Show($"El facotiral de {numFactorial} es: \n {factorial}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Número no valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
