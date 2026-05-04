namespace PhoneStore.Vista
{
    partial class FormSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalidas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstadoSalida = new System.Windows.Forms.Label();
            this.btnRegistrarSalidas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudCantidadSalidas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaSalidas = new System.Windows.Forms.DateTimePicker();
            this.lbxCodigoSalidas = new System.Windows.Forms.ListBox();
            this.txtObservacionSalidas = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.btnActualizarSalidas = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadSalidas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(884, 88);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 88);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(156, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Registro de despacho de mercancía";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(152, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gestión de Salidas";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 94);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 372);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblEstadoSalida);
            this.groupBox1.Controls.Add(this.btnRegistrarSalidas);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 320);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Salida";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblEstadoSalida
            // 
            this.lblEstadoSalida.AutoSize = true;
            this.lblEstadoSalida.Location = new System.Drawing.Point(24, 275);
            this.lblEstadoSalida.Name = "lblEstadoSalida";
            this.lblEstadoSalida.Size = new System.Drawing.Size(0, 23);
            this.lblEstadoSalida.TabIndex = 8;
            // 
            // btnRegistrarSalidas
            // 
            this.btnRegistrarSalidas.AutoSize = true;
            this.btnRegistrarSalidas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarSalidas.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarSalidas.Location = new System.Drawing.Point(57, 229);
            this.btnRegistrarSalidas.Name = "btnRegistrarSalidas";
            this.btnRegistrarSalidas.Size = new System.Drawing.Size(165, 35);
            this.btnRegistrarSalidas.TabIndex = 7;
            this.btnRegistrarSalidas.Text = "Registrar Salida";
            this.btnRegistrarSalidas.UseVisualStyleBackColor = false;
            this.btnRegistrarSalidas.Click += new System.EventHandler(this.btnRegistrarSalidas_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19763F));
            this.tableLayoutPanel1.Controls.Add(this.nudCantidadSalidas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaSalidas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbxCodigoSalidas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtObservacionSalidas, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 178);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // nudCantidadSalidas
            // 
            this.nudCantidadSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCantidadSalidas.Location = new System.Drawing.Point(143, 96);
            this.nudCantidadSalidas.Name = "nudCantidadSalidas";
            this.nudCantidadSalidas.Size = new System.Drawing.Size(136, 32);
            this.nudCantidadSalidas.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 40);
            this.label4.TabIndex = 13;
            this.label4.Text = "Observación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 48);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cód. Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(74, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // dtpFechaSalidas
            // 
            this.dtpFechaSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaSalidas.Location = new System.Drawing.Point(143, 3);
            this.dtpFechaSalidas.Name = "dtpFechaSalidas";
            this.dtpFechaSalidas.Size = new System.Drawing.Size(136, 32);
            this.dtpFechaSalidas.TabIndex = 15;
            // 
            // lbxCodigoSalidas
            // 
            this.lbxCodigoSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxCodigoSalidas.FormattingEnabled = true;
            this.lbxCodigoSalidas.ItemHeight = 23;
            this.lbxCodigoSalidas.Location = new System.Drawing.Point(143, 48);
            this.lbxCodigoSalidas.Name = "lbxCodigoSalidas";
            this.lbxCodigoSalidas.Size = new System.Drawing.Size(136, 42);
            this.lbxCodigoSalidas.TabIndex = 16;
            // 
            // txtObservacionSalidas
            // 
            this.txtObservacionSalidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacionSalidas.Location = new System.Drawing.Point(143, 141);
            this.txtObservacionSalidas.Name = "txtObservacionSalidas";
            this.txtObservacionSalidas.Size = new System.Drawing.Size(136, 32);
            this.txtObservacionSalidas.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSalidas);
            this.groupBox2.Controls.Add(this.btnActualizarSalidas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 272);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de Entradas";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalidas.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSalidas.Location = new System.Drawing.Point(3, 28);
            this.dgvSalidas.MultiSelect = false;
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.ReadOnly = true;
            this.dgvSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalidas.Size = new System.Drawing.Size(576, 193);
            this.dgvSalidas.TabIndex = 9;
            // 
            // btnActualizarSalidas
            // 
            this.btnActualizarSalidas.AutoSize = true;
            this.btnActualizarSalidas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarSalidas.ForeColor = System.Drawing.Color.White;
            this.btnActualizarSalidas.Location = new System.Drawing.Point(372, 229);
            this.btnActualizarSalidas.Name = "btnActualizarSalidas";
            this.btnActualizarSalidas.Size = new System.Drawing.Size(208, 35);
            this.btnActualizarSalidas.TabIndex = 8;
            this.btnActualizarSalidas.Text = "🔁 Actualizar historial";
            this.btnActualizarSalidas.UseVisualStyleBackColor = false;
            this.btnActualizarSalidas.Click += new System.EventHandler(this.btnActualizarSalidas_Click);
            // 
            // FormSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 466);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormSalidas";
            this.Text = "FormSalidas";
            this.Load += new System.EventHandler(this.FormSalidas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadSalidas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarSalidas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown nudCantidadSalidas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidas;
        private System.Windows.Forms.ListBox lbxCodigoSalidas;
        private System.Windows.Forms.TextBox txtObservacionSalidas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnActualizarSalidas;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.Label lblEstadoSalida;
    }
}