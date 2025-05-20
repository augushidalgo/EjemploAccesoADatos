
using CapaNegocio;
using System.Configuration;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        bool editar = false;

        public Form1()
        {
            InitializeComponent();

            // Inyección de cadena de conexion hacia la biblioteca de clases
            //string cadenaConexion =ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dgvProductos.DataSource = objeto.Mostrar();
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Definir colores del encabezado
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Ocultar la columna ID
            dgvProductos.Columns[0].Visible = false;

            // Cambiar el texto de los encabezados
            dgvProductos.Columns[1].HeaderText = "Nombre Producto";
            dgvProductos.Columns[2].HeaderText = "Descripción";
            dgvProductos.Columns[3].HeaderText = "Marca";
            dgvProductos.Columns[4].HeaderText = "Precio";
            dgvProductos.Columns[5].HeaderText = "Stock";

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    objetoCN.Insertar(txtnombre.Text, txtdescripcion.Text, txtmarca.Text, double.Parse(txtprecio.Text), int.Parse(txtstock.Text));
                    MessageBox.Show("Producto guardado correctamente", "Guardado");
                    MostrarProductos();


                    // Limpiar los campos llamando a un método que lo haga

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id"].Value.ToString());
                    objetoCN.EditarProd(id,txtnombre.Text, txtdescripcion.Text, txtmarca.Text, double.Parse(txtprecio.Text), int.Parse(txtstock.Text));
                    MessageBox.Show("Producto guardado correctamente", "Guardado");
                    MostrarProductos();


                    // Limpiar los campos llamando a un método que lo haga

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                string idProducto = dgvProductos.CurrentRow.Cells["id"].Value.ToString();
                objetoCN.EliminarProd(idProducto);
                MessageBox.Show("Producto eliminado correctamente", "Eliminado");
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Error");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                editar = true;
                txtnombre.Text = dgvProductos.CurrentRow.Cells["nombre"].Value.ToString();
                txtdescripcion.Text = dgvProductos.CurrentRow.Cells["descripcion"].Value.ToString();
                txtmarca.Text = dgvProductos.CurrentRow.Cells["marca"].Value.ToString();
                txtprecio.Text = dgvProductos.CurrentRow.Cells["precio"].Value.ToString();
                txtstock.Text = dgvProductos.CurrentRow.Cells["stock"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto");
            }
        }
    }
}
