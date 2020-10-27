namespace carga_y_venta_de_producto
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paStock = new System.Windows.Forms.Panel();
            this.btSalirStock = new System.Windows.Forms.Button();
            this.paNuevo = new System.Windows.Forms.Panel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.btCargarStock = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.paCarga = new System.Windows.Forms.Panel();
            this.btModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPVenta = new System.Windows.Forms.ComboBox();
            this.txtPCompra = new System.Windows.Forms.MaskedTextBox();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.btCargaproducto = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.paStock.SuspendLayout();
            this.paNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.paCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // paStock
            // 
            this.paStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paStock.BackgroundImage")));
            this.paStock.Controls.Add(this.btSalirStock);
            this.paStock.Controls.Add(this.paNuevo);
            this.paStock.Controls.Add(this.DGV);
            this.paStock.Controls.Add(this.paCarga);
            this.paStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paStock.Location = new System.Drawing.Point(0, 0);
            this.paStock.MinimumSize = new System.Drawing.Size(760, 480);
            this.paStock.Name = "paStock";
            this.paStock.Size = new System.Drawing.Size(769, 480);
            this.paStock.TabIndex = 10;
            // 
            // btSalirStock
            // 
            this.btSalirStock.BackColor = System.Drawing.Color.Transparent;
            this.btSalirStock.FlatAppearance.BorderSize = 0;
            this.btSalirStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalirStock.Image = ((System.Drawing.Image)(resources.GetObject("btSalirStock.Image")));
            this.btSalirStock.Location = new System.Drawing.Point(0, 0);
            this.btSalirStock.Name = "btSalirStock";
            this.btSalirStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSalirStock.Size = new System.Drawing.Size(27, 25);
            this.btSalirStock.TabIndex = 13;
            this.btSalirStock.UseVisualStyleBackColor = false;
            this.btSalirStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // paNuevo
            // 
            this.paNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paNuevo.BackColor = System.Drawing.Color.Transparent;
            this.paNuevo.Controls.Add(this.lblRuta);
            this.paNuevo.Controls.Add(this.btCargarStock);
            this.paNuevo.Controls.Add(this.btGuardar);
            this.paNuevo.Controls.Add(this.btNuevo);
            this.paNuevo.Location = new System.Drawing.Point(49, 12);
            this.paNuevo.MaximumSize = new System.Drawing.Size(3000, 47);
            this.paNuevo.MinimumSize = new System.Drawing.Size(300, 47);
            this.paNuevo.Name = "paNuevo";
            this.paNuevo.Size = new System.Drawing.Size(695, 47);
            this.paNuevo.TabIndex = 6;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRuta.Location = new System.Drawing.Point(222, 14);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(0, 13);
            this.lblRuta.TabIndex = 3;
            // 
            // btCargarStock
            // 
            this.btCargarStock.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btCargarStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCargarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCargarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargarStock.ForeColor = System.Drawing.Color.DarkOrange;
            this.btCargarStock.Location = new System.Drawing.Point(221, 9);
            this.btCargarStock.Name = "btCargarStock";
            this.btCargarStock.Size = new System.Drawing.Size(62, 23);
            this.btCargarStock.TabIndex = 2;
            this.btCargarStock.Text = "Cargar";
            this.btCargarStock.UseVisualStyleBackColor = true;
            this.btCargarStock.Click += new System.EventHandler(this.btCargarStock_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btGuardar.Location = new System.Drawing.Point(153, 9);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(62, 23);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.ForeColor = System.Drawing.Color.DarkOrange;
            this.btNuevo.Location = new System.Drawing.Point(85, 9);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(62, 23);
            this.btNuevo.TabIndex = 0;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // DGV
            // 
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.Location = new System.Drawing.Point(16, 237);
            this.DGV.Name = "DGV";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.Size = new System.Drawing.Size(728, 231);
            this.DGV.TabIndex = 8;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // paCarga
            // 
            this.paCarga.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paCarga.BackColor = System.Drawing.Color.Transparent;
            this.paCarga.CausesValidation = false;
            this.paCarga.Controls.Add(this.btModificar);
            this.paCarga.Controls.Add(this.button1);
            this.paCarga.Controls.Add(this.txtID);
            this.paCarga.Controls.Add(this.label1);
            this.paCarga.Controls.Add(this.txtPVenta);
            this.paCarga.Controls.Add(this.txtPCompra);
            this.paCarga.Controls.Add(this.txtCantidad);
            this.paCarga.Controls.Add(this.btCargaproducto);
            this.paCarga.Controls.Add(this.lblCantidad);
            this.paCarga.Controls.Add(this.label3);
            this.paCarga.Controls.Add(this.lblPrecio);
            this.paCarga.Controls.Add(this.lblProducto);
            this.paCarga.Controls.Add(this.txtProducto);
            this.paCarga.Enabled = false;
            this.paCarga.ForeColor = System.Drawing.Color.Silver;
            this.paCarga.Location = new System.Drawing.Point(16, 67);
            this.paCarga.MaximumSize = new System.Drawing.Size(3000, 149);
            this.paCarga.MinimumSize = new System.Drawing.Size(300, 149);
            this.paCarga.Name = "paCarga";
            this.paCarga.Size = new System.Drawing.Size(728, 149);
            this.paCarga.TabIndex = 4;
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.Transparent;
            this.btModificar.Enabled = false;
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.ForeColor = System.Drawing.Color.Thistle;
            this.btModificar.Location = new System.Drawing.Point(232, 119);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 14;
            this.btModificar.Text = "Modificar Fila";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(313, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Borrar Fila";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(360, 15);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(334, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // txtPVenta
            // 
            this.txtPVenta.FormattingEnabled = true;
            this.txtPVenta.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.txtPVenta.Location = new System.Drawing.Point(151, 92);
            this.txtPVenta.Name = "txtPVenta";
            this.txtPVenta.Size = new System.Drawing.Size(97, 21);
            this.txtPVenta.TabIndex = 10;
            // 
            // txtPCompra
            // 
            this.txtPCompra.Location = new System.Drawing.Point(151, 67);
            this.txtPCompra.Name = "txtPCompra";
            this.txtPCompra.Size = new System.Drawing.Size(97, 20);
            this.txtPCompra.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(151, 41);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(97, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // btCargaproducto
            // 
            this.btCargaproducto.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btCargaproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btCargaproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCargaproducto.ForeColor = System.Drawing.Color.Thistle;
            this.btCargaproducto.Location = new System.Drawing.Point(151, 119);
            this.btCargaproducto.Name = "btCargaproducto";
            this.btCargaproducto.Size = new System.Drawing.Size(75, 23);
            this.btCargaproducto.TabIndex = 11;
            this.btCargaproducto.Text = "Cargar";
            this.btCargaproducto.UseVisualStyleBackColor = true;
            this.btCargaproducto.Click += new System.EventHandler(this.btCargaproducto_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblCantidad.Location = new System.Drawing.Point(88, 44);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(71, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "% Ganancia";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblPrecio.Location = new System.Drawing.Point(39, 70);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(106, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio de compra";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblProducto.Location = new System.Drawing.Point(87, 18);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(58, 13);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(151, 15);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(165, 20);
            this.txtProducto.TabIndex = 0;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 480);
            this.Controls.Add(this.paStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.Text = "frmVenta";
            this.paStock.ResumeLayout(false);
            this.paNuevo.ResumeLayout(false);
            this.paNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.paCarga.ResumeLayout(false);
            this.paCarga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paStock;
        private System.Windows.Forms.Panel paNuevo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button btCargarStock;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel paCarga;
        private System.Windows.Forms.Button btCargaproducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.MaskedTextBox txtPCompra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSalirStock;
        private System.Windows.Forms.ComboBox txtPVenta;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btModificar;
    }
}