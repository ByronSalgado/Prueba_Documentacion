using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Loginç
{
    public partial class Bodega : Form
    {
        Conexion conex = new Conexion();

        public Bodega()
        {
            InitializeComponent();
                               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            link lk = new link();

            lk.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoModificacionProducto In = new IngresoModificacionProducto();

            In.Show();
            this.Close();
            In.button1.Visible = true;
            In.btnModificar.Visible = false;
            In.Visible = true;
        }

        private void Bodega_Load(object sender, EventArgs e)
        {
            
            try
            {


                rbInventario.Checked = true;

                SqlCommand cmd = conex.CONECTARSQL.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (rbInventario.Checked == true)
                {
                    cmd.CommandText = "select * from [dbo].[View_2] ";  
                    cmbFiltro.Items.Clear();        
                    cmbFiltro.Visible = false;
                    txtBuscar.Visible = false;
                    btnBuscar.Visible = false;
                    btnNuevo.Visible = false;

                }
                else
                {
                    cmd.CommandText = "select * from [dbo].[View_1] ";
                    

                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dtgProductos.DataSource = dt;

                conex.CONECTARSQL.Close();
                cmbFiltro.SelectedIndex = 1;
            }
            catch
            { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {

                SqlCommand cmd = conex.CONECTARSQL.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (rbInventario.Checked == true)
                {
                    
                    cmd.CommandText = "select * from [dbo].[View_2] ";
                    cmbFiltro.Items.Clear();
                    cmbFiltro.Visible = false;
                    txtBuscar.Visible = false;
                    btnBuscar.Visible = false;
                    btnNuevo.Visible = false;
                    lbBuscar.Visible = false;
                    lbFiltro.Visible = false;
                }
                else
                {
                    cmd.CommandText = "select * from [dbo].[View_1] ";
                    
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dtgProductos.DataSource = dt;

                conex.CONECTARSQL.Close();
            }
            catch
            {

            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            try
            {
                conex.CONECTARSQL.Open();
                SqlCommand cmd = conex.CONECTARSQL.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (rbSerie.Checked == true)
                {
                                    
                    cmd.CommandText = "select * from [dbo].[View_1] ";
                    cmbFiltro.Items.Add("Codigo");
                    cmbFiltro.Items.Add("Nombre");
                    cmbFiltro.Items.Add("Descripcion");
                    cmbFiltro.Items.Add("Categoria");
                    cmbFiltro.Items.Add("Precio");
                    cmbFiltro.Items.Add("Estado");
                    cmbFiltro.Items.Add("Cantidad");
                    cmbFiltro.Items.Add("Codigo de Barra");                   
                    cmbFiltro.Items.Add("Numero de Serie");
                    cmbFiltro.SelectedIndex = 0;
                    cmbFiltro.Visible = true;
                    txtBuscar.Visible = true;
                    btnBuscar.Visible = true;
                    btnNuevo.Visible = true;
                    lbBuscar.Visible = true;
                    lbFiltro.Visible = true;
                }
                else
                {
                   
                    cmd.CommandText = "select * from [dbo].[View_2] ";
                    cmbFiltro.Items.Clear();
                    cmbFiltro.Visible = false;
                    txtBuscar.Visible = false;
                    btnBuscar.Visible = false;
                    btnNuevo.Visible = false;

                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dtgProductos.DataSource = dt;

                conex.CONECTARSQL.Close();
            }
            catch
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conex.CONECTARSQL.Open();
                if (String.IsNullOrEmpty(txtBuscar.Text))
                {
                    MessageBox.Show("Falta llenar ciertos campos", "Mensaje");
                }
                else
                {
                    SqlCommand cmd = conex.CONECTARSQL.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    if (rbInventario.Checked == true)
                    {
                        if (cmbFiltro.SelectedIndex == 0)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where ID_Producto like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 1)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Nombre_Producto like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 2)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Descripcion_Producto like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 3)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Categoria like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 4)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Precio like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 5)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Estado like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 6)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Cantidad like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 7)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where .Codigo_Barra like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                    }

                    //////////////////////////////////////////////////////////////

                    if (rbSerie.Checked == true)
                    {
                        if (cmbFiltro.SelectedIndex == 0)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where ID_Producto like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 1)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Nombre_Producto like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 2)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Descripcion_Producto like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 3)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Nombre_Categoria like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 4)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Precio like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 5)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Descripcion_Estado like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 6)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Cantidad like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 7)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Codigo_Barra like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                        else
                        if (cmbFiltro.SelectedIndex == 8)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Serie like '%" + txtBuscar.Text.Trim() + "%'";
                        }
                    }
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    dtgProductos.DataSource = dt;

                    conex.CONECTARSQL.Close();
                }
            }
            catch
            {

            }                                         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            IngresoModificacionProducto modificar = new IngresoModificacionProducto();

            try
            {

                modificar.txtCodigoProducto.Text = dtgProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                modificar.txtCodigo.Text = dtgProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                modificar.txtNomProducto.Text = dtgProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                modificar.txtDescripcion.Text = dtgProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                modificar.txtCantidad.Text = dtgProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                modificar.txtPrecio.Text = dtgProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                modificar.txtNum.Text = dtgProductos.Rows[e.RowIndex].Cells[7].Value.ToString();

                modificar.Show();
                modificar.button1.Visible = false;
                modificar.btnModificar.Visible = true;
                modificar.Visible = true;
                Visible = false;
                modificar.cmbEstado.Visible = true;
                modificar.label9.Visible = true;
            }
            catch
            {

            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                MessageBox.Show("No se puede utilizar el boton derecho" +
                  "", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (txtBuscar.Text.Trim() == String.Empty)
            {
                epError.SetError(txtBuscar, "No se permiten campos vacíos");
                txtBuscar.Text = "";
            }


            else
                epError.SetError(txtBuscar, "");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.MaxLength = 10;
        }
    }
}
