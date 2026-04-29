using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda_virtual_gamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 salida_productos = new Form4();
            salida_productos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 entrada_productos = new Form3();
            entrada_productos.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form2 productos = new Form2();
            productos.Show();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Form5 reportes = new Form5();
            reportes.Show();
        }
    }
}
