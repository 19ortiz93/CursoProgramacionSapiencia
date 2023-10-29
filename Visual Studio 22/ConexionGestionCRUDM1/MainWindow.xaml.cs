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
//llamar librerias para configurar la conexión
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionCRUDM1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection conexionSql;
        public MainWindow()
        {
            InitializeComponent();
            listarCategorias();
            //configuración de la cadena de conexion
            string conexion = ConfigurationManager.ConnectionStrings["ConexionGestionCRUDM1.Properties.Settings.dbCrudWPFm1ConnectionString"].ConnectionString;
            conexionSql = new SqlConnection(conexion);
            datosProductos();
            //probar la conexión
            /*try
            {
                conexionSql.Open();
                MessageBox.Show("Conexión exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        // crear metodo para llenar los datos de sql server a la dataGrid
        private void datosProductos()
        {
            string consulta = "select p.*, c.categoria from productos p inner join categorias c on p.idCategoria = c.Id";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionSql);
            using (adaptador)
            {
                // Formato para tablas DataTable
                DataTable tablaProductos = new DataTable(); // almacear los datos sql
                adaptador.Fill(tablaProductos);// llena los datos en el datatable
                foreach (DataRow row in tablaProductos.Rows)
                {
                    var newRow = dtgProductos.Items.Add(
                        new
                        {
                            Id = row["Id"].ToString(),
                            descripcion = row["descripcion"].ToString(),
                            precio = row["precio"].ToString(),
                            cantidad = row["cantidad"].ToString(),
                            fechaVencimiento = row["fechaVencimiento"].ToString(),
                            categoria = row["categoria"].ToString(),
                            estado = row["estado"].ToString()
                        });
                }
                //dtgProductos.ItemsSource = tablaProductos.DefaultView;
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dtgProductos.SelectedItems.Count != 0)
            {
                dynamic selectRow = dtgProductos.SelectedItem;
                int id = Convert.ToInt32(selectRow.Id);
                //MessageBox.Show(id.ToString());
                string consulta = "delete from productos where Id = @Id";
                SqlCommand miCommand = new SqlCommand(consulta, conexionSql);
                conexionSql.Open();
                miCommand.Parameters.AddWithValue("@Id", id);
                miCommand.ExecuteNonQuery();
                conexionSql.Close();
                dtgProductos.Items.Remove(dtgProductos.SelectedItem);
                dtgProductos.Items.Refresh();
            }
        }

        //llenar la lista de categorias
        private void listarCategorias()
        {
            string consulta = "select * from categorias;";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexionSql);
            using (adaptador)
            {
                DataTable listaCategorias = new DataTable();
                adaptador.Fill(listaCategorias);
                cmbCategorias.DisplayMemberPath = "categoria";
                cmbCategorias.SelectedValuePath = "Id";
                cmbCategorias.ItemsSource = listaCategorias.DefaultView;
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            string estado = "inactivo";
            string descripcion = txtDescripcion.Text;
            float precio = Convert.ToSingle(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            dynamic fecha = dpkFechaVencimiento.SelectedDate;
            //año/mes/dia
            string formatoFecha = null;
            if(fecha != null)
            {
                formatoFecha = fecha.ToString("yyyy/MM/dd");
            }
            int idCategoria = Convert.ToInt32(cmbCategorias.SelectedValue);
            //int idCategoria = 5;
            if (chkEstado.IsChecked == true)
            {
                estado = "Activo";
            }
            string consulta = "insert into productos (descripcion, precio, cantidad, fechaVencimiento, idCategoria, estado)" +
                " values(@descripcion, @precio, @cantidad, @fechavencimiento, @idCategoria, @estado)";
            SqlCommand miCommand = new SqlCommand(consulta, conexionSql);
            conexionSql.Open();
            miCommand.Parameters.AddWithValue("@descripcion", descripcion);
            miCommand.Parameters.AddWithValue("@precio", precio);
            miCommand.Parameters.AddWithValue("@cantidad", cantidad);
            miCommand.Parameters.AddWithValue("@fechaVencimiento", formatoFecha);
            miCommand.Parameters.AddWithValue("@idCategoria", idCategoria);
            miCommand.Parameters.AddWithValue("@estado", estado);
            miCommand.ExecuteNonQuery();
            conexionSql.Close();
            MessageBox.Show("Registro exitoso");
            while (dtgProductos.Items.Count > 0)
            {
                dtgProductos.Items.RemoveAt(0); //Eliminar cada registro de la dtagrid (vacia)
            }
            datosProductos(); //volver a cargar los datos en la datagrid
            dtgProductos.Items.Refresh();
        }
    }
}
