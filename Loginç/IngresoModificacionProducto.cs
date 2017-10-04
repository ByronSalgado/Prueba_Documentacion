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
    public partial class IngresoModificacionProducto : Form
    {
        public IngresoModificacionProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bodega Regresar = new Bodega();

            Regresar.Show();
            this.Hide();
        }

        private void IngresoModificacionProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet7.Estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter1.Fill(this._A_Beltran_CopiadoraDataSet7.Estado);
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet6.Categoria_Producto' Puede moverla o quitarla según sea necesario.
            this.categoria_ProductoTableAdapter2.Fill(this._A_Beltran_CopiadoraDataSet6.Categoria_Producto);
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet5.Categoria_Producto' Puede moverla o quitarla según sea necesario.
            this.categoria_ProductoTableAdapter1.Fill(this._A_Beltran_CopiadoraDataSet5.Categoria_Producto);
            // TODO: esta línea de código carga datos en la tabla '_A_Beltran_CopiadoraDataSet3.Estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter.Fill(this._A_Beltran_CopiadoraDataSet3.Estado);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtNomProducto.Text) | String.IsNullOrEmpty(txtNum.Text) | String.IsNullOrEmpty(txtCodigo.Text) | String.IsNullOrEmpty(txtDescripcion.Text) | String.IsNullOrEmpty(txtPrecio.Text) | String.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Falta llenar ciertos campos", "Mensaje");
            }

            else
            {
                if (comboBox1.SelectedIndex == 0 && Convert.ToInt32(txtCantidad.Text) > 1)
                {
                    MessageBox.Show("Error Solo puede ingresar una copiadora");
                    txtCantidad.Text = "";
                    txtCantidad.Focus();
                }
                else
                {
                    Conexion conex = new Conexion();
                    string salida;
                    try
                    {
                        conex.COMANDOSQL = new SqlCommand("update Producto  set  [ID_Categoria] = " + Convert.ToInt16(comboBox1.SelectedIndex + 1) + ", [ID_Estado] =  " + Convert.ToInt16(comboBox2.SelectedIndex + 1) + ", [Codigo_Barra] = '" + txtCodigo.Text + "', [Nombre_Producto] = '" + txtNomProducto.Text + "', [Descripcion_Producto] = '" + txtDescripcion.Text + "' ,[Cantidad] = '" + txtCantidad.Text + "', [Precio] ='" + txtPrecio.Text + "' where[ID_Producto] = '" + textBox1.Text + "'", conex.CONECTARSQL);
                        conex.COMANDOSQL.ExecuteNonQuery();
                        conex.COMANDOSQL = new SqlCommand("update Inventario_Serie  set [Serie] = " + txtNum.Text + " where[ID_Producto] = " + textBox1.Text + "", conex.CONECTARSQL);
                        conex.COMANDOSQL.ExecuteNonQuery();
                        salida = "Datos insertados correctamente";
                    }
                    catch (Exception ex)
                    {
                        salida = "Error: Datos no insertados " + ex.ToString();
                    }

                    MessageBox.Show(salida);

                    Bodega Regresar = new Bodega();

                    Regresar.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            Conexion conex = new Conexion();
            string salida;
            int id;

            if (String.IsNullOrEmpty(txtNomProducto.Text) | String.IsNullOrEmpty(txtNum.Text) | String.IsNullOrEmpty(txtCodigo.Text) | String.IsNullOrEmpty(txtDescripcion.Text) | String.IsNullOrEmpty(txtPrecio.Text) | String.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Falta llenar ciertos campos", "Mensaje");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0 && Convert.ToInt32(txtCantidad.Text) > 1)
                {
                    MessageBox.Show("Error Solo puede ingresar una copiadora");
                    txtCantidad.Text = "";
                    txtCantidad.Focus();
                }
                else
                {


                    try
                    {
                        conex.nuevoProducto((comboBox1.SelectedIndex + 1), txtNomProducto, txtCodigo, txtDescripcion, txtPrecio, txtCantidad);
                        conex.obtenerLastID(obtenerIdProducto);
                        conex.insertarIdSerie(obtenerIdProducto, txtNum.Text);
                        //id = Convert.ToInt16(conex.retornar_id());
                        //  conex.insertar_serie();
                        salida = "Datos Insertados Correctamente";
                    }
                    catch (Exception ex)
                    {
                        salida = "Error: Datos no insertados " + ex.ToString();
                    }

                    MessageBox.Show(salida);
                    Bodega Regresar = new Bodega();

                    Regresar.Show();
                    this.Hide();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtNomProducto_Validating(object sender, CancelEventArgs e)
        {
            if (txtNomProducto.Text.Trim() == String.Empty)
            {
                epError.SetError(txtNomProducto, "No se permiten campos vacíos");
                txtNomProducto.Text = "";
            }


            else
                epError.SetError(txtNomProducto, "");
        }

        private void txtNum_Validating(object sender, CancelEventArgs e)
        {
            if (txtNum.Text.Trim() == String.Empty)
            {
                epError.SetError(txtNum, "No se permiten campos vacíos");
                txtNum.Text = "";
            }


            else
                epError.SetError(txtNum, "");
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text.Trim() == String.Empty)
            {
                epError.SetError(txtCodigo, "No se permiten campos vacíos");
                txtCodigo.Text = "";
            }


            else
                epError.SetError(txtCodigo, "");
        }

        private void txtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescripcion.Text.Trim() == String.Empty)
            {
                epError.SetError(txtDescripcion, "No se permiten campos vacíos");
                txtDescripcion.Text = "";
            }


            else
                epError.SetError(txtDescripcion, "");
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrecio.Text.Trim() == String.Empty)
            {
                epError.SetError(txtPrecio, "No se permiten campos vacíos");
                txtPrecio.Text = "";
            }


            else
                epError.SetError(txtPrecio, "");
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (txtCantidad.Text.Trim() == String.Empty)
            {
                epError.SetError(txtCantidad, "No se permiten campos vacíos");
                txtCantidad.Text = "";
            }


            else
                epError.SetError(txtCantidad, "");
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);

            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.MaxLength = 7;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.MaxLength = 5;
        }

        private void txtNomProducto_TextChanged(object sender, EventArgs e)
        {
            txtNomProducto.MaxLength = 20;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            txtNum.MaxLength = 20;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.MaxLength = 30;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.MaxLength =15;
        }

        private void txtNomProducto_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            Clipboard.Clear();
        }
    }
    }

