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
    public partial class frmStock : Form
    {
        #region Propiedades
        Carga cargadatos = new Carga();
        DataTable Stock = new DataTable();
        SaveFileDialog Guardar = new SaveFileDialog();
        private frmStock stockPanel;
        int posicion;
        public string resultado;
        private int i;
        #endregion

        #region Constructor
        public frmStock()
        {
            InitializeComponent();
        }

        public frmStock(frmStock stockPanel)
        {
            this.stockPanel = stockPanel;
        }
        #endregion

        #region Eventos
        private void btNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            if (DGV.DataSource != Stock)
            {
                paCarga.Enabled = true;
                Stock.TableName = "Stock";
                Stock.Columns.Add("ID", typeof(string));
                Stock.Columns.Add("Producto", typeof(string));
                Stock.Columns.Add("Cantidad", typeof(int));
                Stock.Columns.Add("Precio de compra", typeof(decimal));
                Stock.Columns.Add("Total", typeof(decimal));
                Stock.Columns.Add("Porcentaje de ganancia", typeof(string));
                Stock.Columns.Add("Ganancia total", typeof(decimal));
                DGV.DataSource = Stock;
                btNuevo.Enabled = false;

                
                
            }
            btNuevo.Enabled = false;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                
                resultado = System.Convert.ToString(Guardar.FileName);
                Stock.WriteXml(resultado);
                btNuevo.Enabled = true;
            }
        }

        private void btCargarStock_Click(object sender, EventArgs e)
        {

            OpenFileDialog cargar = new OpenFileDialog();

            //Process.Start()


            if (cargar.ShowDialog() == DialogResult.OK)
            {

                Stock.ReadXml(cargar.FileName);
                DGV.DataSource = Stock;
            }


        }
        private void btCargaproducto_Click(object sender, EventArgs e)
        {


            if (txtCantidad.Text == "" || txtPCompra.Text == "")
            {
                MessageBox.Show("Debe completar los campos de cantidad y precios con caracteres numericos", "Error en el formulario");
            }
            else
            {

                cargadatos.Cantidad = System.Convert.ToDecimal(txtCantidad.Text);
                cargadatos.PrecCompra = System.Convert.ToDecimal(txtPCompra.Text);
                Ganancia();
                cargadatos.GananciaStock();

                cargadatos.TotalStock();
                Stock.Rows.Add();
                Stock.Rows[Stock.Rows.Count - 1]["ID"] = txtID.Text;
                Stock.Rows[Stock.Rows.Count - 1]["Producto"] = txtProducto.Text;
                Stock.Rows[Stock.Rows.Count - 1]["Cantidad"] = System.Convert.ToDecimal(txtCantidad.Text);
                Stock.Rows[Stock.Rows.Count - 1]["Precio de compra"] = System.Convert.ToDecimal(txtPCompra.Text);
                Stock.Rows[Stock.Rows.Count - 1]["Total"] = cargadatos.Total;
                Stock.Rows[Stock.Rows.Count - 1]["Porcentaje de ganancia"] = System.Convert.ToString(txtPVenta.Text);
                Stock.Rows[Stock.Rows.Count - 1]["Ganancia total"] = cargadatos.Ganancia;
                LimpiarControles();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Stock.Rows.Count.Equals(0))
            {
                MessageBox.Show("No se pueden borrar mas filas", "Error en la tabla");
            }
            else
            {
                DGV.Rows.Remove(DGV.CurrentRow);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //paStock.Visible = false;
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                posicion = DGV.CurrentRow.Index;
                txtProducto.Text = DGV["Producto", posicion].Value.ToString();
                txtID.Text = DGV["ID", posicion].Value.ToString();
                txtCantidad.Text = DGV["Cantidad", posicion].Value.ToString();
                txtPCompra.Text = DGV["Precio de compra", posicion].Value.ToString();
                txtPVenta.Text = DGV["Porcentaje de ganancia", posicion].Value.ToString();
                btCargaproducto.Enabled = false;
                btModificar.Enabled = true;
                        

        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("No se puede modificar una celda vacia", "Error al modificar");
            }
            else
            {
                cargadatos.Cantidad = System.Convert.ToDecimal(txtCantidad.Text);
                cargadatos.PrecCompra = System.Convert.ToDecimal(txtPCompra.Text);
                Ganancia();
                cargadatos.GananciaStock();
                cargadatos.TotalStock();

                DGV["ID", posicion].Value = txtID.Text;
                DGV["Producto", posicion].Value = txtProducto.Text;
                DGV["Cantidad", posicion].Value = System.Convert.ToDecimal(txtCantidad.Text);
                DGV["Precio de compra", posicion].Value = System.Convert.ToDecimal(txtPCompra.Text);
                DGV["Porcentaje de ganancia", posicion].Value = System.Convert.ToString(txtPVenta.Text);
                DGV["Total", posicion].Value = cargadatos.Total;
                DGV["Ganancia total", posicion].Value = cargadatos.Ganancia;
                LimpiarControles();
                btCargaproducto.Enabled = true;
                btModificar.Enabled = false;
            }

        }
        #endregion

        #region Metodos

        private void LimpiarControles()
        {
            txtCantidad.Text = "";
            txtPCompra.Text = "";
            txtProducto.Text = "";
            txtPVenta.Text = "";
            txtID.Text = "";

        }
        //Metodo para reemplazar string a entero en el porcentaje de ganancia
        private void Ganancia()
        {
            if (txtPVenta.Text == "10%")
            {
                cargadatos.PrecVenta = (10);
            }
            if (txtPVenta.Text == "20%")
            {
                cargadatos.PrecVenta = (20);
            }
            if (txtPVenta.Text == "30%")
            {
                cargadatos.PrecVenta = (30);
            }
            if (txtPVenta.Text == "40%")
            {
                cargadatos.PrecVenta = (40);
            }
            if (txtPVenta.Text == "50%")
            {
                cargadatos.PrecVenta = (50);
            }
            if (txtPVenta.Text == "60%")
            {
                cargadatos.PrecVenta = (60);
            }
            if (txtPVenta.Text == "70%")
            {
                cargadatos.PrecVenta = (70);
            }
            if (txtPVenta.Text == "80%")
            {
                cargadatos.PrecVenta = (80);
            }
            if (txtPVenta.Text == "90%")
            {
                cargadatos.PrecVenta = (90);
            }
            if (txtPVenta.Text == "100%")
            {
                cargadatos.PrecVenta = (100);
            }
        }

        

        private void error()
        {
            DGV["ID", posicion].Value.ToString();
            DGV["Producto", posicion].Value.ToString();
            DGV["Cantidad", posicion].Value.ToString();
            DGV["Precio de compra", posicion].Value.ToString();
            DGV["Porcentaje de ganancia", posicion].Value.ToString();
        }





        #endregion

        
    }
}
