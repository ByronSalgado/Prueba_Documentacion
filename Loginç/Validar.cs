using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginç
{
    class Validar
    {
        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo Letras");
            }
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else 
            {
                v.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }

        public static void NumerosDecimales(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo numeros o numeros con punto decimal");
            }
        }

        public static void MouseDown(MouseEventArgs v)
        {
            if (v.Button == MouseButtons.Right)
            {

                MessageBox.Show("No se puede utilizar el boton derecho" +
                  "", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            
        }

        public static void KeyDown(KeyEventArgs v)
        {
            Clipboard.Clear();
        }

        public static void Espacio(KeyPressEventArgs v)
        {
            if (char.IsWhiteSpace(v.KeyChar))
            {
                v.Handled = true;

            }
        }


       


    }
}
