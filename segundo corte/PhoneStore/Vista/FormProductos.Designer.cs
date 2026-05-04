namespace PhoneStore
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnLimpiarProductos = new System.Windows.Forms.Button();
            this.btnGuardarProductos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudStockinicialProductos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrecioProductos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoriaProductos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreProductos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoProductos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnActualizarProductos = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockinicialProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(152, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gestión de Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(156, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Registra y revisa tus productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 90);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 91);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 375);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.btnLimpiarProductos);
            this.groupBox1.Controls.Add(this.btnGuardarProductos);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Producto";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblEstado.Location = new System.Drawing.Point(39, 343);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 23);
            this.lblEstado.TabIndex = 11;
            // 
            // btnLimpiarProductos
            // 
            this.btnLimpiarProductos.AutoSize = true;
            this.btnLimpiarProductos.BackColor = System.Drawing.Color.DarkRed;
            this.btnLimpiarProductos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarProductos.Location = new System.Drawing.Point(178, 288);
            this.btnLimpiarProductos.Name = "btnLimpiarProductos";
            this.btnLimpiarProductos.Size = new System.Drawing.Size(110, 33);
            this.btnLimpiarProductos.TabIndex = 10;
            this.btnLimpiarProductos.Text = "🧹 Limpiar";
            this.btnLimpiarProductos.UseVisualStyleBackColor = false;
            this.btnLimpiarProductos.Click += new System.EventHandler(this.btnLimpiarProductos_Click);
            // 
            // btnGuardarProductos
            // 
            this.btnGuardarProductos.AutoSize = true;
            this.btnGuardarProductos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardarProductos.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProductos.Location = new System.Drawing.Point(33, 288);
            this.btnGuardarProductos.Name = "btnGuardarProductos";
            this.btnGuardarProductos.Size = new System.Drawing.Size(115, 33);
            this.btnGuardarProductos.TabIndex = 9;
            this.btnGuardarProductos.Text = "💾 Guardar";
            this.btnGuardarProductos.UseVisualStyleBackColor = false;
            this.btnGuardarProductos.Click += new System.EventHandler(this.btnGuardarProductos_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.22989F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.77011F));
            this.tableLayoutPanel1.Controls.Add(this.nudStockinicialProductos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudPrecioProductos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbCategoriaProductos, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreProductos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoProductos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(261, 231);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // nudStockinicialProductos
            // 
            this.nudStockinicialProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudStockinicialProductos.Location = new System.Drawing.Point(108, 192);
            this.nudStockinicialProductos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStockinicialProductos.Name = "nudStockinicialProductos";
            this.nudStockinicialProductos.Size = new System.Drawing.Size(150, 32);
            this.nudStockinicialProductos.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "Stock Ini.:";
            // 
            // nudPrecioProductos
            // 
            this.nudPrecioProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPrecioProductos.Location = new System.Drawing.Point(108, 146);
            this.nudPrecioProductos.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrecioProductos.Name = "nudPrecioProductos";
            this.nudPrecioProductos.Size = new System.Drawing.Size(150, 32);
            this.nudPrecioProductos.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(13, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 46);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio($):";
            // 
            // cbCategoriaProductos
            // 
            this.cbCategoriaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCategoriaProductos.FormattingEnabled = true;
            this.cbCategoriaProductos.Items.AddRange(new object[] {
            "Pantallas",
            "",
            "Baterías",
            "",
            "Cargadores",
            "",
            "Forros"});
            this.cbCategoriaProductos.Location = new System.Drawing.Point(108, 98);
            this.cbCategoriaProductos.Name = "cbCategoriaProductos";
            this.cbCategoriaProductos.Size = new System.Drawing.Size(150, 31);
            this.cbCategoriaProductos.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoría:";
            // 
            // txtNombreProductos
            // 
            this.txtNombreProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreProductos.Location = new System.Drawing.Point(108, 46);
            this.txtNombreProductos.Name = "txtNombreProductos";
            this.txtNombreProductos.Size = new System.Drawing.Size(150, 32);
            this.txtNombreProductos.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // txtCodigoProductos
            // 
            this.txtCodigoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigoProductos.Location = new System.Drawing.Point(108, 3);
            this.txtCodigoProductos.Name = "txtCodigoProductos";
            this.txtCodigoProductos.Size = new System.Drawing.Size(150, 32);
            this.txtCodigoProductos.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(27, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarProductos);
            this.groupBox2.Controls.Add(this.btnActualizarProductos);
            this.groupBox2.Controls.Add(this.dgvProductos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 375);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Productos";
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.AutoSize = true;
            this.btnEliminarProductos.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarProductos.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProductos.Location = new System.Drawing.Point(460, 229);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(116, 33);
            this.btnEliminarProductos.TabIndex = 11;
            this.btnEliminarProductos.Text = "🗑️ Eliminar";
            this.btnEliminarProductos.UseVisualStyleBackColor = false;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // btnActualizarProductos
            // 
            this.btnActualizarProductos.AutoSize = true;
            this.btnActualizarProductos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarProductos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarProductos.Location = new System.Drawing.Point(310, 229);
            this.btnActualizarProductos.Name = "btnActualizarProductos";
            this.btnActualizarProductos.Size = new System.Drawing.Size(131, 33);
            this.btnActualizarProductos.TabIndex = 8;
            this.btnActualizarProductos.Text = "🔁 Actualizar";
            this.btnActualizarProductos.UseVisualStyleBackColor = false;
            this.btnActualizarProductos.Click += new System.EventHandler(this.btnActualizarProductos_Click_1);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(3, 28);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(576, 181);
            this.dgvProductos.TabIndex = 0;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormProductos";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockinicialProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrecioProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategoriaProductos;
        private System.Windows.Forms.NumericUpDown nudStockinicialProductos;
        private System.Windows.Forms.Button btnGuardarProductos;
        private System.Windows.Forms.Button btnActualizarProductos;
        private System.Windows.Forms.Button btnLimpiarProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Label lblEstado;
    }
}