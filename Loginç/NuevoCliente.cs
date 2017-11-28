using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Loginç
{
    public partial class NuevoCliente : Form
    {
        Conexion cnx = new Conexion();
        public NuevoCliente()
        {
            InitializeComponent();
            cnx.obtenerTipoIdentidad(cbTipoIden);
        }

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


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTelefono.Text) | String.IsNullOrEmpty(txtIdentidad.Text) | String.IsNullOrEmpty(txtCorreo.Text) | String.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Datos Vacios");
            }
            else
            {
                if (cnx.validarClienteExistente(txtTelefono.Text) < 0)
                {

                    cnx.nuevoCliente((cbTipoIden.SelectedIndex + 1)/*Pasar a +1*/, txtTelefono, txtIdentidad, txtNombreCliente, txtDireccion, txtCorreo);
                    MessageBox.Show("Se Ingresaron los datos");
                }
                else
                {
                    MessageBox.Show("Cliente ya existe");
                }

            }
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            cbTipoIden.SelectedIndex = 0;
        }

        private void txtCorreo_Leave_1(object sender, EventArgs e)
        {
            if (validarEmail(txtCorreo.Text))
            {

            }
            else
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text.Trim() == String.Empty)
            {
                epError.SetError(txtCorreo, "No se permiten campos vacíos");
                txtCorreo.Text = "";
            }


            else
                epError.SetError(txtCorreo, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cajero cjr = new Cajero();

            cjr.Show();
            this.Close();
        }

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {
            txtIdentidad.MaxLength = 12;
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            txtNombreCliente.MaxLength = 30;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 12;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.MaxLength = 50;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            txtCorreo.MaxLength = 20;
        }

        private void txtRTN_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
