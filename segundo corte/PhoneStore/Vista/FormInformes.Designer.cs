namespace PhoneStore.Vista
{
    partial class FormInformes
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;

        private System.Windows.Forms.Panel panelResumen1;
        private System.Windows.Forms.Panel panelResumen2;
        private System.Windows.Forms.Panel panelResumen3;

        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label lblEntradasTexto;

        private System.Windows.Forms.Label lblSalidas;
        private System.Windows.Forms.Label lblSalidasTexto;

        private System.Windows.Forms.Label lblStockBajo;
        private System.Windows.Forms.Label lblStockBajoTexto;

        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnVerTodo;

        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridView dgvStock;

        private System.Windows.Forms.Label lblFiltroProducto;
        private System.Windows.Forms.Label lblFiltroTipo;
        private System.Windows.Forms.GroupBox groupStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformes));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelResumen1 = new System.Windows.Forms.Panel();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblEntradasTexto = new System.Windows.Forms.Label();
            this.panelResumen2 = new System.Windows.Forms.Panel();
            this.lblSalidas = new System.Windows.Forms.Label();
            this.lblSalidasTexto = new System.Windows.Forms.Label();
            this.panelResumen3 = new System.Windows.Forms.Panel();
            this.lblStockBajo = new System.Windows.Forms.Label();
            this.lblStockBajoTexto = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.lblFiltroProducto = new System.Windows.Forms.Label();
            this.lblFiltroTipo = new System.Windows.Forms.Label();
            this.groupStock = new System.Windows.Forms.GroupBox();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResumen1.SuspendLayout();
            this.panelResumen2.SuspendLayout();
            this.panelResumen3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.groupStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(950, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 90);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(155, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión de Informes";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(159, 45);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(197, 13);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Resumen de movimientos y stock actual";
            // 
            // panelResumen1
            // 
            this.panelResumen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumen1.Controls.Add(this.lblEntradas);
            this.panelResumen1.Controls.Add(this.lblEntradasTexto);
            this.panelResumen1.Location = new System.Drawing.Point(15, 105);
            this.panelResumen1.Name = "panelResumen1";
            this.panelResumen1.Size = new System.Drawing.Size(290, 70);
            this.panelResumen1.TabIndex = 1;
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblEntradas.ForeColor = System.Drawing.Color.Green;
            this.lblEntradas.Location = new System.Drawing.Point(120, 10);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(42, 30);
            this.lblEntradas.TabIndex = 0;
            this.lblEntradas.Text = "+0";
            // 
            // lblEntradasTexto
            // 
            this.lblEntradasTexto.AutoSize = true;
            this.lblEntradasTexto.Location = new System.Drawing.Point(90, 45);
            this.lblEntradasTexto.Name = "lblEntradasTexto";
            this.lblEntradasTexto.Size = new System.Drawing.Size(131, 13);
            this.lblEntradasTexto.TabIndex = 1;
            this.lblEntradasTexto.Text = "Total unidades ingresadas";
            // 
            // panelResumen2
            // 
            this.panelResumen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumen2.Controls.Add(this.lblSalidas);
            this.panelResumen2.Controls.Add(this.lblSalidasTexto);
            this.panelResumen2.Location = new System.Drawing.Point(325, 105);
            this.panelResumen2.Name = "panelResumen2";
            this.panelResumen2.Size = new System.Drawing.Size(290, 70);
            this.panelResumen2.TabIndex = 2;
            // 
            // lblSalidas
            // 
            this.lblSalidas.AutoSize = true;
            this.lblSalidas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSalidas.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSalidas.Location = new System.Drawing.Point(120, 10);
            this.lblSalidas.Name = "lblSalidas";
            this.lblSalidas.Size = new System.Drawing.Size(35, 30);
            this.lblSalidas.TabIndex = 0;
            this.lblSalidas.Text = "-0";
            // 
            // lblSalidasTexto
            // 
            this.lblSalidasTexto.AutoSize = true;
            this.lblSalidasTexto.Location = new System.Drawing.Point(80, 45);
            this.lblSalidasTexto.Name = "lblSalidasTexto";
            this.lblSalidasTexto.Size = new System.Drawing.Size(144, 13);
            this.lblSalidasTexto.TabIndex = 1;
            this.lblSalidasTexto.Text = "Total unidades despachadas";
            // 
            // panelResumen3
            // 
            this.panelResumen3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumen3.Controls.Add(this.lblStockBajo);
            this.panelResumen3.Controls.Add(this.lblStockBajoTexto);
            this.panelResumen3.Location = new System.Drawing.Point(635, 105);
            this.panelResumen3.Name = "panelResumen3";
            this.panelResumen3.Size = new System.Drawing.Size(290, 70);
            this.panelResumen3.TabIndex = 3;
            // 
            // lblStockBajo
            // 
            this.lblStockBajo.AutoSize = true;
            this.lblStockBajo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStockBajo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblStockBajo.Location = new System.Drawing.Point(125, 10);
            this.lblStockBajo.Name = "lblStockBajo";
            this.lblStockBajo.Size = new System.Drawing.Size(26, 30);
            this.lblStockBajo.TabIndex = 0;
            this.lblStockBajo.Text = "0";
            // 
            // lblStockBajoTexto
            // 
            this.lblStockBajoTexto.AutoSize = true;
            this.lblStockBajoTexto.Location = new System.Drawing.Point(85, 45);
            this.lblStockBajoTexto.Name = "lblStockBajoTexto";
            this.lblStockBajoTexto.Size = new System.Drawing.Size(128, 13);
            this.lblStockBajoTexto.TabIndex = 1;
            this.lblStockBajoTexto.Text = "Productos con stock bajo";
            // 
            // cbProducto
            // 
            this.cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducto.Location = new System.Drawing.Point(80, 192);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(200, 21);
            this.cbProducto.TabIndex = 5;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cbTipo.Location = new System.Drawing.Point(340, 192);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(150, 21);
            this.cbTipo.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(510, 190);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 25);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(615, 190);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(90, 25);
            this.btnVerTodo.TabIndex = 9;
            this.btnVerTodo.Text = "Ver todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            this.btnVerTodo.Click += new System.EventHandler(this.btnVerTodo_Click);
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFecha,
            this.colProducto,
            this.colTipo,
            this.colCantidad,
            this.colObservacion});
            this.dgvMovimientos.Location = new System.Drawing.Point(15, 230);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.Size = new System.Drawing.Size(910, 180);
            this.dgvMovimientos.TabIndex = 10;
            //
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colStock});
            this.dgvStock.Location = new System.Drawing.Point(10, 20);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(890, 170);
            this.dgvStock.TabIndex = 0;
            // 
            // lblFiltroProducto
            // 
            this.lblFiltroProducto.AutoSize = true;
            this.lblFiltroProducto.Location = new System.Drawing.Point(20, 195);
            this.lblFiltroProducto.Name = "lblFiltroProducto";
            this.lblFiltroProducto.Size = new System.Drawing.Size(53, 13);
            this.lblFiltroProducto.TabIndex = 4;
            this.lblFiltroProducto.Text = "Producto:";
            // 
            // lblFiltroTipo
            // 
            this.lblFiltroTipo.AutoSize = true;
            this.lblFiltroTipo.Location = new System.Drawing.Point(300, 195);
            this.lblFiltroTipo.Name = "lblFiltroTipo";
            this.lblFiltroTipo.Size = new System.Drawing.Size(31, 13);
            this.lblFiltroTipo.TabIndex = 6;
            this.lblFiltroTipo.Text = "Tipo:";
            // 
            // groupStock
            // 
            this.groupStock.Controls.Add(this.dgvStock);
            this.groupStock.Location = new System.Drawing.Point(15, 425);
            this.groupStock.Name = "groupStock";
            this.groupStock.Size = new System.Drawing.Size(910, 200);
            this.groupStock.TabIndex = 11;
            this.groupStock.TabStop = false;
            this.groupStock.Text = "Stock actual por producto";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colObservacion
            // 
            this.colObservacion.HeaderText = "Observación";
            this.colObservacion.Name = "colObservacion";
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelResumen1);
            this.Controls.Add(this.panelResumen2);
            this.Controls.Add(this.panelResumen3);
            this.Controls.Add(this.lblFiltroProducto);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.lblFiltroTipo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnVerTodo);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.groupStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormInformes";
            this.Text = "FormInformes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResumen1.ResumeLayout(false);
            this.panelResumen1.PerformLayout();
            this.panelResumen2.ResumeLayout(false);
            this.panelResumen2.PerformLayout();
            this.panelResumen3.ResumeLayout(false);
            this.panelResumen3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.groupStock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
    }
}