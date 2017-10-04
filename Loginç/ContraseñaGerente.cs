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
    public partial class ContraseñaGerente : Form
    {
        Conexion conexion = new Conexion();
        public ContraseñaGerente()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUsuario.Text) | String.IsNullOrEmpty(TxtContraseña.Text))
            {
                MessageBox.Show("USUARIO O CONTRASEÑA ESTAN VACIOS", "Mensaje");
                TxtContraseña.Clear();
                TxtUsuario.Clear();
            }
            else
            {
                if (conexion.obtenerUsuarioExiste(TxtUsuario.Text) == false)
                {
                    MessageBox.Show("EL USUARIO NO EXISTE O ES INCORRECTO", "Msj");
                    TxtContraseña.Clear();
                    TxtUsuario.Clear();
                }
                else
                {
                        if (conexion.Autentificar(TxtUsuario.Text, TxtContraseña.Text) > 0)
                        {
                        conexion.LlenarContraUsuarioGerente(TxtIdRol, TxtUsuario);
                        
                        if (Convert.ToInt32(TxtIdRol.Text) != 1)
                            {
                                MessageBox.Show("EL USUARIO INGRESADO NO ES EL GERENTE", "Msj");
                            TxtContraseña.Clear();
                            TxtUsuario.Clear();

                        }
                            else
                            {
                                NuevaContraseñaIngresaGerente nueva = new NuevaContraseñaIngresaGerente();
                                nueva.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("NO SE PUEDE INGRESAR", "mensaje");
                        TxtContraseña.Clear();
                        TxtUsuario.Clear();
                    }
                    
                }
            }
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
           TxtUsuario.MaxLength = 50;
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            TxtContraseña.MaxLength = 50;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.Gray;
        }

        private void Atras_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Atras_MouseLeave(object sender, EventArgs e)
        {
            Atras.BackColor = Color.White;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.White;
        }

        private void TxtUsuario_MouseHover(object sender, EventArgs e)
        {
      //      TxtUsuario.BackColor = Color.Gray;
        
        }

        private void TxtUsuario_MouseLeave(object sender, EventArgs e)
        {
    //        TxtUsuario.BackColor = Color.White;
            
        }

        private void TxtContraseña_MouseHover(object sender, EventArgs e)
        {
  //          TxtContraseña.BackColor = Color.Gray;
        }

        private void TxtContraseña_MouseLeave(object sender, EventArgs e)
        {
//TxtContraseña.BackColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            link link = new link();
            link.Show();
            this.Close();
        }

        private void Atras_MouseHover_1(object sender, EventArgs e)
        {
            Atras.BackColor = Color.Gray;
        }

        private void Atras_MouseLeave_1(object sender, EventArgs e)
        {
            Atras.BackColor = Color.White;
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void TxtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
