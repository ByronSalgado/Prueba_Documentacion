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
    public partial class FormGerente : Form
    {
        Conexion conex = new Conexion();
        public FormGerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            link lk = new link();

            lk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void FormGerente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet16.View_3' Puede moverla o quitarla según sea necesario.
            this.view_3TableAdapter1.Fill(this._A_Beltran_CopiadoraDataSet16.View_3);
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet8.View_4' Puede moverla o quitarla según sea necesario.
            this.view_4TableAdapter.Fill(this._A_Beltran_CopiadoraDataSet8.View_4);
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet1.View_3' Puede moverla o quitarla según sea necesario.
            this.view_3TableAdapter.Fill(this._A_Beltran_CopiadoraDataSet1.View_3);
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this._A_Beltran_CopiadoraDataSet.Usuario);
            

            rdb_ID.Checked = true;
        }

       
        

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rdb_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ID.Checked == true)
            {
                label1.Visible = true;
                label1.Text = "ID Usuario";
            }
        }

        private void rdb_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Nombre.Checked == true)
            {
                label1.Visible = true;
                label1.Text = "Nombre Usuario";
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Fill(this._A_Beltran_CopiadoraDataSet.Usuario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexion conex = new Conexion();
            SqlCommand cmd = conex.CONECTARSQL.CreateCommand();
            
            cmd.CommandType = CommandType.Text;

            if (rdb_ID.Checked == true)
            {
                cmd.CommandText = "SELECT A.ID_Usuario, A.Usuario, A.Nombre_Usuario, A.Identificacion_Usuario, A.Telefono, A.Direccion, A.Correo, A.Sexo, C.Descripcion_Rol, B.Descripcion_Estado FROM dbo.Usuario AS A INNER JOIN dbo.Estado AS B ON A.ID_Estado = B.ID_Estado INNER JOIN dbo.Roles AS C ON A.ID_Roles = C.ID_Roles WHERE A.ID_Usuario like ('%" + txtfiltro.Text + "%') GROUP BY A.ID_Usuario, A.Usuario, A.Nombre_Usuario, A.Identificacion_Usuario, A.Telefono, A.Direccion, A.Correo, A.Sexo, C.Descripcion_Rol, B.Descripcion_Estado";
                //select* from[dbo].[Usuario]
            }
            else
            {
                cmd.CommandText = "SELECT A.ID_Usuario, A.Usuario, A.Nombre_Usuario, A.Identificacion_Usuario, A.Telefono, A.Direccion, A.Correo, A.Sexo, C.Descripcion_Rol, B.Descripcion_Estado FROM dbo.Usuario AS A INNER JOIN dbo.Estado AS B ON A.ID_Estado = B.ID_Estado INNER JOIN dbo.Roles AS C ON A.ID_Roles = C.ID_Roles WHERE A.Nombre_Usuario like ('%" + txtfiltro.Text + "%') GROUP BY A.ID_Usuario, A.Usuario, A.Nombre_Usuario, A.Identificacion_Usuario, A.Telefono, A.Direccion, A.Correo, A.Sexo, C.Descripcion_Rol, B.Descripcion_Estado";
                //select * from [dbo].[Usuario] 
            }

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conex.CONECTARSQL.Close();
        }

        private void txtfiltro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevo = new NuevoUsuario();
            this.Close();
            nuevo.Show();
          
        }

        private void txtfiltro_Validating(object sender, CancelEventArgs e)
        {
            if (txtfiltro.Text.Trim() == String.Empty)
            {
                epErrorBusqueda.SetError(txtfiltro, "No se permiten campos vacíos");
                txtfiltro.Text = "";
            }


            else
                epErrorBusqueda.SetError(txtfiltro, "");
        }
        /***************************************************************************Caja*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conex.CONECTARSQL.CreateCommand();

            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "SELECT * FROM dbo.Arqueo As A inner join [dbo].[Estado] As B on A.ID_Estado = b.ID_Estado WHERE ([Fecha_Final] = CONVERT(DATE, '" + dateTimePicker1.Text + "'))  ";



            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {


            Conexion abrir = new Conexion();

            if (abrir.validarFecha() < 0)
            {

                abrir.abrirCaja(txtMontoInicial);


                FormGerente Actualizar = new FormGerente();
                Actualizar.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Ya abrio caja este dia");

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Conexion cerrar = new Conexion();
            if (cerrar.validarCerrarCaja() < 0)
            {

                Conexion con = new Conexion();
                DateTime fecha;
                fecha = DateTime.Today;
                con.CerrarCaja(fecha, txtMontoFinal);
                FormGerente Actualizar = new FormGerente();
                Actualizar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ya Cerro Caja Este Dia");

            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            NuevoUsuario ModificarUser = new NuevoUsuario();

            try
            {
                ModificarUser.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                ModificarUser.txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                ModificarUser.txtIdentidad.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                ModificarUser.txtTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                ModificarUser.txtDireccion.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                ModificarUser.txtCorreo.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
               
                
                string seleccion;
                seleccion = Convert.ToString(dataGridView1.SelectedRows);

                if (seleccion == Convert.ToString(dataGridView1.SelectedRows))
                {
                    ModificarUser.Show();
                    ModificarUser.Visible = true;
                    ModificarUser.txtContraseña.Visible = false;
                    ModificarUser.txtVerificar.Visible = false;
                    ModificarUser.txtUsuario.Visible = false;
                    ModificarUser.btnAgregar.Visible = false;
                    ModificarUser.cbRol.Visible = false;
                    ModificarUser.label3.Visible = false;
                    ModificarUser.label4.Visible = false;
                    ModificarUser.label6.Visible = false;
                    ModificarUser.label7.Visible = false;
                    ModificarUser.button2.Visible = true;
                    this.Hide();
                }

            }
            catch
            {



            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMontoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtMontoFinal_TextChanged(object sender, EventArgs e)
        {
            txtMontoFinal.MaxLength = 7;
        }

        private void txtMontoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtMontoInicial_TextChanged(object sender, EventArgs e)
        {
            txtMontoInicial.MaxLength = 7;
        }

        private void txtMontoInicial_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtMontoFinal_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
