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
using System.Diagnostics.Tracing;

namespace carga_y_venta_de_producto
{
    public partial class frmMain : Form
    {
        #region Propiedades
        Carga cargadatos = new Carga();

       

        #endregion
        
        #region Constructor

        public frmMain()
        {
            InitializeComponent();
            designmenu();
            btRefresh.Enabled = true;
        }

        #endregion

        #region Eventos
        private void btRefresh_Click(object sender, EventArgs e)
        {
            
            cargadatos.cargartxt();
            lblGO.Text = "$ " + cargadatos.residual;
            cargadatos.CargarContador();
            lblVR.Text = cargadatos.residual1;
        }
        private void btStock_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmStock());
            showsubmenu();
            
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            showsubmenu();
        }


        private void btVenta_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmVenta());
            showsubmenu();
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo github1 = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(github1);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/Emmanuel-M-Ledesma");
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
            ChildForm.BringToFront();
            ChildForm.Show();
            
        }












        #endregion

        

        
    }
}