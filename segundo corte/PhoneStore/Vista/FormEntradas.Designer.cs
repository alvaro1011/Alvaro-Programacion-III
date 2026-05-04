namespace PhoneStore.Vista
{
    partial class FormEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntradas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblEstadoEntrada = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarEntradas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbCodigoProductoEntrada = new System.Windows.Forms.ComboBox();
            this.nudCantidadEntradas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaEntradas = new System.Windows.Forms.DateTimePicker();
            this.txtObservacionEntradas = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizarEntradas = new System.Windows.Forms.Button();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadEntradas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(884, 90);
            this.panel2.TabIndex = 3;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(156, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Registra el ingreso de mercancia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(152, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gestión de Entradas";
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
            this.splitContainer1.Panel1.Controls.Add(this.lblEstadoEntrada);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 372);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 4;
            // 
            // lblEstadoEntrada
            // 
            this.lblEstadoEntrada.AutoSize = true;
            this.lblEstadoEntrada.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblEstadoEntrada.Location = new System.Drawing.Point(103, 279);
            this.lblEstadoEntrada.Name = "lblEstadoEntrada";
            this.lblEstadoEntrada.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoEntrada.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnRegistrarEntradas);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Entrada";
            // 
            // btnRegistrarEntradas
            // 
            this.btnRegistrarEntradas.AutoSize = true;
            this.btnRegistrarEntradas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarEntradas.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEntradas.Location = new System.Drawing.Point(71, 229);
            this.btnRegistrarEntradas.Name = "btnRegistrarEntradas";
            this.btnRegistrarEntradas.Size = new System.Drawing.Size(169, 35);
            this.btnRegistrarEntradas.TabIndex = 7;
            this.btnRegistrarEntradas.Text = "Registrar Entrada";
            this.btnRegistrarEntradas.UseVisualStyleBackColor = false;
            this.btnRegistrarEntradas.Click += new System.EventHandler(this.btnRegistrarEntradas_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80237F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19763F));
            this.tableLayoutPanel1.Controls.Add(this.cbCodigoProductoEntrada, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudCantidadEntradas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaEntradas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtObservacionEntradas, 1, 3);
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
            // cbCodigoProductoEntrada
            // 
            this.cbCodigoProductoEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCodigoProductoEntrada.FormattingEnabled = true;
            this.cbCodigoProductoEntrada.Location = new System.Drawing.Point(143, 48);
            this.cbCodigoProductoEntrada.Name = "cbCodigoProductoEntrada";
            this.cbCodigoProductoEntrada.Size = new System.Drawing.Size(136, 31);
            this.cbCodigoProductoEntrada.TabIndex = 20;
            // 
            // nudCantidadEntradas
            // 
            this.nudCantidadEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCantidadEntradas.Location = new System.Drawing.Point(143, 96);
            this.nudCantidadEntradas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidadEntradas.Name = "nudCantidadEntradas";
            this.nudCantidadEntradas.Size = new System.Drawing.Size(136, 32);
            this.nudCantidadEntradas.TabIndex = 17;
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
            // dtpFechaEntradas
            // 
            this.dtpFechaEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaEntradas.Location = new System.Drawing.Point(143, 3);
            this.dtpFechaEntradas.Name = "dtpFechaEntradas";
            this.dtpFechaEntradas.Size = new System.Drawing.Size(136, 32);
            this.dtpFechaEntradas.TabIndex = 15;
            // 
            // txtObservacionEntradas
            // 
            this.txtObservacionEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacionEntradas.Location = new System.Drawing.Point(143, 141);
            this.txtObservacionEntradas.Name = "txtObservacionEntradas";
            this.txtObservacionEntradas.Size = new System.Drawing.Size(136, 32);
            this.txtObservacionEntradas.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizarEntradas);
            this.groupBox2.Controls.Add(this.dgvEntradas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 272);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de Entradas";
            // 
            // btnActualizarEntradas
            // 
            this.btnActualizarEntradas.AutoSize = true;
            this.btnActualizarEntradas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarEntradas.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEntradas.Location = new System.Drawing.Point(372, 229);
            this.btnActualizarEntradas.Name = "btnActualizarEntradas";
            this.btnActualizarEntradas.Size = new System.Drawing.Size(208, 35);
            this.btnActualizarEntradas.TabIndex = 8;
            this.btnActualizarEntradas.Text = "🔁 Actualizar historial";
            this.btnActualizarEntradas.UseVisualStyleBackColor = false;
            this.btnActualizarEntradas.Click += new System.EventHandler(this.btnActualizarEntradas_Click);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntradas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEntradas.Location = new System.Drawing.Point(3, 28);
            this.dgvEntradas.MultiSelect = false;
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntradas.Size = new System.Drawing.Size(576, 193);
            this.dgvEntradas.TabIndex = 0;
            // 
            // FormEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 466);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormEntradas";
            this.Text = "FormEntradas";
            this.Load += new System.EventHandler(this.FormEntradas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadEntradas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarEntradas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Button btnActualizarEntradas;
        private System.Windows.Forms.NumericUpDown nudCantidadEntradas;
        private System.Windows.Forms.DateTimePicker dtpFechaEntradas;
        private System.Windows.Forms.TextBox txtObservacionEntradas;
        private System.Windows.Forms.Label lblEstadoEntrada;
        private System.Windows.Forms.ComboBox cbCodigoProductoEntrada;
    }
}