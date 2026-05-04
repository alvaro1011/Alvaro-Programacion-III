using System;
using System.Windows.Forms;
using tienda_virtual_gamer.Controller;
using tienda_virtual_gamer.Models;

namespace tienda_virtual_gamer
{
    public partial class Form2 : Form
    {
        private ProductoController _controller = new ProductoController();

        public Form2()
        {
            InitializeComponent();
            _controller.CrearArchivos();
            ActualizarTablaProductos();
        }

        // ── Botón GUARDAR ─────────────────────────────────────────────
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código es obligatorio.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Aviso");
                return;
            }

            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría.", "Aviso");
                return;
            }

            if (_controller.CodigoExiste(txtCodigo.Text))
            {
                MessageBox.Show("Ya existe un producto con ese código.", "Aviso");
                return;
            }

            if (!decimal.TryParse(numPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio no es válido.", "Aviso");
                return;
            }

            if (!int.TryParse(numStock.Text, out int cantidad))
            {
                MessageBox.Show("El stock no es válido.", "Aviso");
                return;
            }

            Producto nuevo = new Producto
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Categoria = cmbCategoria.SelectedItem.ToString(),
                Precio = precio,
                Cantidad = cantidad
            };

            try
            {
                _controller.AgregarProducto(nuevo);
                MessageBox.Show("¡Producto registrado con éxito!", "Éxito");
                ActualizarTablaProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Limpiar campos ────────────────────────────────────────────
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            numPrecio.Text = "0";
            numStock.Text = "0";
        }

        // ── Cargar tabla — delega en GridHelper ───────────────────────
        private void ActualizarTablaProductos()
        {
            try
            {
                GridHelper.CargarTablaProductos(dtgDatosProductos, _controller.ObtenerProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form2_Load(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string producto_borrar = txtCodigo_borrar.Text;
            for (int i = 0; i < dtgDatosProductos.Rows.Count; i++)
            {
                if (dtgDatosProductos.Rows[i].Cells[0].Value != null &&
                    dtgDatosProductos.Rows[i].Cells[0].Value.ToString() == producto_borrar)
                {
                    try
                    {
                        _controller.EliminarProducto(producto_borrar);
                        ActualizarTablaProductos();
                        txtCodigo_borrar.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto:\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }


        }
    }
}