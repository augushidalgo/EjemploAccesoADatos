
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();

        public Form1()
        {
            InitializeComponent();
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
            try
            {
                objetoCN.Insertar(txtnombre.Text, txtdescripcion.Text, txtmarca.Text, double.Parse(txtprecio.Text), int.Parse(txtstock.Text));
                MessageBox.Show("Producto guardado correctamente", "Guardado");
                // Volver a cargar los productos

                // Limpiar los campos llamando a un método que lo haga

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error");
            }
        }

    }
}
