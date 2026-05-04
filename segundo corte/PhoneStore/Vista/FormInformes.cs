using System;
using PhoneStore.Controlador;
using PhoneStore.Modelo;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PhoneStore.Vista
{
    public partial class FormInformes : Form
    {
        public FormInformes()
        {
            InitializeComponent();
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            CargarResumen();
            CargarProductos();
            CargarMovimientos();
            CargarStock();
        }
        private void CargarResumen()
        {
            int totalEntradas = 0;
            int totalSalidas = 0;
            int stockBajo = 0;

            if (File.Exists("entradas.csv"))
            {
                foreach (var l in File.ReadAllLines("entradas.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 4) continue;

                    int cantidad = 0;
                    int.TryParse(d[3], out cantidad);

                    totalEntradas += cantidad;
                }
            }

            if (File.Exists("salidas.csv"))
            {
                foreach (var l in File.ReadAllLines("salidas.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 4) continue;

                    int cantidad = 0;
                    int.TryParse(d[3], out cantidad);

                    totalSalidas += cantidad;
                }
            }

            if (File.Exists("productos.csv"))
            {
                foreach (var l in File.ReadAllLines("productos.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 5) continue;

                    int stock = 0;
                    int.TryParse(d[4], out stock);

                    if (stock <= 3) stockBajo++;
                }
            }

            lblEntradas.Text = "+" + totalEntradas;
            lblSalidas.Text = "-" + totalSalidas;
            lblStockBajo.Text = stockBajo.ToString();
        }
        private void CargarProductos()
        {
            cbProducto.Items.Clear();

            if (File.Exists("productos.csv"))
            {
                foreach (var l in File.ReadAllLines("productos.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 2) continue;

                    cbProducto.Items.Add(d[1]);
                }
            }
        }
        private void CargarMovimientos()
        {
            dgvMovimientos.Rows.Clear();

            if (File.Exists("entradas.csv"))
            {
                foreach (var l in File.ReadAllLines("entradas.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 4) continue;

                    int row = dgvMovimientos.Rows.Add(
                        d[0],      
                        d[1],    
                        "Entrada",
                        d[3],      
                        d[2]       
                    );

                    dgvMovimientos.Rows[row].DefaultCellStyle.ForeColor = Color.Green;
                }
            }

            if (File.Exists("salidas.csv"))
            {
                foreach (var l in File.ReadAllLines("salidas.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 4) continue;

                    int row = dgvMovimientos.Rows.Add(
                        d[0],
                        d[1],
                        "Salida",
                        d[3],
                        d[2]
                    );

                    dgvMovimientos.Rows[row].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string producto = cbProducto.Text;
            string tipo = cbTipo.Text;

            dgvMovimientos.Rows.Clear();

            if (File.Exists("entradas.csv"))
            {
                foreach (var l in File.ReadAllLines("entradas.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 4) continue;

                    if ((producto == "" || d[2] == producto) &&
                        (tipo == "" || tipo == "Entrada"))
                    {
                        int row = dgvMovimientos.Rows.Add(
                            d[0],
                            d[1],
                            "Entrada",
                            d[3],
                            d[2]
                        );

                        dgvMovimientos.Rows[row].DefaultCellStyle.ForeColor = Color.Green;
                    }
                }
            }

            if (File.Exists("salidas.csv"))
            {
                foreach (var l in File.ReadAllLines("salidas.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 4) continue;

                    if ((producto == "" || d[2] == producto) &&
                        (tipo == "" || tipo == "Salida"))
                    {
                        int row = dgvMovimientos.Rows.Add(
                            d[0],
                            d[1],
                            "Salida",
                            d[3],
                            d[2]
                        );

                        dgvMovimientos.Rows[row].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }

            CargarResumen();
        }
        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        private void CargarStock()
        {
            dgvStock.Rows.Clear();

            if (File.Exists("productos.csv"))
            {
                foreach (var l in File.ReadAllLines("productos.csv"))
                {
                    if (string.IsNullOrWhiteSpace(l)) continue;

                    var d = l.Split(',');
                    if (d.Length < 5) continue;

                    int stock = 0;
                    int.TryParse(d[4], out stock);

                    int row = dgvStock.Rows.Add(d[0], d[1], stock);

                    if (stock <= 3)
                        dgvStock.Rows[row].DefaultCellStyle.BackColor = Color.LightCoral;
                    else if (stock <= 5)
                        dgvStock.Rows[row].DefaultCellStyle.BackColor = Color.Khaki;
                    else
                        dgvStock.Rows[row].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
    }
}