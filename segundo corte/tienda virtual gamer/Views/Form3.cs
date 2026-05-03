using System;
using System.Windows.Forms;
using tienda_virtual_gamer.Controller;
using tienda_virtual_gamer.Models;

namespace tienda_virtual_gamer
{
    public partial class Form3 : Form
    {
        private ProductoController _controller;

        public Form3()
        {
            InitializeComponent();
            _controller = new ProductoController();
            _controller.CrearArchivos();
            CargarComboBoxProductos();
            CargarDatosTabla();
        }

        // ── Combo Box ─────────────────────────────────────────────────
        private void CargarComboBoxProductos()
        {
            var items = _controller.ObtenerProductosParaComboBox();
            cmbCodigoProducto.Items.Clear();
            cmbCodigoProducto.Items.AddRange(items.ToArray());

            if (cmbCodigoProducto.Items.Count > 0)
                cmbCodigoProducto.SelectedIndex = 0;
        }

        // ── Cargar tabla — delega en GridHelper ───────────────────────
        private void CargarDatosTabla()
        {
            try
            {
                GridHelper.CargarTablaEntradas(dtgDatosProductos, _controller.CargarEntradas());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar entradas:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Botón REGISTRAR ENTRADA ───────────────────────────────────
        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (cmbCodigoProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Parseo seguro con IndexOf para nombres con guión
            string seleccionado = cmbCodigoProducto.SelectedItem.ToString();
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

            try
            {
                _controller.ActualizarCantidad(codigo, cantidad);
                _controller.RegistrarEntrada(codigo, nombre, cantidad, observacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la entrada:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Entrada registrada: +{cantidad} unidades de {nombre}",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarDatosTabla();
            CargarComboBoxProductos(); // ✅ Refrescar combo para reflejar nuevo stock
            numStock.Value = 1;
            txtObservacion.Text = "";
        }

        private void txtObservacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}