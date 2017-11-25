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
    public partial class Cajero : Form
    {
        Conexion conex = new Conexion();
        public Cajero()
        {
            InitializeComponent();
        }

        private void Cajero_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet17.Cli' Puede moverla o quitarla según sea necesario.
            this.cliTableAdapter1.Fill(this._A_Beltran_CopiadoraDataSet17.Cli);
            //this.cliTableAdapter.Fill(this._A_Beltran_CopiadoraDataSet9.Cli);
            rdb_ID.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            link lk = new link();

            lk.Show();
            this.Hide();
        }

        private void rdb_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ID.Checked == true)
            {
                label1.Visible = true;
                label1.Text = "ID Usuario";
                txtfiltro.Clear();
                txtfiltro.Focus();
            }
        }

        private void rdb_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Nombre.Checked == true)
            {
                label1.Visible = true;
                label1.Text = "Nombre Usuario";
                txtfiltro.Clear();
                txtfiltro.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e, DataGridViewCellEventArgs c)
        {
            
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoCliente nuevoCliente = new NuevoCliente();
            nuevoCliente.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PerfilCliente fact = new PerfilCliente();

            try
            {

                fact.txtID_CLIENTE.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                fact.txt_Identificacion.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                fact.txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                fact.txtTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                fact.txtDireccion.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                fact.txtCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                fact.txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                string seleccion;
                seleccion = Convert.ToString(dataGridView1.SelectedRows);

                if (seleccion == Convert.ToString(dataGridView1.SelectedRows))
                {
                    fact.Show();
                    this.Hide();
                }

            }
            catch
            {

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            txtfiltro.MaxLength = 6;
        }

        private void txtfiltro_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfiltro.Text))
            {
                MessageBox.Show("Error Ingrese Datos al Filtro");
            }
            else
            {
                SqlCommand cmd = conex.CONECTARSQL.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (rdb_ID.Checked == true)
                {
                    cmd.CommandText = "SELECT dbo.Cliente.ID_Cliente, dbo.Cliente.Nombre_Cliente, dbo.Cliente.Telefono_Cliente, dbo.Cliente.Direccion_Cliente, dbo.Cliente.Correo_Cliente, dbo.Cliente.RTN, dbo.Estado.Descripcion_Estado FROM dbo.Cliente INNER JOIN dbo.Estado ON dbo.Cliente.ID_Estado = dbo.Estado.ID_Estado WHERE dbo.Cliente.ID_Cliente like ('%" + txtfiltro.Text + "%') GROUP BY dbo.Cliente.ID_Cliente, dbo.Cliente.Nombre_Cliente, dbo.Cliente.Telefono_Cliente, dbo.Cliente.Direccion_Cliente, dbo.Cliente.Correo_Cliente, dbo.Cliente.RTN, dbo.Estado.Descripcion_Estado;";
                }
                else
                {
                    cmd.CommandText = "SELECT dbo.Cliente.ID_Cliente, dbo.Cliente.Nombre_Cliente, dbo.Cliente.Telefono_Cliente, dbo.Cliente.Direccion_Cliente, dbo.Cliente.Correo_Cliente, dbo.Cliente.RTN, dbo.Estado.Descripcion_Estado FROM dbo.Cliente INNER JOIN dbo.Estado ON dbo.Cliente.ID_Estado = dbo.Estado.ID_Estado WHERE dbo.Cliente.Nombre_Cliente like ('%" + txtfiltro.Text + "%') GROUP BY dbo.Cliente.ID_Cliente, dbo.Cliente.Nombre_Cliente, dbo.Cliente.Telefono_Cliente, dbo.Cliente.Direccion_Cliente, dbo.Cliente.Correo_Cliente, dbo.Cliente.RTN, dbo.Estado.Descripcion_Estado;";
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }

        }

        private void txtfiltro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (rdb_ID.Checked == true)
            {
                Validar.SoloNumeros(e);
            }

            if (rdb_Nombre.Checked == true)
            {
                Validar.SoloLetras(e);
            }
        }

        private void Cajero_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

