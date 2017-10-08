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
using System.Text.RegularExpressions;

namespace Loginç
{
    public partial class NuevoUsuario : Form
    {
        Conexion cnx = new Conexion();
        
        public NuevoUsuario()
        {
            InitializeComponent();
            cnx.obtenerRoles(cbRol);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            string sexo = "";



            if (rbM.Checked == true)
            {
                sexo = "M";
            }
            else if (rbF.Checked == true)
            {
                sexo = "F";
            }

            

            if (String.IsNullOrEmpty(txtUsuario.Text) | String.IsNullOrEmpty(txtCorreo.Text) | String.IsNullOrEmpty(txtDireccion.Text) | String.IsNullOrEmpty(txtIdentidad.Text) | String.IsNullOrEmpty(txtContraseña.Text) | String.IsNullOrEmpty(txtTelefono.Text) | String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrEmpty(txtVerificar.Text))
            {
                MessageBox.Show("Falta llenar ciertos campos", "Mensaje");
            }
            else
            {
                if (txtContraseña.Text.Trim() != txtVerificar.Text.Trim())
                {
                    MessageBox.Show("Incorrecta");
                }
                else
                {
                    Conexion cnx = new Conexion();


                    if (cnx.validadUsuarioExistente(txtNombre.Text) > 0)
                    {
                        cnx.nuevoUsuario(txtNombre, txtUsuario, txtContraseña, txtIdentidad, (cbRol.SelectedIndex + 2), txtTelefono, txtDireccion, txtCorreo, sexo);
                        MessageBox.Show("Se Ingresaron los datos");

                    }
                    else
                    {
                        //   cbRol.SelectedIndex;
                        MessageBox.Show("Usuario ya existe");

                    }
                }

            }
        }

        private void txtIdentidad_TextChanged_1(object sender, EventArgs e)
        {
           
            txtIdentidad.MaxLength = 14;
        }

        private void txtTelefono_TextChanged_1(object sender, EventArgs e)
        {
         
            txtTelefono.MaxLength = 8;
        }

        private void txtDireccion_TextChanged_1(object sender, EventArgs e)
        {    
                  
            txtDireccion.MaxLength = 35;    
        }

        private void txtCorreo_TextChanged_1(object sender, EventArgs e)
        {
          
            txtCorreo.MaxLength = 35;
        }

        private void txtNombreUsuario_TextChanged_1(object sender, EventArgs e)
        {

            txtNombre.MaxLength = 30;
        }

        private void txtContrasenia_TextChanged_1(object sender, EventArgs e)
        {

            txtContraseña.MaxLength = 20;
        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

            txtUsuario.MaxLength = 20;
        }

        private void txtVerificar_TextChanged_1(object sender, EventArgs e)
        {

            txtVerificar.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGerente gernte = new FormGerente();
            gernte.Show();
            this.Close();
        }
 

        private void txtIdentidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
            Validar.SoloNumeros(e);
            Validar.Espacio(e);
         
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            Validar.Espacio(e);
            
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            cbRol.SelectedIndex = 0;
            rbM.Checked = true;
        }

        /**********************************Validaciones************************************************/
        public static bool validarEmail(string email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            { return false; }
        }
        private void txtIdentidad_KeyDown(object sender, KeyEventArgs e)
        {
            Validar.KeyDown(e);
        }

        private void txtIdentidad_MouseDown(object sender, MouseEventArgs e)
        {
            Validar.MouseDown(e);
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            Validar.KeyDown(e);
        }

        private void txtTelefono_MouseDown(object sender, MouseEventArgs e)
        {
            Validar.MouseDown(e);
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            Validar.KeyDown(e);
        }

        private void txtDireccion_MouseDown(object sender, MouseEventArgs e)
        {
            Validar.MouseDown(e);
        }

        private void txtCorreo_KeyDown(object sender, KeyEventArgs e)
        {
            Validar.KeyDown(e);
        }

        private void txtCorreo_MouseDown(object sender, MouseEventArgs e)
        {
            Validar.MouseDown(e);
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            Validar.KeyDown(e);
        }

        private void txtNombre_MouseDown(object sender, MouseEventArgs e)
        {
            Validar.MouseDown(e);
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            Validar.KeyDown(e);
        }

        private void txtUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            Validar.MouseDown(e);
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            Validar.KeyDown(e);
        }

        private void txtContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            Validar.MouseDown(e);
        }

        private void txtVerificar_KeyDown(object sender, KeyEventArgs e)
        {
            Validar.KeyDown(e);
        }

        private void txtVerificar_MouseDown(object sender, MouseEventArgs e)
        {
            Validar.MouseDown(e);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (validarEmail(txtCorreo.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de Correo no Valida, el correo debe tener el formato: nombre@dominio.com" +
                "\npor favor seleccione un correo valido", "validacion de correo electronico", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
                txtCorreo.Text = "";
               

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Espacio(e);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Espacio(e);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Espacio(e);
        }

        private void txtVerificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Espacio(e);
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDireccion.Text.Trim() == String.Empty)
            {
                epError.SetError(txtDireccion, "No se permiten campos vacíos");
                txtDireccion.Text = "";
            }
                

            else
                epError.SetError(txtDireccion, "");
                    
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text.Trim() == String.Empty)
            {
                epError.SetError(txtNombre, "No se permiten campos vacíos");
                txtNombre.Text = "";
            }


            else
                epError.SetError(txtNombre, "");
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtIdentidad_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtIdentidad.Text.Trim() == String.Empty)
            {
                epError.SetError(txtIdentidad, "No se permiten campos vacíos");
                txtIdentidad.Text = "";
            }


            else
                epError.SetError(txtIdentidad, "");
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text.Trim() == String.Empty)
            {
                epError.SetError(txtTelefono, "No se permiten campos vacíos");
                txtTelefono.Text = "";
            }


            else
                epError.SetError(txtTelefono, "");
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text.Trim() == String.Empty)
            {
                epError.SetError(txtCorreo, "No se permiten campos vacíos");
                txtCorreo.Text = "";
            }


            else
                epError.SetError(txtCorreo, "");
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Trim() == String.Empty)
            {
                epError.SetError(txtUsuario, "No se permiten campos vacíos");
                txtUsuario.Text = "";
            }


            else
                epError.SetError(txtUsuario, "");
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (txtContraseña.Text.Trim() == String.Empty)
            {
                epError.SetError(txtContraseña, "No se permiten campos vacíos");
                txtContraseña.Text = "";
            }


            else
                epError.SetError(txtContraseña, "");
        }

        private void txtVerificar_Validating(object sender, CancelEventArgs e)
        {
            if (txtVerificar.Text.Trim() == String.Empty)
            {
                epError.SetError(txtVerificar, "No se permiten campos vacíos");
                txtVerificar.Text = "";
            }


            else
                epError.SetError(txtVerificar, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) | String.IsNullOrEmpty(txtIdentidad.Text) | String.IsNullOrEmpty(txtTelefono.Text) | String.IsNullOrEmpty(txtDireccion.Text) | String.IsNullOrEmpty(txtCorreo.Text) | String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Algun Campo Esta Vacio", "Mensaje");
            }
            else
            {
                cnx.actualizar(txtNombre.Text, txtIdentidad.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text, textBox1.Text);
                FormGerente gerente = new FormGerente();
                gerente.Show();
                gerente.Visible = true;
                this.Hide();
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtCorreo.MaxLength = 50;
        }
    }
}
