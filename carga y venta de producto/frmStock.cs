﻿using System;
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

namespace carga_y_venta_de_producto
{
    public partial class frmStock : Form
    {
        #region Propiedades
        Carga cargadatos = new Carga();
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
            //if (cargar.FileName != "")
            //{
            //    Stock.ReadXml(@"lista.xml");
            //}
            
            btNuevo.Enabled = false;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            
            Stock.WriteXml(@"lista.xml");
            
            btNuevo.Enabled = true;

            
        }

        private void btCargarStock_Click(object sender, EventArgs e)
        {
            Stock.Rows.Clear();
            Stock.ReadXml(@"lista.xml");
            //if (cargar.ShowDialog() == DialogResult.OK)
            //{
            //    Stock.ReadXml(cargar.FileName);
            //    DGV.DataSource = Stock;
            //}
        }
        private void btCargaproducto_Click(object sender, EventArgs e)
        {
            

            if (txtCantidad.Text == "" || txtPCompra.Text == "")
            {
                MessageBox.Show("Debe completar los campos de cantidad y precios con caracteres numericos", "Error en el formulario");
            }
            else
            {
                string preciodecompra;
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
            this.Close();
           
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
                GuardadoAutomatico();
            }
            
        }
        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }
        //Control para que el textbox no acepte letras
        private void txtPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            if (cargadatos.URL != null)
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
