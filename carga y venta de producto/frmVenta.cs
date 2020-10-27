using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carga_y_venta_de_producto
{
    public partial class frmVenta : Form
    {
        DataTable venta = new DataTable();
        DataTable final = new DataTable();
        frmStock Stock = new frmStock();
        int posicion;
        Carga cargadatos = new Carga();
        public string ganancia;
        public string PrecCompra;
        public frmVenta()
        {
            InitializeComponent();
            btCargaproducto.Enabled = false;
            DGVventa.DataSource = final;
        }
        #region Eventos
        private void btSalirVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNuevoVenta_Click(object sender, EventArgs e)
        {

            final.TableName = "Final";
            final.Columns.Add("ID", typeof(string));
            final.Columns.Add("Producto", typeof(string));
            final.Columns.Add("Cantidad", typeof(int));
            final.Columns.Add("Total", typeof(decimal));
            DGVventa.Columns[0].Width = 50;
            DGVventa.Columns[2].Width = 50;



            venta.TableName = "Stock";
            venta.Columns.Add("ID", typeof(string));
            venta.Columns.Add("Producto", typeof(string));
            venta.Columns.Add("Cantidad", typeof(int));
            venta.Columns.Add("Precio de compra", typeof(decimal));
            venta.Columns.Add("Total", typeof(decimal));
            venta.Columns.Add("Porcentaje de ganancia", typeof(string));
            venta.Columns.Add("Ganancia total", typeof(decimal));


            venta.ReadXml(@"C:\Users\Emma\Desktop\321.xml");

            DGVstock.DataSource = venta;




            btNuevoVenta.Enabled = false;
        }

        #endregion

        private void DGVstock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Convert.ToString(txtCantidad.Text);
            posicion = DGVstock.CurrentRow.Index;
            txtCantidad.Text = DGVstock["Cantidad", posicion].Value.ToString();
            txtID.Text = DGVstock["ID", posicion].Value.ToString();
            txtProdVenta.Text = DGVstock["Producto", posicion].Value.ToString();
            ganancia = DGVstock["Porcentaje de ganancia", posicion].Value.ToString();
            PrecCompra = DGVstock["Precio de compra", posicion].Value.ToString();
            Ganancia();
            btCargaproducto.Enabled = true;
            

        }

        private void btCargaproducto_Click(object sender, EventArgs e)
        {
            cargadatos.Cantidad = System.Convert.ToDecimal(txtCantidad.Text);
            cargadatos.TotalIndividual();
            final.Rows.Add();
            final.Rows[final.Rows.Count - 1]["ID"] = System.Convert.ToString(txtID.Text);
            final.Rows[final.Rows.Count - 1]["Producto"] = System.Convert.ToString(txtProdVenta.Text);
            final.Rows[final.Rows.Count - 1]["Cantidad"] = System.Convert.ToString(txtCantidad.Text);
            final.Rows[final.Rows.Count - 1]["Total"] = System.Convert.ToString(cargadatos.PrecVenta);
            //venta.Rows

            LimpiarControles();
        }
        private void LimpiarControles()
        {
            txtCantidad.Text = "";
            txtBuscarVenta.Text = "";
            txtID.Text = "";
            txtProdVenta.Text = "";
        }
        private void Ganancia()
        {
            if (ganancia == "10%")
            {
                cargadatos.Ganancia = 10;
            }
            if (ganancia == "20%")
            {
                cargadatos.Ganancia= 20;
            }
            if (ganancia == "30%")
            {
                cargadatos.Ganancia = 30;
            }
            if (ganancia == "40%")
            {
                cargadatos.Ganancia= 40;
            }
            if (ganancia == "50%")
            {
                cargadatos.Ganancia = 50;
            }
            if (ganancia == "60%")
            {
                cargadatos.Ganancia= 60;
            }
            if (ganancia == "70%")
            {
                cargadatos.Ganancia = 70;
            }
            if (ganancia == "80%")
            {
                cargadatos.Ganancia = 80;
            }
            if (ganancia == "90%")
            {
                cargadatos.Ganancia = 90;
            }
            if (ganancia == "100%")
            {
                cargadatos.Ganancia = 100;
            }
        }
        
    }
}
