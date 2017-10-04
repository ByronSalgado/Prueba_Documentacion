using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginç
{
    public partial class NuevaContraseñaUsuarios : Form
    {
        Conexion cone = new Conexion();
        public NuevaContraseñaUsuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuarioRecuContraseña.Text) | String.IsNullOrEmpty(txtContraseñaRecuContraseña.Text) | String.IsNullOrEmpty(txtReinContraseñaRecuContraseña.Text))
            {
                MessageBox.Show("USUARIO O CONTRASEÑA ESTAN VACIOS", "Mensaje");
                txtContraseñaRecuContraseña.Clear();
                txtReinContraseñaRecuContraseña.Clear();
            }
            else
            {
                if (txtContraseñaRecuContraseña.Text == txtReinContraseñaRecuContraseña.Text)
                {
                    if (cone.Autentificar(txtUsuarioRecuContraseña.Text) > 0)
                    {
                        Conexion cone = new Conexion();

                    cone.ingresarContraseña(txtReinContraseñaRecuContraseña.Text, txtUsuarioRecuContraseña.Text);
                        txtContraseñaRecuContraseña.Clear();
                        txtReinContraseñaRecuContraseña.Clear();
                        MessageBox.Show("SE HAN GUARDADO LOS CAMBIOS", "Msj");
                    link link = new link();
                    link.Show();
                    this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO NO CORRESPONDE AL DE LA BASE DE DATOS", "Mensaje");
                        txtContraseñaRecuContraseña.Clear();
                        txtReinContraseñaRecuContraseña.Clear();
                    }


                }
                else
                {
                    MessageBox.Show("LOS CAMPOS DE LAS CONTRASEÑAS NO SON IGUALES", "Msj");
                    txtContraseñaRecuContraseña.Clear();
                    txtReinContraseñaRecuContraseña.Clear();
                    txtUsuarioRecuContraseña.Clear();
                }
            }
        }

        private void txtUsuarioRecuContraseña_TextChanged(object sender, EventArgs e)
        {
            txtUsuarioRecuContraseña.MaxLength = 50;
            
      
        }

        private void txtContraseñaRecuContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseñaRecuContraseña.MaxLength = 50;
        }

        private void txtReinContraseñaRecuContraseña_TextChanged(object sender, EventArgs e)
        {
            txtReinContraseñaRecuContraseña.MaxLength = 50;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevaContraseñaUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
