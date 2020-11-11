using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.IO;

namespace carga_y_venta_de_producto
{
    public partial class frmVenta : Form
    {
        #region Propiedades

        DataTable venta = new DataTable();
        DataTable final = new DataTable();
        Carga cargadatos = new Carga();
        frmMain formulario = new frmMain();
        SaveFileDialog guardar = new SaveFileDialog();

        int posicion, posicion2, posicion3;
        public string ganancia;
        public string PrecCompra;
        public string URL;
        public decimal resta, resta2;
        decimal TotalPV;
        public decimal comp1, comp2, comp3, comp4;
        public bool Finalizar, iniciar = false;
        #endregion

        #region Constructor
        public frmVenta()
        {
            
            InitializeComponent();
            btCargaproducto.Enabled = false;
            
        }
        #endregion

        #region Eventos
        private void btSalirVenta_Click(object sender, EventArgs e)
        {
            if (btFinalizar.Enabled == true)
            {
                MessageBox.Show("Debe finalizar la venta antes de salir", "Advertencia");
                
            }
            else
            {
                this.Close();
            }
            
            
        }
        //Evento click del datagirdview de stock 
        private void DGVstock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Finalizar == true && iniciar == false)
            {
                MessageBox.Show("Debe iniciar una venta para seleccionar productos", "Error");
                LimpiarControles();
                
            }
            else
            {
                btCargaproducto.Enabled = true;
            }
            
