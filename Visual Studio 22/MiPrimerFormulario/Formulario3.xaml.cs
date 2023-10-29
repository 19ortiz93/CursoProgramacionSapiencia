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
    /// Lógica de interacción para Formulario3.xaml
    /// </summary>
    public partial class Formulario3 : Window
    {
        // Arrays de productos con precios
        private string[] productos = { "Destornillador", "Martillo", "Palustre", "Regla Nivel" };
        private double[] precios = { 8000, 12000, 15000, 7000 };
        private double precio = 0;
        public Formulario3()
        {
            InitializeComponent();
            foreach (var item in productos)
            {
                cmbProductos.Items.Add(item);
            }
        }

        private void cmbProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Obtener el indice del producto seleccionado
            int indiceSeleccionado = cmbProductos.SelectedIndex;
            //MessageBox.Show($"indice:   {indiceSeleccionado}");
            if (indiceSeleccionado >= 0 && indiceSeleccionado < precios.Length)
            {
                precio = precios[indiceSeleccionado];
                txtPrecio.Text = precio.ToString(); // conversion de double a string con ToString
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            // Validar la cantidad ingresada
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                double descuento = 0;
                //validar mayor a cero
                if (cantidad > 0)
                {
                    if (rbDescuento.IsChecked == true)
                    {
                        descuento = 0.1D;
                    }
                    double total = (precio*cantidad) - ((precio * cantidad)*descuento);
                    txtTotal.Text = total.ToString("C"); //formato de moneda "C"
                }
                else
                {
                    //Ventana de mensaje con icono y titutlo
                    MessageBox.Show("Debe ingresar una cantidad minimo de uno", 
                        "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                //Ventana de mensaje con icono y titutlo
                MessageBox.Show("Por favor ingrese una cantidad válida",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
