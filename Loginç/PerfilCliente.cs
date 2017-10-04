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
    public partial class PerfilCliente : Form
    {
        Conexion con = new Conexion();
        public int num;
    
        
        public PerfilCliente()
        {
            InitializeComponent();
          
        }

        private void PerfilCliente_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet12.fact' Puede moverla o quitarla según sea necesario.
            this.factTableAdapter.Fill(this._A_Beltran_CopiadoraDataSet12.fact);

            //Facturar fact = new Facturar();
            //fact.txtID_CLIENTE.Text=


            num = Convert.ToInt32(txtID_CLIENTE.Text);

            SqlConnection conex = new SqlConnection(@"Data Source=DESKTOP-O9EIBG3\SQLEXPRESS; Initial Catalog = A.Beltran.Copiadora; Integrated Security = True;MultipleActiveResultSets=true;");

            conex.Open();

            SqlCommand cmd = conex.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT dbo.Arqueo.ID_Arqueo, dbo.Tipo_Pago.Descripcion_Tipo_Pago, dbo.Usuario.Usuario, dbo.CAI.ID_CAI,CONVERT(date, getdate()) 'Fecha' , dbo.Factura.Impuesto FROM dbo.Arqueo INNER JOIN dbo.Factura ON dbo.Arqueo.ID_Arqueo = dbo.Factura.ID_Arqueo INNER JOIN dbo.Tipo_Pago ON dbo.Factura.ID_Tipo_Pago = dbo.Tipo_Pago.ID_Tipo_Pago INNER JOIN dbo.Usuario ON dbo.Factura.ID_Usuario = dbo.Usuario.ID_Usuario CROSS JOIN dbo.CAI where dbo.Factura.ID_Cliente = '" + num + "'";
            // txtValidar.Text = "0";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conex.Close();

            
            
            



        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (con.validarFacturar() == false)
            {
                MessageBox.Show("Arqueo esta cerrado");
            }
            else
            {
                con.validarFacturar(txtEstadoArqueo);
                int numero = Convert.ToInt32(txtEstadoArqueo.Text);

                if (numero == 7)
                {
                    MessageBox.Show("El arqueo esta cerrado");
                }
                else
                {
                    if (numero == 6)
                    {
                        Facturar fac = new Facturar();
                        fac.txtId_Cliente.Text = txtID_CLIENTE.Text;
                        fac.Show();
                        this.Hide();
                    }
                   
                }
                    

            }

        }

        private void dataGridView1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtID_CLIENTE_TextChanged(object sender, EventArgs e)
        {
            txtID_CLIENTE.MaxLength = 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cajero cjr = new Cajero();

            cjr.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTelefono.Text) | String.IsNullOrEmpty(txtCorreo.Text) | String.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Algun Campo Esta Vacio", "Mensaje");
            }
            else
            {
                con.actualizar(txtTelefono.Text, txtCorreo.Text, txtDireccion.Text, txtID_CLIENTE.Text);
                Cajero cjr = new Cajero();
                cjr.Show();
                cjr.Visible = true;
                this.Close();
            }
        }

        private void txt_Identificacion_TextChanged(object sender, EventArgs e)
        {
            txt_Identificacion.MaxLength = 20;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 20;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 8;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.MaxLength = 30;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            txtCorreo.MaxLength = 15;
        }

        private void txtRTN_TextChanged(object sender, EventArgs e)
        {
            txtRTN.MaxLength = 12;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.MaxLength = 20;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validar.SoloNumeros(e);
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validar.SoloLetras(e);
         
        }
        ///////Validar Factura
        public void valiFac()
        {
            
        }
    }
}
