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
    public partial class link : Form
    {
       
        Conexion conexion = new Conexion();
       
       // int contadorErroresIngresar;
        public link()
        {
            InitializeComponent();
/*
            TxtUsuario.Text = "Usuario";
            TxtUsuario.ForeColor = Color.Gray;

            TxtContraseña.Text = "Contraseña";

            TxtContraseña.ForeColor = Color.Gray;
*/
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUsuario.Text) | String.IsNullOrEmpty(TxtContraseña.Text))
            {
                MessageBox.Show("USUARIO O CONTRASEÑA ESTAN VACIOS", "Mensaje");
                TxtUsuario.Clear();
                TxtContraseña.Clear();
            }
            else
            {
                if (conexion.obtenerUsuarioExiste(TxtUsuario.Text) == false)
                {
                    MessageBox.Show("EL USUARIO NO EXISTE ,INGRESE UNO CORRECTO", "Msj");
                    TxtUsuario.Clear();
                    TxtContraseña.Clear();
                }
                else
                {
                    conexion.obtenerIntentosErroneos(txtIntentosErrores, TxtUsuario);
                    int contadorErroresIngresar = Convert.ToInt32(txtIntentosErrores.Text);
                    if (contadorErroresIngresar == 3)
                    {
                        conexion.actualizarUsuarioBloqueado(TxtUsuario.Text);
                        MessageBox.Show("ESTE USUARIO ESTA BLOQUEADO POR SOBREPASAR EL LIMITE DE INTENTOS PARA INGRESAR", "Msj");
                        TxtUsuario.Clear();
                        TxtContraseña.Clear();
                    }
                    else
                    {
                        if (conexion.Autentificar(TxtUsuario.Text) > 0)
                        {
                            conexion.LlenarContraUsuario(TxtIdRol, TxtUsuario, txtIdEstado);
                            if (conexion.Autentificar(TxtUsuario.Text, TxtContraseña.Text) > 0)
                            {
                                if (Convert.ToInt32(txtIdEstado.Text) == 3)
                                {
                                    MessageBox.Show("DEBES CAMBIAR LA CONTRASEÑA", "Msj");
                                    NuevaContraseñaUsuarios contraUsuarios = new NuevaContraseñaUsuarios();
                                    String user = TxtUsuario.Text;
                                    contraUsuarios.txtUsuarioRecuContraseña.Text = user;
                                    contraUsuarios.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("BIENVENIDO", "Mensaje");
                                    if (Convert.ToInt32(TxtIdRol.Text) == 1)
                                    {
                                        FormGerente gere = new FormGerente();
                                        gere.Show();
                                        this.Hide();
                                    }
                                    /////////////////////Cajero2  cajero
                                    else if (Convert.ToInt32(TxtIdRol.Text) == 2)
                                    {
                                         Cajero ser = new Cajero();
                                        ser.Show();
                                        this.Hide();
                                    }
                                    //////////////////////
                                    else if (Convert.ToInt32(TxtIdRol.Text) == 3)
                                    {
                                        Servicio_Tecnico ser = new Servicio_Tecnico();
                                        ser.Show();
                                        this.Hide();
                                    }
                                    else if (Convert.ToInt32(TxtIdRol.Text) == 4)
                                    {
                                        Bodega bdg = new Bodega();
                                        bdg.Show();
                                        this.Hide();
                                    }

                                    
                                }
                            }
                            else
                            {
                                if (TxtIdRol.Text != "1")
                                {
                                    MessageBox.Show("NO SE PUEDE INGRESAR", "mensaje");
                                    contadorErroresIngresar++;
                                    txtIntentosErrores.Text = Convert.ToString(contadorErroresIngresar);
                                    conexion.actualizarErrores(txtIntentosErrores, TxtUsuario);
                                    TxtUsuario.Clear();
                                    TxtContraseña.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("NO SE PUEDE INGRESAR", "mensaje");
                                    TxtUsuario.Clear();
                                    TxtContraseña.Clear();
                                }
                            }
                        }
                       
                        
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
            NuevaContraseñaIngresaGerente nueva = new NuevaContraseñaIngresaGerente();
            nueva.Show();
            this.Hide();
            */
            ContraseñaGerente gere = new ContraseñaGerente();
            gere.Show();
            this.Hide();

        }

        private void link_Load(object sender, EventArgs e)
        {
            linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
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
            this.Close();
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            /*
            TxtContraseña.Text = "";
            TxtContraseña.ForeColor = Color.Black;
           */
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
        }

       /* private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Gray;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.White;
        }
        */
        private void TxtUsuario_MouseHover(object sender, EventArgs e)
        {
            //TxtUsuario.BackColor = Color.Gray;
        }

        private void TxtContraseña_MouseHover(object sender, EventArgs e)
        {
            //TxtContraseña.BackColor = Color.Gray;
        }

        private void TxtUsuario_MouseLeave(object sender, EventArgs e)
        {
            //TxtUsuario.BackColor = Color.White;
        }

        private void TxtContraseña_MouseLeave(object sender, EventArgs e)
        {
            //TxtContraseña.BackColor = Color.White;
        }

        private void TxtUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                MessageBox.Show("No se puede utilizar el boton derecho" +
                  "", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void TxtContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                MessageBox.Show("No se puede utilizar el boton derecho" +
                  "", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void TxtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtIntentosErrores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
