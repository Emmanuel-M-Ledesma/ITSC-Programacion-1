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
using System.Xml.Linq;
using BackEnd;

namespace carga_y_venta_de_producto
{
    public partial class frmStock : Form
    {
        #region Propiedades
        Cargar_y_guardar Persistencia = new Cargar_y_guardar();
        Sumador Sumar = new Sumador();
        DataTable Stock = new DataTable();
        frmMain DGVcarga = new frmMain();
        int posicion;
        public frmStock stockPanel;

        public string URL;
        
        
        public string link;
        #endregion

        #region Constructor
        public frmStock()
        {
            InitializeComponent();
            btCargarStock.Enabled = false;
            btGuardar.Enabled = false;
        }

        public frmStock(frmStock stockPanel)
        {
            this.stockPanel = stockPanel;
        }
        
        #endregion
        
        #region Eventos
        private void btNuevo_Click(object sender, EventArgs e)
        {

            Stock.Rows.Clear();
            btCargarStock.Enabled = true;
            btGuardar.Enabled = true;
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
            //Aqui se guarda el xml del stock principal
            Stock.WriteXml(@"lista.xml");
            
            btNuevo.Enabled = true;

            
        }

        private void btCargarStock_Click(object sender, EventArgs e)
        {
            Stock.Rows.Clear();
            Stock.ReadXml(@"lista.xml");
            
        }
        private void btCargaproducto_Click(object sender, EventArgs e)
        {
            //Boton para agregar productos

            if (txtCantidad.Text == "" || txtPCompra.Text == "" || txtPVenta.Text == "")
            {
                MessageBox.Show("Debe completar los campos de cantidad y precios con caracteres numericos", "Error en el formulario");
            }
            else
            {
                
                Sumar.Cantidad = System.Convert.ToDecimal(txtCantidad.Text);
                Sumar.PrecCompra = System.Convert.ToDecimal(txtPCompra.Text);
               
               
                Ganancia();
                Sumar.GananciaStock();

                Sumar.TotalStock();
                Stock.Rows.Add();
                Stock.Rows[Stock.Rows.Count - 1]["ID"] = txtID.Text;
                Stock.Rows[Stock.Rows.Count - 1]["Producto"] = txtProducto.Text;
                Stock.Rows[Stock.Rows.Count - 1]["Cantidad"] = System.Convert.ToDecimal(txtCantidad.Text);
                Stock.Rows[Stock.Rows.Count - 1]["Precio de compra"] = System.Convert.ToDecimal(txtPCompra.Text);
                Stock.Rows[Stock.Rows.Count - 1]["Total"] = Sumar.Total;
                Stock.Rows[Stock.Rows.Count - 1]["Porcentaje de ganancia"] = System.Convert.ToString(txtPVenta.Text);
                Stock.Rows[Stock.Rows.Count - 1]["Ganancia total"] = Sumar.Ganancia;
                LimpiarControles();
            }
            GuardadoAutomatico();
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
                GuardadoAutomatico();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Boton para cerrar el form de stock
            this.Close();
           
        }
        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento Cell click del datagridview de stock(se pasan los campos al textbox) 

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
            // Evento en el que se modificanlos datos del datagridview luego del evento cellclick

            if (txtCantidad.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("No se puede modificar una celda vacia", "Error al modificar");
            }
            else
            {
               
                Sumar.Cantidad = System.Convert.ToDecimal(txtCantidad.Text);
                Sumar.PrecCompra = System.Convert.ToDecimal(txtPCompra.Text);
                Ganancia();
                Sumar.GananciaStock();
                Sumar.TotalStock();

                DGV["ID", posicion].Value = txtID.Text;
                DGV["Producto", posicion].Value = txtProducto.Text;
                DGV["Cantidad", posicion].Value = System.Convert.ToDecimal(txtCantidad.Text);
                DGV["Precio de compra", posicion].Value = System.Convert.ToDecimal(txtPCompra.Text);
                DGV["Porcentaje de ganancia", posicion].Value = System.Convert.ToString(txtPVenta.Text);
                DGV["Total", posicion].Value = Sumar.Total;
                DGV["Ganancia total", posicion].Value = Sumar.Ganancia;
                LimpiarControles();
                btCargaproducto.Enabled = true;
                btModificar.Enabled = false;
                GuardadoAutomatico();
            }
            
        }
        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Control para que el textbox de cantidad solo acepte numeros

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }
        
        private void txtPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Control para que el textbox acepte decimal (al momento acepta, pero se pueden poner varias comas y causa error)

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            //if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            //{
            //    e.Handled = true;
            //}

        }
        #endregion

        #region Metodos
       
        private void GuardadoAutomatico()
        {
            if (Sumar.URL != null)
            {
                Stock.WriteXml(@"lista.xml");
            }
        }

        
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
                Sumar.PrecVenta = (10);
            }
            if (txtPVenta.Text == "20%")
            {
                Sumar.PrecVenta = (20);
            }
            if (txtPVenta.Text == "30%")
            {
                Sumar.PrecVenta = (30);
            }
            if (txtPVenta.Text == "40%")
            {
                Sumar.PrecVenta = (40);
            }
            if (txtPVenta.Text == "50%")
            {
                Sumar.PrecVenta = (50);
            }
            if (txtPVenta.Text == "60%")
            {
                Sumar.PrecVenta = (60);
            }
            if (txtPVenta.Text == "70%")
            {
                Sumar.PrecVenta = (70);
            }
            if (txtPVenta.Text == "80%")
            {
                Sumar.PrecVenta = (80);
            }
            if (txtPVenta.Text == "90%")
            {
                Sumar.PrecVenta = (90);
            }
            if (txtPVenta.Text == "100%")
            {
                Sumar.PrecVenta = (100);
            }
        }

        

        //private void error()
        //{
        //    DGV["ID", posicion].Value.ToString();
        //    DGV["Producto", posicion].Value.ToString();
        //    DGV["Cantidad", posicion].Value.ToString();
        //    DGV["Precio de compra", posicion].Value.ToString();
        //    DGV["Porcentaje de ganancia", posicion].Value.ToString();
        //}
        #endregion

        

        
    }
}
