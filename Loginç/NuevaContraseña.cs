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
    public partial class NuevaContraseñaIngresaGerente : Form
    {
        Conexion cone = new Conexion();
        public NuevaContraseñaIngresaGerente()
        {
            InitializeComponent();
            cone.obtenerBloqueados(comboBox1);

            if(comboBox1.Items.Count == 0)
            {
                txtContraseñaRecuContraseña.Enabled = false;
                txtReinContraseñaRecuContraseña.Enabled=false;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (/*String.IsNullOrEmpty(txtUsuarioRecuContraseña.Text)*/String.IsNullOrEmpty(txtContraseñaRecuContraseña.Text) | String.IsNullOrEmpty(txtReinContraseñaRecuContraseña.Text))
            {
                MessageBox.Show("CAMPO O CAMPOS DE CONTRASEÑAS VACIOS", "Mensaje");
                txtUsuarioRecuContraseña.Clear();
                txtContraseñaRecuContraseña.Clear();
            }
            else
            {
                txtUsuarioRecuContraseña.Text = comboBox1.SelectedItem.ToString();
                if (txtContraseñaRecuContraseña.Text == txtReinContraseñaRecuContraseña.Text)
                {
                    if (cone.Autentificar(txtUsuarioRecuContraseña.Text) > 0)
                    {
                        cone.recuperarContraseña(txtReinContraseñaRecuContraseña.Text, txtUsuarioRecuContraseña.Text);
                      
                    }
                    else
                    {
                        MessageBox.Show("EL USUARIO NO CORRESPONDE CON NINGUNO GUARDADO","Mensaje");
                        txtUsuarioRecuContraseña.Clear();
                        txtContraseñaRecuContraseña.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("LOS CAMPOS DE LAS CONTRASEÑAS NO SON IGUALES", "Msj");
                    txtUsuarioRecuContraseña.Clear();
                    txtContraseñaRecuContraseña.Clear();
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
            link link = new link();
            link.Show();
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void NuevaContraseñaIngresaGerente_Load(object sender, EventArgs e)
        {

        }
    }
}
