using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Loginç
{
    public partial class Facturar : Form
    {
        Conexion cnx = new Conexion();
        DataTable table = new DataTable();
        double precioBorrar;
        double impBorrar;
        double acum = 0;
        double imp = 0;
        double total = 0;
        public Facturar()
        {
            InitializeComponent();
        }  
        private void Facturar_Load(object sender, EventArgs e)
        {
            dgvInventario.ForeColor = Color.Black;
            dgvCarrito.ForeColor = Color.Black;
            this.proTableAdapter1.Fill(this._A_Beltran_CopiadoraDataSet15.Pro);
            this.detalleTableAdapter.Fill(this._A_Beltran_CopiadoraDataSet14.detalle);
            this.proTableAdapter.Fill(this._A_Beltran_CopiadoraDataSet13.Pro);

            table.Columns.Add("Nombre Producto", typeof(string));
            table.Columns.Add("Precio Unitario", typeof(string));
            table.Columns.Add("Precio Total", typeof(string));
            table.Columns.Add("Cantidad", typeof(string));

            dgvCarrito.DataSource = table;
            cnx.IDCai(txtCAI);
            cnx.IDArqueo(txtArqueo);
            cnx.IDUsuario(txtUser);
        }

        private void txtID_CLIENTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNomP.Text = dgvInventario.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPrecio.Text = dgvInventario.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtn1.Text = dgvInventario.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCant.Focus();

            }
            catch
            {

            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (total <= 0)
            {
                MessageBox.Show("Error Ingrese no se genero Factura");
            }
            else
            {
                cnx.nuevaFactura(txtId_Cliente, txtUser, txtArqueo, txtCAI);
                cnx.obtenerIdFactura(txtidFactura);
                int numeroDeFilas, contadorDeFilas;
                int numeroColumnas, contadorColumnas;
                numeroColumnas = dgvCarrito.Rows[0].Cells.Count;
                numeroDeFilas = dgvCarrito.Rows.Count;
                String nombreProducto;

                for (contadorDeFilas = 0; contadorDeFilas < numeroDeFilas; contadorDeFilas++)
                {
                    for (contadorColumnas = 0; contadorColumnas < numeroColumnas; contadorColumnas++)
                    {
                        dgvCarrito.Rows[contadorDeFilas].Cells[contadorColumnas].Value.ToString();
                        nombreProducto = dgvCarrito.Rows[contadorDeFilas].Cells[0].Value.ToString();

                        cnx.obtenerDetalleProducto(nombreProducto, txtInventrioSerie, txtidProducto, txtprecioUni);

                        if (contadorColumnas == 3)
                        {
                            cnx.insertarDetalleFactura(Convert.ToInt32(txtInventrioSerie.Text), Convert.ToInt32(txtidProducto.Text), Convert.ToInt32(txtidFactura.Text), Convert.ToInt32(dgvCarrito.Rows[contadorDeFilas].Cells[contadorColumnas].Value.ToString()), Convert.ToDouble(txtprecioUni.Text));
                        }
                    }

                }

                string msj;

                msj = string.Concat("A.Beltran.Copiadora\n" + "SubTotal: " + acum + "\n" + "Impuesto: " + imp + "\n" + "Total a Pagar: " + total);
                MessageBox.Show(msj, "Factura");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            precioBorrar = 0;
            impBorrar = 0;
            txtCant.Text.Trim();
            int cant;

            if (String.IsNullOrEmpty(txtCant.Text) || Convert.ToInt32(txtCant.Text) <= 0)
            {
                MessageBox.Show("Error Ingrese Cantidad");
                txtCant.Clear();
                txtCant.Focus();


            }
            else
             if (txtNomP.Text == "" && txtPrecio.Text == "" && txtn1.Text == "")
            {
                MessageBox.Show("Error Seleccione un Producto");
                try
                {
                    if (Convert.ToInt32(txtCant.Text) > Convert.ToInt32(txtn1.Text))
                    {
                        MessageBox.Show("Error Cantidad Insuficiente");
                    }
                }
                catch
                {

                }
                
            }      
            else
            {
                int numeroDeCeldas, contadorDeCeldas;
                numeroDeCeldas = dgvCarrito.Rows.Count;
                bool exist;
                exist = dgvCarrito.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Nombre Producto"].Value) == txtNomP.Text);
                if (!exist)
                {
                    cant = Convert.ToInt32(txtCant.Text) * Convert.ToInt32(txtPrecio.Text);
                    txtn2.Text = Convert.ToString(cant);
                    table.Rows.Add(txtNomP.Text, txtPrecio.Text, txtn2.Text, txtCant.Text);
                    dgvCarrito.DataSource = table;
                    txtCant.Clear();
                    acum = acum + Convert.ToDouble(txtn2.Text);
                    txtSubT.Text = Convert.ToString(acum);
                    imp = acum * 0.15d;
                    txtImp.Text = Convert.ToString(imp);
                    total = acum + imp;
                    txtTotal.Text = Convert.ToString(total);
                }
                else
                {

                    for (contadorDeCeldas = 0; contadorDeCeldas <= numeroDeCeldas; contadorDeCeldas++)
                    {
                        int celdaParaActualizar;
                        String nomp;
                        nomp = dgvCarrito.Rows[contadorDeCeldas].Cells[0].Value.ToString();
                        celdaParaActualizar = contadorDeCeldas;
                        if (txtNomP.Text == nomp)
                        {
                            dgvCarrito[0, celdaParaActualizar].Value = txtNomP.Text;
                            dgvCarrito[1, celdaParaActualizar].Value = txtPrecio.Text;
                            dgvCarrito[2, celdaParaActualizar].Value = txtn2.Text;
                            dgvCarrito[3, celdaParaActualizar].Value = txtCant.Text;

                            contadorDeCeldas = numeroDeCeldas;

                        }
                  
                    }

                    cant = Convert.ToInt32(txtCant.Text) * Convert.ToInt32(txtPrecio.Text);
                    txtn2.Text = Convert.ToString(cant);
                    txtCant.Clear();
                    acum = acum + Convert.ToDouble(txtn2.Text);
                    txtSubT.Text = Convert.ToString(acum);
                    imp = acum * 0.15d;
                    txtImp.Text = Convert.ToString(imp);
                    total = acum + imp;
                    txtTotal.Text = Convert.ToString(total);

                    MessageBox.Show("Dato Existe");

                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Cajero cjr = new Cajero();
            cjr.Show();
            this.Hide();
            
        }

        private void txtCant_TextChanged(object sender, EventArgs e)
        {
            txtCant.MaxLength = 6;
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if(char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomP_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtCant_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtNomP_TextChanged(object sender, EventArgs e)
        {
            txtNomP.MaxLength = 30;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.MaxLength = 7;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentRow.Index);
            if (table.Rows.Count == 0)
            {
                txtn3.Text = "0";
            }
                acum = acum - precioBorrar;
                imp = imp - impBorrar;
                total = total - (precioBorrar + impBorrar);
                txtSubT.Text = Convert.ToString(acum);
                txtImp.Text = Convert.ToString(imp);
                txtTotal.Text = Convert.ToString(total);
        
        }

        private void Facturar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.Rows.Count <= 1)
            {
                txtn3.Text = dgvInventario.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            txtn3.Text = dgvInventario.Rows[e.RowIndex].Cells[2].Value.ToString();
            precioBorrar = Convert.ToDouble(txtn3.Text);
            impBorrar = precioBorrar * 0.15d;

        }

    }
}
