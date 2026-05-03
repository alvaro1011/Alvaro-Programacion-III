using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tienda_virtual_gamer.Controller;
using tienda_virtual_gamer.Models;

namespace tienda_virtual_gamer
{
    public partial class Form4 : Form
    {
        private ProductoController _controller;

        public Form4()
        {
            InitializeComponent();
            _controller = new ProductoController();
            _controller.CrearArchivos();
            CargarComboBoxProductos();
            CargarDatosTabla();
        }

        private void CargarComboBoxProductos()
        {
            var items = _controller.ObtenerProductosParaComboBox();
            cmbProductosLista.Items.Clear();
            cmbProductosLista.Items.AddRange(items.ToArray());

            if (cmbProductosLista.Items.Count > 0)
                cmbProductosLista.SelectedIndex = 0;
        }

        private void CargarDatosTabla()
        {
            GridHelper.CargarTablaSalidas(dataGridView1, _controller.CargarSalidas());
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            if (cmbProductosLista.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccionado = cmbProductosLista.SelectedItem.ToString();
            int idx = seleccionado.IndexOf('-');

            if (idx < 0)
            {
                MessageBox.Show("Formato de producto inválido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string codigo = seleccionado.Substring(0, idx).Trim();
            string nombre = seleccionado.Substring(idx + 1).Trim();
            int cantidad = (int)numStock.Value;
            string observacion = txtObservacion.Text.Trim();

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Producto> productos;
            try
            {
                productos = _controller.ObtenerProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener productos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = productos.Find(p => p.Codigo == codigo);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (producto.Cantidad < cantidad)
            {
                MessageBox.Show($"Stock insuficiente. Solo hay {producto.Cantidad} unidades disponibles.",
                    "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _controller.RestarCantidad(codigo, cantidad);
                _controller.RegistrarSalida(codigo, nombre, cantidad, observacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la salida:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Faltaba este mensaje
            MessageBox.Show($"Salida registrada: -{cantidad} unidades de {nombre}",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDatosTabla();
            CargarComboBoxProductos();
            numStock.Value = 1;
            txtObservacion.Text = "";
        }
    }
}