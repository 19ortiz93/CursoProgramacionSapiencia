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
    /// Lógica de interacción para Formulario4.xaml
    /// </summary>
    public partial class Formulario4 : Window
    {
        string[] cursos = { "C# Nivel 1", "C# Nivel 2", "C# Nivel 3", "Java Script Nivel 1", 
            "Python Nivel 1", "Java Nivel 1" };
        public Formulario4()
        {
            InitializeComponent();
            //Llenar combox
            foreach (var curso in cursos)
            {
                cmbCursos.Items.Add(curso);
            }
        }

        private void chkHabilitar_Checked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("habilitado");
            cmbCursos.IsEnabled = true;
        }

        private void chkHabilitar_Unchecked(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("inhabilitado");
            cmbCursos.IsEnabled = false;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //validar si selecciono un elemento de la lista
            if (cmbCursos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un curso", "Advertencia", MessageBoxButton.OK, 
                    MessageBoxImage.Warning);
            }
            else
            {
                string cursoSeleccionado = cmbCursos.SelectedItem as string;
                //MessageBox.Show(cursoSeleccionado);
                if (!lstCursos.Items.Contains(cursoSeleccionado))
                {
                    lstCursos.Items.Add(cursoSeleccionado);
                }
                else
                {
                    MessageBox.Show($"El curso {cursoSeleccionado} ya esta en la lista", 
                        "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"¿Esta seguro de eliminar el curso {lstCursos.SelectedItem} ?",
                "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                lstCursos.Items.Remove(lstCursos.SelectedItem);
            }
        }
    }
}
