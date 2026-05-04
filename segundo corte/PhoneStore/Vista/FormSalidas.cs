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

namespace PhoneStore.Vista
{
    public partial class FormSalidas : Form
    {
        SalidaControlador controladorSalida = new SalidaControlador();
        ProductoControlador controladorProducto = new ProductoControlador();
        public FormSalidas()
        {
            InitializeComponent();
        }

        private void FormSalidas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarProductos();
                CargarSalidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarProductos()
        {
            lbxCodigoSalidas.Items.Clear();

            List<Productos> productos = controladorProducto.ObtenerProductos();

            if (productos.Count == 0)
            {
                return;
            }

            foreach (Productos producto in productos)
            {
                lbxCodigoSalidas.Items.Add(producto.Nombre);
            }
        }
        private void CargarSalidas()
        {
            dgvSalidas.DataSource = null;
            dgvSalidas.DataSource = controladorSalida.ObtenerSalidas();
        }
        private void btnRegistrarSalidas_Click(object sender, EventArgs e)
        {
            if (lbxCodigoSalidas.SelectedIndex == -1 ||
                nudCantidadSalidas.Value <= 0 ||
                txtObservacionSalidas.Text.Trim() == "")
            {
                lblEstadoSalida.ForeColor = Color.Red;
                lblEstadoSalida.Text = "Complete todos los campos";
                return;
            }

            string nombreSeleccionado = lbxCodigoSalidas.SelectedItem.ToString();

            Productos productoSeleccionado = controladorProducto.ObtenerProductos()
                .FirstOrDefault(p => p.Nombre == nombreSeleccionado);

            if (productoSeleccionado == null)
            {
                return;
            }

            if (productoSeleccionado.Stock < (int)nudCantidadSalidas.Value)
            {
                lblEstadoSalida.ForeColor = Color.Red;
                lblEstadoSalida.Text = "Stock insuficiente";
                return;
            }

            Salidas salida = new Salidas
            {
                Fecha = dtpFechaSalidas.Value,
                CodigoProducto = productoSeleccionado.Codigo,
                NombreProducto = productoSeleccionado.Nombre,
                Cantidad = (int)nudCantidadSalidas.Value,
                Observacion = txtObservacionSalidas.Text
            };

            controladorSalida.GuardarSalida(salida);

            List<Productos> productos = controladorProducto.ObtenerProductos();

            foreach (Productos producto in productos)
            {
                if (producto.Codigo == productoSeleccionado.Codigo)
                {
                    producto.Stock -= (int)nudCantidadSalidas.Value;
                    break;
                }
            }

            controladorProducto.ActualizarProductos(productos);

            lblEstadoSalida.ForeColor = Color.GreenYellow;
            lblEstadoSalida.Text = "Salida registrada";

            CargarSalidas();
            CargarProductos();
        }

        private void btnActualizarSalidas_Click(object sender, EventArgs e)
        {
            CargarSalidas();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
