using System;
using PhoneStore.Controlador;
using PhoneStore.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStore
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        ProductoControlador controlador = new ProductoControlador();
        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();  
        }
        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = controlador.ObtenerProductos();
        }

        private void btnGuardarProductos_Click(object sender, EventArgs e)
        {
            if (txtCodigoProductos.Text.Trim() == "" ||
                txtNombreProductos.Text.Trim() == "" ||
                cbCategoriaProductos.SelectedIndex == -1 ||
                nudPrecioProductos.Value <= 0 ||
                nudStockinicialProductos.Value <= 0)
            {
                lblEstado.ForeColor = Color.Red;
                lblEstado.Text = "Complete todos los campos";
                return;
            }
            Productos producto = new Productos
            {
                Codigo = txtCodigoProductos.Text,
                Nombre = txtNombreProductos.Text,
                Categoria = cbCategoriaProductos.Text,
                Precio = nudPrecioProductos.Value,
                Stock = (int)nudStockinicialProductos.Value

            };
            controlador.GuardarProducto(producto);
            lblEstado.Text = "Producto guardado correctamente";
        }
        private void LimpiarCampos()
        {
            txtCodigoProductos.Clear();
            txtNombreProductos.Clear();
            cbCategoriaProductos.SelectedIndex = -1;
            nudPrecioProductos.Value = 0;
            nudStockinicialProductos.Value = 0;
        }
        private void btnLimpiarProductos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                string codigo = dgvProductos.CurrentRow.Cells[0].Value.ToString();

                controlador.EliminarProducto(codigo);

                CargarProductos();
                LimpiarCampos();
            }
        }
        private void btnActualizarProductos_Click_1(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }   
}
