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
            this.paMenu.SuspendLayout();
            this.paSubmenu.SuspendLayout();
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
            this.paMenu.Size = new System.Drawing.Size(227, 480);
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
            this.paSubmenu.Size = new System.Drawing.Size(227, 62);
            this.paSubmenu.TabIndex = 1;
            // 
            // btVenta
            // 
            this.btVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVenta.Location = new System.Drawing.Point(0, 29);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(227, 33);
            this.btVenta.TabIndex = 1;
            this.btVenta.Text = "Venta";
            this.btVenta.UseVisualStyleBackColor = true;
            this.btVenta.Click += new System.EventHandler(this.btVenta_Click);
            // 
            // btStock
            // 
            this.btStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStock.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btStock.Location = new System.Drawing.Point(0, 0);
            this.btStock.Name = "btStock";
            this.btStock.Size = new System.Drawing.Size(227, 29);
            this.btStock.TabIndex = 0;
            this.btStock.Text = "Stock";
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
            this.btMainMenu.Location = new System.Drawing.Point(0, 0);
            this.btMainMenu.Name = "btMainMenu";
            this.btMainMenu.Size = new System.Drawing.Size(227, 46);
            this.btMainMenu.TabIndex = 0;
            this.btMainMenu.Text = "Menu";
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
            this.paChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paChildform.Location = new System.Drawing.Point(227, 0);
            this.paChildform.MinimumSize = new System.Drawing.Size(760, 480);
            this.paChildform.Name = "paChildform";
            this.paChildform.Size = new System.Drawing.Size(790, 480);
            this.paChildform.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1017, 480);
            this.Controls.Add(this.paChildform);
            this.Controls.Add(this.paMenu);
            this.MinimumSize = new System.Drawing.Size(944, 519);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.paMenu.ResumeLayout(false);
            this.paSubmenu.ResumeLayout(false);
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
    }
}

