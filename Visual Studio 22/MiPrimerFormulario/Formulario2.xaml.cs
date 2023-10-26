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
    /// Lógica de interacción para Formulario2.xaml
    /// </summary>
    public partial class Formulario2 : Window
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double num1) && double.TryParse(txtNumero2.Text, out double num2))
            {
                //Proceso
                double resultado = 0;
                if (rbSuma.IsChecked == true)
                {
                    resultado = num1 + num2;
                } else if (rbResta.IsChecked == true)
                {
                    resultado = num1 - num2;
                } else if (rbMulti.IsChecked == true)
                {
                    resultado = num1 * num2;
                } else if (rbDivi.IsChecked == true)
                {
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Error: no se puede dividir por cero. ");
                    }
                }
                //imprimir el resultado
                MessageBox.Show($"el resultado es: {resultado}");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}
