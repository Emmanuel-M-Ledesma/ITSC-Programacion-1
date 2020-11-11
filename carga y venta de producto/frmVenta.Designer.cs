namespace carga_y_venta_de_producto
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSalirVenta = new System.Windows.Forms.Button();
            this.paNewVenta = new System.Windows.Forms.Panel();
            this.btNuevoVenta = new System.Windows.Forms.Button();
            this.paVentaProd = new System.Windows.Forms.Panel();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.btModVenta = new System.Windows.Forms.Button();
            this.btCargaproducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProdVenta = new System.Windows.Forms.TextBox();
            this.txtBuscarVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.paProdVenta = new System.Windows.Forms.Panel();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVventa = new System.Windows.Forms.DataGridView();
            this.paDgvVenta = new System.Windows.Forms.Panel();
            this.DGVstock = new System.Windows.Forms.DataGridView();
            this.paNewVenta.SuspendLayout();
            this.paVentaProd.SuspendLayout();
            this.paProdVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVventa)).BeginInit();
            this.paDgvVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVstock)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalirVenta
            // 
            this.btSalirVenta.BackColor = System.Drawing.Color.Transparent;
            this.btSalirVenta.FlatAppearance.BorderSize = 0;
            this.btSalirVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalirVenta.Image = ((System.Drawing.Image)(resources.GetObject("btSalirVenta.Image")));
            this.btSalirVenta.Location = new System.Drawing.Point(0, 0);
            this.btSalirVenta.Name = "btSalirVenta";
            this.btSalirVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSalirVenta.Size = new System.Drawing.Size(27, 25);
            this.btSalirVenta.TabIndex = 14;
            this.btSalirVenta.UseVisualStyleBackColor = false;
            this.btSalirVenta.Click += new System.EventHandler(this.btSalirVenta_Click);
            // 
            // paNewVenta
            // 
            this.paNewVenta.BackColor = System.Drawing.Color.Transparent;
            this.paNewVenta.Controls.Add(this.btNuevoVenta);
            this.paNewVenta.Location = new System.Drawing.Point(33, 13);
            this.paNewVenta.Name = "paNewVenta";
            this.paNewVenta.Size = new System.Drawing.Size(473, 55);
            this.paNewVenta.TabIndex = 15;
            // 
            // btNuevoVenta
            // 
            this.btNuevoVenta.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btNuevoVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btNuevoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevoVenta.ForeColor = System.Drawing.Color.DarkOrange;
            this.btNuevoVenta.Location = new System.Drawing.Point(19, 15);
            this.btNuevoVenta.Name = "btNuevoVenta";
            this.btNuevoVenta.Size = new System.Drawing.Size(95, 23);
            this.btNuevoVenta.TabIndex = 1;
            this.btNuevoVenta.Text = "Nueva venta";
            this.btNuevoVenta.UseVisualStyleBackColor = true;
            this.btNuevoVenta.Click += new System.EventHandler(this.btNuevoVenta_Click);
            // 
            // paVentaProd
            // 
            this.paVentaProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.paVentaProd.BackColor = System.Drawing.Color.Transparent;
            this.paVentaProd.Controls.Add(this.btFinalizar);
            this.paVentaProd.Controls.Add(this.btModVenta);
            this.paVentaProd.Controls.Add(this.btCargaproducto);
            this.paVentaProd.Controls.Add(this.txtCantidad);
            this.paVentaProd.Controls.Add(this.txtID);
            this.paVentaProd.Controls.Add(this.txtProdVenta);
            this.paVentaProd.Controls.Add(this.txtBuscarVenta);
            this.paVentaProd.Controls.Add(this.label3);
            this.paVentaProd.Controls.Add(this.label2);
            this.paVentaProd.Controls.Add(this.label1);
            this.paVentaProd.Controls.Add(this.lblProducto);
            this.paVentaProd.Enabled = false;
            this.paVentaProd.Location = new System.Drawing.Point(12, 74);
            this.paVentaProd.Name = "paVentaProd";
            this.paVentaProd.Size = new System.Drawing.Size(421, 212);
            this.paVentaProd.TabIndex = 16;
            // 
            // btFinalizar
            // 
            this.btFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinalizar.ForeColor = System.Drawing.Color.Thistle;
            this.btFinalizar.Location = new System.Drawing.Point(259, 126);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 15;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // btModVenta
            // 
            this.btModVenta.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btModVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btModVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModVenta.ForeColor = System.Drawing.Color.Thistle;
            this.btModVenta.Location = new System.Drawing.Point(169, 126);
            this.btModVenta.Name = "btModVenta";
            this.btModVenta.Size = new System.Drawing.Size(75, 23);
            this.btModVenta.TabIndex = 14;
            this.btModVenta.Text = "Modificar";
            this.btModVenta.UseVisualStyleBackColor = true;
            this.btModVenta.Click += new System.EventHandler(this.btModVenta_Click);
            // 
            // btCargaproducto
            // 
            this.btCargaproducto.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btCargaproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btCargaproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCargaproducto.ForeColor = System.Drawing.Color.Thistle;
            this.btCargaproducto.Location = new System.Drawing.Point(80, 126);
            this.btCargaproducto.Name = "btCargaproducto";
            this.btCargaproducto.Size = new System.Drawing.Size(75, 23);
            this.btCargaproducto.TabIndex = 13;
            this.btCargaproducto.Text = "Agregar";
            this.btCargaproducto.UseVisualStyleBackColor = true;
            this.btCargaproducto.Click += new System.EventHandler(this.btCargaproducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(80, 90);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(164, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(80, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 20);
            this.txtID.TabIndex = 11;
            // 
            // txtProdVenta
            // 
            this.txtProdVenta.Location = new System.Drawing.Point(80, 39);
            this.txtProdVenta.Name = "txtProdVenta";
            this.txtProdVenta.Size = new System.Drawing.Size(164, 20);
            this.txtProdVenta.TabIndex = 10;
            // 
            // txtBuscarVenta
            // 
            this.txtBuscarVenta.Location = new System.Drawing.Point(80, 11);
            this.txtBuscarVenta.Name = "txtBuscarVenta";
            this.txtBuscarVenta.Size = new System.Drawing.Size(164, 20);
            this.txtBuscarVenta.TabIndex = 9;
            this.txtBuscarVenta.TextChanged += new System.EventHandler(this.txtBuscarVenta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Producto";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblProducto.Location = new System.Drawing.Point(3, 14);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(46, 13);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Buscar";
            // 
            // paProdVenta
            // 
            this.paProdVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paProdVenta.BackColor = System.Drawing.Color.Transparent;
            this.paProdVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paProdVenta.Controls.Add(this.txtBruto);
            this.paProdVenta.Controls.Add(this.txtTotalVenta);
            this.paProdVenta.Controls.Add(this.txtIva);
            this.paProdVenta.Controls.Add(this.label6);
            this.paProdVenta.Controls.Add(this.label5);
            this.paProdVenta.Controls.Add(this.label4);
            this.paProdVenta.Controls.Add(this.DGVventa);
            this.paProdVenta.Location = new System.Drawing.Point(439, 74);
            this.paProdVenta.Name = "paProdVenta";
            this.paProdVenta.Size = new System.Drawing.Size(309, 394);
            this.paProdVenta.TabIndex = 17;
            // 
            // txtBruto
            // 
            this.txtBruto.BackColor = System.Drawing.Color.LightBlue;
            this.txtBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBruto.Location = new System.Drawing.Point(160, 263);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.ReadOnly = true;
            this.txtBruto.Size = new System.Drawing.Size(100, 22);
            this.txtBruto.TabIndex = 14;
            this.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.BackColor = System.Drawing.Color.LightBlue;
            this.txtTotalVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenta.Location = new System.Drawing.Point(160, 303);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.ReadOnly = true;
            this.txtTotalVenta.Size = new System.Drawing.Size(100, 22);
            this.txtTotalVenta.TabIndex = 13;
            this.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIva
            // 
            this.txtIva.BackColor = System.Drawing.Color.LightBlue;
            this.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(160, 226);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(100, 22);
            this.txtIva.TabIndex = 12;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label6.Location = new System.Drawing.Point(83, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label5.Location = new System.Drawing.Point(82, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label4.Location = new System.Drawing.Point(92, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "IVA";
            // 
            // DGVventa
            // 
            this.DGVventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVventa.EnableHeadersVisualStyles = false;
            this.DGVventa.Location = new System.Drawing.Point(0, 0);
            this.DGVventa.Name = "DGVventa";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DGVventa.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVventa.Size = new System.Drawing.Size(307, 208);
            this.DGVventa.TabIndex = 0;
            this.DGVventa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVventa_CellClick);
            // 
            // paDgvVenta
            // 
            this.paDgvVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.paDgvVenta.BackColor = System.Drawing.Color.Transparent;
            this.paDgvVenta.Controls.Add(this.DGVstock);
            this.paDgvVenta.Location = new System.Drawing.Point(12, 293);
            this.paDgvVenta.Name = "paDgvVenta";
            this.paDgvVenta.Size = new System.Drawing.Size(424, 175);
            this.paDgvVenta.TabIndex = 18;
            // 
            // DGVstock
            // 
            this.DGVstock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVstock.EnableHeadersVisualStyles = false;
            this.DGVstock.Location = new System.Drawing.Point(4, 4);
            this.DGVstock.Name = "DGVstock";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(75)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.DGVstock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVstock.Size = new System.Drawing.Size(417, 168);
            this.DGVstock.TabIndex = 0;
            this.DGVstock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVstock_CellClick);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 480);
            this.Controls.Add(this.paDgvVenta);
            this.Controls.Add(this.paProdVenta);
            this.Controls.Add(this.paVentaProd);
            this.Controls.Add(this.paNewVenta);
            this.Controls.Add(this.btSalirVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(760, 480);
            this.Name = "frmVenta";
            this.Text = "Form1";
            this.paNewVenta.ResumeLayout(false);
            this.paVentaProd.ResumeLayout(false);
            this.paVentaProd.PerformLayout();
            this.paProdVenta.ResumeLayout(false);
            this.paProdVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVventa)).EndInit();
            this.paDgvVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVstock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSalirVenta;
        private System.Windows.Forms.Panel paNewVenta;
        private System.Windows.Forms.Button btNuevoVenta;
        private System.Windows.Forms.Panel paVentaProd;
        private System.Windows.Forms.Panel paProdVenta;
        private System.Windows.Forms.Panel paDgvVenta;
        private System.Windows.Forms.DataGridView DGVventa;
        private System.Windows.Forms.DataGridView DGVstock;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtProdVenta;
        private System.Windows.Forms.TextBox txtBuscarVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCargaproducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btModVenta;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Button btFinalizar;
    }
}