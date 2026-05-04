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
    public partial class FormEntradas : Form
    {
        EntradaControlador controladorEntrada = new EntradaControlador();
        ProductoControlador controladorProducto = new ProductoControlador();
        public FormEntradas()
        {
            InitializeComponent();
        }
        private void FormEntradas_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarEntradas();
        }
        private void CargarProductos()
        {
            cbCodigoProductoEntrada.Items.Clear();

            List<Productos> productos = controladorProducto.ObtenerProductos();

            if (productos.Count == 0)
            {
                return;
            }

            foreach (Productos producto in productos)
            {
                cbCodigoProductoEntrada.Items.Add(producto.Nombre);
            }
        }
        private void CargarEntradas()
        {
            dgvEntradas.DataSource = null;
            dgvEntradas.DataSource = controladorEntrada.ObtenerEntradas();
        }
        
        private void btnRegistrarEntradas_Click(object sender, EventArgs e)
        {
            if (cbCodigoProductoEntrada.SelectedIndex == -1 ||nudCantidadEntradas.Value<=0 ||txtObservacionEntradas.Text.Trim() == "")
            {
                lblEstadoEntrada.ForeColor = Color.Red;
                lblEstadoEntrada.Text = "Complete todos los campos";
                return;
            }
            string nombreSeleccionado = cbCodigoProductoEntrada.SelectedItem.ToString();

            Productos productoSeleccionado = controladorProducto.ObtenerProductos()
                .FirstOrDefault(p => p.Nombre == nombreSeleccionado);
            Entradas entrada = new Entradas
            {
                Fecha = dtpFechaEntradas.Value,
                CodigoProducto = productoSeleccionado.Codigo,
                NombreProducto = productoSeleccionado.Nombre,
                Cantidad = (int)nudCantidadEntradas.Value,
                Observacion = txtObservacionEntradas.Text
            };
            controladorEntrada.GuardarEntrada(entrada);

            List<Productos> productos = controladorProducto.ObtenerProductos();

            foreach (Productos producto in productos)
            {
                if (producto.Codigo == productoSeleccionado.Codigo)
                {
                    producto.Stock += (int)nudCantidadEntradas.Value;
                    break;
                }
            }
            controladorProducto.ActualizarProductos(productos);

            lblEstadoEntrada.Text = "Entrada registrada";

            CargarProductos();
        }
        private void btnActualizarEntradas_Click(object sender, EventArgs e)
        {
            CargarEntradas();
        }

        private void lbxCodigoEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}