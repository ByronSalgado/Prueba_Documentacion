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

       // SqlConnection conex = new SqlConnection(@"Data Source=DESKTOP-O9EIBG3\SQLEXPRESS;Initial Catalog=A.Beltran.Copiadora;Integrated Security=True");
        public Bodega()
        {
            InitializeComponent();
                               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            link lk = new link();

            lk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoModificacionProducto In = new IngresoModificacionProducto();

            In.Show();
            this.Close();
            In.button1.Visible = true;
            In.button3.Visible = false;
            In.Visible = true;
        }

        private void Bodega_Load(object sender, EventArgs e)
        {
            
            try
            {


                radioButton1.Checked = true;

                SqlCommand cmd = conex.CONECTARSQL.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (radioButton1.Checked == true)
                {
                    cmd.CommandText = "select * from [dbo].[View_2] ";  
                    for(int i=0; i<11; i++)
                    {
                        comboBox1.Items.Clear();
                    }                
                    comboBox1.Visible = false;
                    textBox1.Visible = false;
                    button2.Visible = false;
                    button1.Visible = false;

                }
                else
                {
                    cmd.CommandText = "select * from [dbo].[View_1] ";
                    

                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conex.CONECTARSQL.Close();
                //conex.Close();
                comboBox1.SelectedIndex = 1;
            }
            catch
            { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                //conex.Open();

                SqlCommand cmd = conex.CONECTARSQL.CreateCommand();
                //SqlCommand cmd = conex.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (radioButton1.Checked == true)
                {
                    
                    cmd.CommandText = "select * from [dbo].[View_2] ";
                    for (int i = 0; i < 11; i++)
                    {
                        comboBox1.Items.Clear();
                    }
                    comboBox1.Visible = false;
                    textBox1.Visible = false;
                    button2.Visible = false;
                    button1.Visible = false;
                }
                else
                {
                    cmd.CommandText = "select * from [dbo].[View_1] ";
                    
                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conex.CONECTARSQL.Close();
                //conex.Close();
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
                //conex.Open();

                SqlCommand cmd = conex.CONECTARSQL.CreateCommand();
                //SqlCommand cmd = conex.CreateCommand();

                cmd.CommandType = CommandType.Text;

                if (radioButton2.Checked == true)
                {
                                    
                    cmd.CommandText = "select * from [dbo].[View_1] ";
                    comboBox1.Items.Add("Codigo");
                    comboBox1.Items.Add("Nombre");
                    comboBox1.Items.Add("Descripcion");
                    comboBox1.Items.Add("Categoria");
                    comboBox1.Items.Add("Precio");//
                    comboBox1.Items.Add("Estado");
                    comboBox1.Items.Add("Cantidad");
                    comboBox1.Items.Add("Codigo de Barra");                   
                    comboBox1.Items.Add("Numero de Serie");
                    comboBox1.SelectedIndex = 0;
                    comboBox1.Visible = true;
                    textBox1.Visible = true;
                    button2.Visible = true;
                    button1.Visible = true;
                }
                else
                {
                   
                    cmd.CommandText = "select * from [dbo].[View_2] ";

                    for (int i = 0; i < 11; i++)
                    {
                        comboBox1.Items.Clear();
                    }
                    comboBox1.Visible = false;
                    textBox1.Visible = false;
                    button2.Visible = false;
                    button1.Visible = false;

                }

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conex.CONECTARSQL.Close();
                //conex.Close();
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
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Falta llenar ciertos campos", "Mensaje");
                }
                else
                {
                    //conex.Open();

                    SqlCommand cmd = conex.CONECTARSQL.CreateCommand();
                    //SqlCommand cmd = conex.CreateCommand();

                    cmd.CommandType = CommandType.Text;

                    if (radioButton1.Checked == true)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where ID_Producto like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 1)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Nombre_Producto like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 2)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Descripcion_Producto like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 3)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Categoria like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 4)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Precio like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 5)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Estado like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 6)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where Cantidad like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 7)
                        {
                            cmd.CommandText = "select * from [dbo].[View_2] where .Codigo_Barra like '%" + textBox1.Text.Trim() + "%'";
                        }
                    }

                    //////////////////////////////////////////////////////////////


                    if (radioButton2.Checked == true)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where ID_Producto like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 1)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Nombre_Producto like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 2)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Descripcion_Producto like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 3)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Nombre_Categoria like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 4)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Precio like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 5)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Descripcion_Estado like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 6)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Cantidad like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 7)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Codigo_Barra like '%" + textBox1.Text.Trim() + "%'";
                        }
                        else
                        if (comboBox1.SelectedIndex == 8)
                        {
                            cmd.CommandText = "select * from [dbo].[View_1] where Serie like '%" + textBox1.Text.Trim() + "%'";
                        }
                    }
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    conex.CONECTARSQL.Close();
                    //conex.Close();
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

                modificar.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                modificar.txtCodigo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                modificar.txtNomProducto.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                modificar.txtDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                modificar.txtCantidad.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                modificar.txtPrecio.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                modificar.txtNum.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                modificar.Show();
                modificar.button1.Visible = false;
                modificar.button3.Visible = true;
                modificar.Visible = true;
                Visible = false;
                modificar.comboBox2.Visible = true;
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
            if (textBox1.Text.Trim() == String.Empty)
            {
                epError.SetError(textBox1, "No se permiten campos vacíos");
                textBox1.Text = "";
            }


            else
                epError.SetError(textBox1, "");
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
            textBox1.MaxLength = 10;
        }
    }
}
