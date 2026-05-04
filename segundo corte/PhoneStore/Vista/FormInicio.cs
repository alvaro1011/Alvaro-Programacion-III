using PhoneStore.Vista;
using System;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            new FormProductos().Show();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            new FormEntradas().Show();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            new FormSalidas().Show();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            new FormInformes().Show();
        }
    }
}
