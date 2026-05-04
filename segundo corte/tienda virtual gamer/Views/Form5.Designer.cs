namespace tienda_virtual_gamer
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalSalidas = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductosStockBajo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.cmbProductosLista = new System.Windows.Forms.ComboBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnFiltrarBusqueda = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductosIngresados = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(32, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock actual";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(50, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(371, 141);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTotalSalidas);
            this.panel1.Location = new System.Drawing.Point(467, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 94);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total productos despachados";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(4, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 94);
            this.panel2.TabIndex = 3;
            // 
            // lblTotalSalidas
            // 
            this.lblTotalSalidas.AutoSize = true;
            this.lblTotalSalidas.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 12F);
            this.lblTotalSalidas.Location = new System.Drawing.Point(145, 28);
            this.lblTotalSalidas.Name = "lblTotalSalidas";
            this.lblTotalSalidas.Size = new System.Drawing.Size(40, 24);
            this.lblTotalSalidas.TabIndex = 6;
            this.lblTotalSalidas.Text = "+0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblProductosStockBajo);
            this.panel3.Location = new System.Drawing.Point(467, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 94);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(3, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total productos con stock bajos";
            // 
            // lblProductosStockBajo
            // 
            this.lblProductosStockBajo.AutoSize = true;
            this.lblProductosStockBajo.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 12F);
            this.lblProductosStockBajo.Location = new System.Drawing.Point(145, 26);
            this.lblProductosStockBajo.Name = "lblProductosStockBajo";
            this.lblProductosStockBajo.Size = new System.Drawing.Size(40, 24);
            this.lblProductosStockBajo.TabIndex = 8;
            this.lblProductosStockBajo.Text = "+0";
            this.lblProductosStockBajo.Click += new System.EventHandler(this.lblProductosStockBajo_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbTipoMovimiento);
            this.panel4.Controls.Add(this.cmbProductosLista);
            this.panel4.Controls.Add(this.btnVerTodos);
            this.panel4.Controls.Add(this.btnFiltrarBusqueda);
            this.panel4.Location = new System.Drawing.Point(467, 337);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 94);
            this.panel4.TabIndex = 3;
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(205, 56);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(66, 23);
            this.cmbTipoMovimiento.TabIndex = 3;
            // 
            // cmbProductosLista
            // 
            this.cmbProductosLista.FormattingEnabled = true;
            this.cmbProductosLista.Location = new System.Drawing.Point(12, 56);
            this.cmbProductosLista.Name = "cmbProductosLista";
            this.cmbProductosLista.Size = new System.Drawing.Size(149, 23);
            this.cmbProductosLista.TabIndex = 2;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.Lime;
            this.btnVerTodos.Location = new System.Drawing.Point(205, 14);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(66, 22);
            this.btnVerTodos.TabIndex = 1;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnFiltrarBusqueda
            // 
            this.btnFiltrarBusqueda.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFiltrarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarBusqueda.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarBusqueda.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnFiltrarBusqueda.Location = new System.Drawing.Point(12, 14);
            this.btnFiltrarBusqueda.Name = "btnFiltrarBusqueda";
            this.btnFiltrarBusqueda.Size = new System.Drawing.Size(149, 22);
            this.btnFiltrarBusqueda.TabIndex = 0;
            this.btnFiltrarBusqueda.Text = "Filtar Busqueda";
            this.btnFiltrarBusqueda.UseVisualStyleBackColor = false;
            this.btnFiltrarBusqueda.Click += new System.EventHandler(this.btnFiltrarBusqueda_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblProductosIngresados);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(467, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(336, 94);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total productos ingresados";
            // 
            // lblProductosIngresados
            // 
            this.lblProductosIngresados.AutoSize = true;
            this.lblProductosIngresados.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 12F);
            this.lblProductosIngresados.Location = new System.Drawing.Point(145, 25);
            this.lblProductosIngresados.Name = "lblProductosIngresados";
            this.lblProductosIngresados.Size = new System.Drawing.Size(40, 24);
            this.lblProductosIngresados.TabIndex = 4;
            this.lblProductosIngresados.Text = "+0";
            this.lblProductosIngresados.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(4, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 94);
            this.panel6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(110, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Store";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(19, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gamer";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(8)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(849, 494);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.ComboBox cmbProductosLista;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnFiltrarBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductosIngresados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalSalidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProductosStockBajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}