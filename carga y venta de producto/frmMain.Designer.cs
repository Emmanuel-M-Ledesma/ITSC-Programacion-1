namespace carga_y_venta_de_producto
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.paMenu = new System.Windows.Forms.Panel();
            this.paSubmenu = new System.Windows.Forms.Panel();
            this.btVenta = new System.Windows.Forms.Button();
            this.btStock = new System.Windows.Forms.Button();
            this.btMainMenu = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.paChildform = new System.Windows.Forms.Panel();
            this.paInicio = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.lblGO = new System.Windows.Forms.Label();
            this.lblVR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paMenu.SuspendLayout();
            this.paSubmenu.SuspendLayout();
            this.paChildform.SuspendLayout();
            this.paInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // paMenu
            // 
            this.paMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(1)))), ((int)(((byte)(19)))));
            this.paMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paMenu.BackgroundImage")));
            this.paMenu.Controls.Add(this.paSubmenu);
            this.paMenu.Controls.Add(this.btMainMenu);
            this.paMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.paMenu.Location = new System.Drawing.Point(0, 0);
            this.paMenu.Name = "paMenu";
            this.paMenu.Size = new System.Drawing.Size(79, 480);
            this.paMenu.TabIndex = 7;
            // 
            // paSubmenu
            // 
            this.paSubmenu.BackColor = System.Drawing.Color.Transparent;
            this.paSubmenu.Controls.Add(this.btVenta);
            this.paSubmenu.Controls.Add(this.btStock);
            this.paSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSubmenu.Location = new System.Drawing.Point(0, 46);
            this.paSubmenu.Name = "paSubmenu";
            this.paSubmenu.Size = new System.Drawing.Size(79, 64);
            this.paSubmenu.TabIndex = 1;
            // 
            // btVenta
            // 
            this.btVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenta.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVenta.Image = ((System.Drawing.Image)(resources.GetObject("btVenta.Image")));
            this.btVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVenta.Location = new System.Drawing.Point(0, 29);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(79, 33);
            this.btVenta.TabIndex = 1;
            this.btVenta.Text = "Venta";
            this.btVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVenta.UseVisualStyleBackColor = true;
            this.btVenta.Click += new System.EventHandler(this.btVenta_Click);
            // 
            // btStock
            // 
            this.btStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStock.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btStock.Image = ((System.Drawing.Image)(resources.GetObject("btStock.Image")));
            this.btStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStock.Location = new System.Drawing.Point(0, 0);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(79, 29);
            this.btStock.TabIndex = 0;
            this.btStock.Text = "     Stock";
            this.btStock.UseVisualStyleBackColor = true;
            this.btStock.Click += new System.EventHandler(this.btStock_Click);
            // 
            // btMainMenu
            // 
            this.btMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMainMenu.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("btMainMenu.Image")));
            this.btMainMenu.Location = new System.Drawing.Point(0, 0);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(79, 46);
            this.btMainMenu.TabIndex = 0;
            this.btMainMenu.UseVisualStyleBackColor = false;
            this.btMainMenu.Click += new System.EventHandler(this.btMainMenu_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(8, 0);
            // 
            // paChildform
            // 
            this.paChildform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paChildform.BackgroundImage")));
            this.paChildform.Controls.Add(this.paInicio);
            this.paChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paChildform.Location = new System.Drawing.Point(79, 0);
            this.paChildform.MinimumSize = new System.Drawing.Size(760, 480);
            this.paChildform.Name = "paChildform";
            this.paChildform.Size = new System.Drawing.Size(760, 480);
            this.paChildform.TabIndex = 8;
            // 
            // paInicio
            // 
            this.paInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paInicio.BackColor = System.Drawing.Color.Transparent;
            this.paInicio.Controls.Add(this.linkLabel1);
            this.paInicio.Controls.Add(this.btRefresh);
            this.paInicio.Controls.Add(this.lblGO);
            this.paInicio.Controls.Add(this.lblVR);
            this.paInicio.Controls.Add(this.label1);
            this.paInicio.Controls.Add(this.label2);
            this.paInicio.Location = new System.Drawing.Point(26, 30);
            this.paInicio.Name = "paInicio";
            this.paInicio.Size = new System.Drawing.Size(706, 420);
            this.paInicio.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.Location = new System.Drawing.Point(626, 366);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 54);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btRefresh.Enabled = false;
            this.btRefresh.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.Thistle;
            this.btRefresh.Location = new System.Drawing.Point(0, 0);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 15;
            this.btRefresh.Text = "Refrescar";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // lblGO
            // 
            this.lblGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGO.Location = new System.Drawing.Point(450, 81);
            this.lblGO.Name = "lblGO";
            this.lblGO.Size = new System.Drawing.Size(204, 81);
            this.lblGO.TabIndex = 5;
            this.lblGO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVR
            // 
            this.lblVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVR.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblVR.Location = new System.Drawing.Point(77, 81);
            this.lblVR.Name = "lblVR";
            this.lblVR.Size = new System.Drawing.Size(133, 81);
            this.lblVR.TabIndex = 4;
            this.lblVR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(431, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ganancias Obtenidas";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(49, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ventas Realizadas";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 480);
            this.Controls.Add(this.paChildform);
            this.Controls.Add(this.paMenu);
            this.MinimumSize = new System.Drawing.Size(855, 519);
            this.Name = "frmMain";
            this.Text = "Carga y venta";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.paMenu.ResumeLayout(false);
            this.paSubmenu.ResumeLayout(false);
            this.paChildform.ResumeLayout(false);
            this.paInicio.ResumeLayout(false);
            this.paInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paMenu;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel paSubmenu;
        private System.Windows.Forms.Button btVenta;
        private System.Windows.Forms.Button btStock;
        private System.Windows.Forms.Button btMainMenu;
        private System.Windows.Forms.Panel paChildform;
        private System.Windows.Forms.Panel paInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGO;
        private System.Windows.Forms.Label lblVR;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