            System.Convert.ToString(PrecCompra);
            System.Convert.ToString(txtCantidad.Text);
            posicion = DGVstock.CurrentRow.Index;
            txtCantidad.Text = DGVstock["Cantidad", posicion].Value.ToString();
            txtID.Text = DGVstock["ID", posicion].Value.ToString();
            txtProdVenta.Text = DGVstock["Producto", posicion].Value.ToString();
            ganancia = DGVstock["Porcentaje de ganancia", posicion].Value.ToString();
            PrecCompra = DGVstock["Precio de compra", posicion].Value.ToString();
            Ganancia();
            btModVenta.Enabled = false;
            if (txtCantidad.Text == "0" || txtCantidad.Text == "")
            {
                LimpiarControles();
                MessageBox.Show("El producto seleccionado no tiene stock", "Error de carga");

            }
            posicion2 = posicion;
            

        }

        private void btCargaproducto_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe agregar cantidad", "Error de cantidad");
            }
            else
            {
                resta = System.Convert.ToDecimal(DGVstock["Cantidad", posicion].Value.ToString());
                if (resta >= System.Convert.ToDecimal(txtCantidad.Text))
                {
                    cargadatos.PrecCompra = Convert.ToDecimal(PrecCompra);
                    cargadatos.Cantidad = System.Convert.ToDecimal(txtCantidad.Text);
                    Total();
                    final.Rows.Add();
                    final.Rows[final.Rows.Count - 1]["ID"] = System.Convert.ToString(txtID.Text);
                    final.Rows[final.Rows.Count - 1]["Producto"] = System.Convert.ToString(txtProdVenta.Text);
                    final.Rows[final.Rows.Count - 1]["Cantidad"] = System.Convert.ToString(txtCantidad.Text);
                    final.Rows[final.Rows.Count - 1]["Total"] = System.Convert.ToString(cargadatos.PrecVenta);
                    DGVstock["Cantidad", posicion].Value = resta - cargadatos.Cantidad;
                    TotalFinal();
                    LimpiarControles();
                    
                    cargadatos.GananciaObt();
                    cargadatos.Guardartxt();
                    GuardadoAutomatico();
                }
                else
                {
                    MessageBox.Show("No puede cargar una cantidad mayor a la que dispone", "Error de carga");
                    LimpiarControles();
                }
            }
            
            

            

        }
        private void btNuevoVenta_Click(object sender, EventArgs e)
        {
            HabilitarBt();
            cargadatos.cargartxt();
            cargadatos.CargarContador();
            //Inicializacion de los datagridview y carga de xml 
            if (Finalizar == false)
            {
                paVentaProd.Enabled = true;
                txtProdVenta.Enabled = false;
                txtID.Enabled = false;
                final.TableName = "FINAL";
                final.Columns.Add("ID", typeof(string));
                final.Columns.Add("Producto", typeof(string));
                final.Columns.Add("Cantidad", typeof(int));
                final.Columns.Add("Total", typeof(decimal));

                DGVventa.DataSource = final;


                venta.TableName = "Stock";
                venta.Columns.Add("ID", typeof(string));
                venta.Columns.Add("Producto", typeof(string));
                venta.Columns.Add("Cantidad", typeof(int));
                venta.Columns.Add("Precio de compra", typeof(decimal));
                venta.Columns.Add("Total", typeof(decimal));
                venta.Columns.Add("Porcentaje de ganancia", typeof(string));
                venta.Columns.Add("Ganancia total", typeof(decimal));
                DGVstock.DataSource = venta;
                
                venta.ReadXml(@"lista.xml");
            }
            
            LimpiarControles();
            txtBruto.Text = "";
            txtIva.Text = "";
            txtTotalVenta.Text = "";
            Finalizar = false;
            iniciar = true;
            btNuevoVenta.Enabled = false;
        }
        private void DGVventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = DGVventa.CurrentRow.Index;
            txtID.Text = DGVventa["ID", posicion].Value.ToString();
            txtProdVenta.Text = DGVventa["Producto", posicion].Value.ToString();
            txtCantidad.Text = DGVventa["Cantidad", posicion].Value.ToString();
            btCargaproducto.Enabled = false;
            btModVenta.Enabled = true;
        }
        private void btModVenta_Click(object sender, EventArgs e)
        {
            Comparar();
            
            btCargaproducto.Enabled = true;
            btModVenta.Enabled = false;
            LimpiarControles();
            GuardadoAutomatico();
        }
        private void btFinalizar_Click(object sender, EventArgs e)
        {
            GenerarTicket();
            final.Rows.Clear();
            LimpiarControles();
            Finalizar = true;
            btNuevoVenta.Enabled = true;
            btFinalizar.Enabled = false;
            btModVenta.Enabled = false;
            btCargaproducto.Enabled = false;
            DGVventa.Enabled = false;

            
            cargadatos.ContadorVenta();
            iniciar = false;
            

           
            
            //todo: crear txt en forma de ticket
        }
        private void txtBuscarVenta_TextChanged(object sender, EventArgs e)
        {
            BindingSource buscar = new BindingSource();
            buscar.DataSource = DGVstock.DataSource;
            buscar.Filter = "Producto like '%" + txtBuscarVenta.Text + "%'";
            DGVstock.DataSource = buscar;
        }
        #endregion

        #region Metodos
        public void GenerarTicket()
        {
            guardar.FileName = "Ticket";
            guardar.DefaultExt = ".txt";
            guardar.Filter = "Text documents (.txt)|*.txt";
            if (guardar.ShowDialog() == DialogResult.OK )
            {
                
                posicion3 = 0;
                TextWriter Ticket = new StreamWriter(guardar.FileName);
                Ticket.WriteLine("Producto--Cantidad--Subtotal");
                for (int i = 0; i < DGVventa.Rows.Count - 1; i++)
                {

                    Ticket.WriteLine(DGVventa["Producto", posicion3].Value.ToString()
                                    + "--" + DGVventa["Cantidad", posicion3].Value.ToString()
                                    + "--" + DGVventa["Total", posicion3].Value.ToString());

                    posicion3 = posicion3 + 1;
                }
                Ticket.WriteLine("\r\n" +"IVA:    " + txtIva.Text + "\r\n"
                                   + "Bruto:  " + txtBruto.Text + "\r\n"
                                   + "Total:  " + txtTotalVenta.Text);
                Ticket.Flush();
                Ticket.Close();
                Ticket = null;
            }
            
        }

        private void HabilitarBt()
        {
            btCargaproducto.Enabled = true;
            btModVenta.Enabled = true;
            btFinalizar.Enabled = true;
        }
        private void Comparar()
        {
            comp1 = System.Convert.ToDecimal(DGVventa["Cantidad", posicion].Value.ToString());
            comp2 = System.Convert.ToDecimal(txtCantidad.Text);

            comp3 = comp1 - comp2;
            if (comp2 > comp1)
            {
                MessageBox.Show("No puede agregar mas cantidad de la que ingreso", "Error de modificacion");
            }
            else
            {
                DGVventa["Cantidad", posicion].Value = txtCantidad.Text;
                DGVstock["Cantidad", posicion2].Value = comp3 + System.Convert.ToDecimal(DGVstock["Cantidad", posicion2].Value);
            }
        }
        private void GuardadoAutomatico()
        {
            venta.WriteXml(@"lista.xml");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Total()
        {
            cargadatos.TotalIndividual();
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
                cargadatos.Ganancia = 20;
            }
            if (ganancia == "30%")
            {
                cargadatos.Ganancia = 30;
            }
            if (ganancia == "40%")
            {
                cargadatos.Ganancia = 40;
            }
            if (ganancia == "50%")
            {
                cargadatos.Ganancia = 50;
            }
            if (ganancia == "60%")
            {
                cargadatos.Ganancia = 60;
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

        private void TotalFinal()
        {
            TotalPV = cargadatos.PrecVenta + TotalPV;

            txtTotalVenta.Text = System.Convert.ToString(TotalPV);
            System.Convert.ToDecimal(TotalPV);
            cargadatos.Total = TotalPV;
            cargadatos.IvaBruto();
            txtBruto.Text = System.Convert.ToString(cargadatos.Bruto);
            txtIva.Text = System.Convert.ToString(cargadatos.IVA);

        }

        #endregion

        

        
        
    }
}
