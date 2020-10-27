using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace carga_y_venta_de_producto
{
    public partial class frmMain : Form
    {
        #region Propiedades

        frmStock StockPanel = new frmStock();
        
        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
            designmenu();
        }

        #endregion

        #region Eventos
        private void btStock_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmStock());
            
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            showsubmenu();
        }
        
               
        private void btVenta_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmVenta());

        }
        #endregion

        #region Metodos

        private void designmenu()
        {
            paSubmenu.Visible = false;
            
            
        }
        private void showsubmenu()
        {
            if (paSubmenu.Visible == false)
            {
                paSubmenu.Visible = true;
            }
            else
            {
                paSubmenu.Visible = false;
            }
        }



        private Form Activo = null;
        private void AbrirFormHijo(Form ChildForm)
        {
            if (Activo != null)
            {
                Activo.Close();
            }
            Activo = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            paChildform.Controls.Add(ChildForm);
            paChildform.Tag = ChildForm;
            ChildForm.Show();
        }




        #endregion

        
    }
}