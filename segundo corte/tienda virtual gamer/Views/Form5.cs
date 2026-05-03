using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using tienda_virtual_gamer.Controller;
using tienda_virtual_gamer.Models;

namespace tienda_virtual_gamer
{
    public partial class Form5 : Form
    {
        private ProductoController _controller;

        public Form5()
        {
            InitializeComponent();
            _controller = new ProductoController();
            _controller.CrearArchivos();
            CargarComboBoxProductos();
            CargarTarjetas();
            CargarTablaMovimientos(null, "Todos");
            CargarTablaStock();
        }

        // ─────────────────────────────────────────
        // TARJETAS SUPERIORES
        // ─────────────────────────────────────────
        private void CargarTarjetas()
        {
            int totalEntradas = 0;
            int totalSalidas = 0;
            int stockBajo = 0;

            try
            {
                foreach (string[] e in _controller.CargarEntradas())
                    if (e.Length >= 4 && int.TryParse(e[3].Replace("+", ""), out int ce))
                        totalEntradas += ce;

                foreach (string[] s in _controller.CargarSalidas())
                    if (s.Length >= 4 && int.TryParse(s[3].Replace("-", ""), out int cs))
                        totalSalidas += cs;

                foreach (var p in _controller.ObtenerProductos())
                    if (p.Cantidad <= 5) stockBajo++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tarjetas:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            lblProductosIngresados.Text = $"+{totalEntradas}";
            lblTotalSalidas.Text = $"-{totalSalidas}";
            lblProductosStockBajo.Text = stockBajo.ToString();

            lblProductosIngresados.ForeColor = Color.MediumSeaGreen;
            lblTotalSalidas.ForeColor = Color.OrangeRed;
            lblProductosStockBajo.ForeColor = Color.DarkOrange;
        }

        // ─────────────────────────────────────────
        // COMBO BOX
        // ─────────────────────────────────────────
        private void CargarComboBoxProductos()
        {
            cmbProductosLista.Items.Clear();
            cmbProductosLista.Items.Add("— Todos los productos —");

            foreach (string item in _controller.ObtenerProductosParaComboBox())
                cmbProductosLista.Items.Add(item);

            cmbProductosLista.SelectedIndex = 0;

            if (cmbTipoMovimiento.Items.Count == 0)
            {
                cmbTipoMovimiento.Items.Add("Todos");
                cmbTipoMovimiento.Items.Add("Solo entradas");
                cmbTipoMovimiento.Items.Add("Solo salidas");
                cmbTipoMovimiento.SelectedIndex = 0;
            }
        }

        // ─────────────────────────────────────────
        // TABLAS — ahora delegan en GridHelper
        // ─────────────────────────────────────────
        private void CargarTablaMovimientos(string filtroCodigo, string filtroTipo)
        {
            List<string[]> entradas = new List<string[]>();
            List<string[]> salidas = new List<string[]>();

            try
            {
                if (filtroTipo != "Solo salidas") entradas = _controller.CargarEntradas();
                if (filtroTipo != "Solo entradas") salidas = _controller.CargarSalidas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar movimientos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GridHelper.CargarTablaMovimientos(dataGridView1, entradas, salidas, filtroCodigo);
        }

        private void CargarTablaStock()
        {
            List<string[]> entradas;
            List<string[]> salidas;
            List<Producto> productos;

            try
            {
                entradas = _controller.CargarEntradas();
                salidas = _controller.CargarSalidas();
                productos = _controller.ObtenerProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar stock:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GridHelper.CargarTablaStock(dataGridView2, productos, entradas, salidas);
        }


        //Corazón del proyecto
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // ─────────────────────────────────────────
        // BOTONES
        // ─────────────────────────────────────────
        private void btnFiltrarBusqueda_Click(object sender, EventArgs e)
        {
            string filtroCodigo = null;
            string filtroTipo = cmbTipoMovimiento.SelectedItem?.ToString() ?? "Todos";

            string seleccionado = cmbProductosLista.SelectedItem?.ToString() ?? "";
            if (!seleccionado.StartsWith("—"))
            {
                int idx = seleccionado.IndexOf('-');
                if (idx >= 0)
                    filtroCodigo = seleccionado.Substring(0, idx).Trim();
            }

            CargarTablaMovimientos(filtroCodigo, filtroTipo);
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            cmbProductosLista.SelectedIndex = 0;
            cmbTipoMovimiento.SelectedIndex = 0;
            CargarTablaMovimientos(null, "Todos");
            CargarTablaStock();
            CargarTarjetas();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblProductosStockBajo_Click(object sender, EventArgs e)
        {

        }
    }
}