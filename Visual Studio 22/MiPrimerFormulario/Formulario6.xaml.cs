using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
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
    /// Lógica de interacción para Formulario6.xaml
    /// </summary>
    public partial class Formulario6 : Window
    {
        public Formulario6()
        {
            InitializeComponent();
        }
        private DataTable tabla;
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //obtener valores de los campos
            if (long.TryParse(txtId.Text, out long id) && txtNombre.Text != "" &&
                txtApellido.Text != "" && long.TryParse(txtTelefono.Text, out long tel) && 
                int.TryParse(txtEdad.Text, out int edad))
            {
                var newRow = dataGrid.Items.Add(
                    new
                    {
                        ID = id,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Telefono = tel,
                        Edad = edad
                    });
                //Limpiamos los campos
                txtId.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtEdad.Clear();
            }
            else
            {
                MessageBox.Show("Debe diligenciar todos los campos o número no validos.",
                    "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(dataGrid.SelectedItem != null)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el registro?.", "Confirmación",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    dataGrid.Items.Remove(dataGrid.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar.", "Información",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
