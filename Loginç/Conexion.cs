using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Loginç
{
    class Conexion
    {
 
        public string SQLServer;
        public SqlConnection CONECTARSQL;
        public SqlCommand COMANDOSQL;
        public SqlDataReader dr;

        public Conexion()
        {
            try
            {
                this.SQLServer = (@"Data Source=localhost\SQLEXPRESS; Initial Catalog = A.Beltran.Copiadora; Integrated Security = True;MultipleActiveResultSets=true;");
                this.CONECTARSQL = new SqlConnection(this.SQLServer);
                CONECTARSQL.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("\a Error,no conectado a la base de datos: " + "\n " + ex.ToString(), "Mensaje");

            }
        }

        public void obtenerBloqueados(ComboBox cb1)
        {
            try
            {
                COMANDOSQL = new SqlCommand("select Usuario from Usuario where ID_Estado = 2", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    cb1.Items.Add(dr["Usuario"].ToString());
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox" + ex.ToString());
            }

        }

        public void obtenerRoles(ComboBox cb1)
        {
            try
            {
                COMANDOSQL = new SqlCommand("select Descripcion_Rol from Roles where ID_Roles > 1", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    cb1.Items.Add(dr["Descripcion_Rol"].ToString());
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox" + ex.ToString());
            }
        }




        public void LlenarContraUsuario(TextBox txtRolUsuario, TextBox txtUsuario, TextBox txtIdEstado)
        {

            try
            {
                COMANDOSQL = new SqlCommand("select ID_Roles from Usuario where Usuario = '" + txtUsuario.Text + "'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    txtRolUsuario.Text = dr["ID_Roles"].ToString();
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO LLENAR LA VARIABLE ROLUSUARIO" + ex.ToString());
            }

            try
            {
                COMANDOSQL = new SqlCommand("select ID_Estado from Usuario where Usuario = '" + txtUsuario.Text + "'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    txtIdEstado.Text = dr["ID_Estado"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE LLENO LA VARIABLE ESTADO" + ex.ToString());
            }

        }
        public void LlenarContraUsuarioGerente(TextBox txtRolUsuario, TextBox txtUsuario)
        {

            try
            {
                COMANDOSQL = new SqlCommand("select ID_Roles from Usuario where Usuario = '" + txtUsuario.Text + "'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    txtRolUsuario.Text = dr["ID_Roles"].ToString();
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO LLENAR LA VARIABLE ROLUSUARIO" + ex.ToString());
            }

        }



        public int Autentificar(String Usuario, String Contraseña)
        {

            int resultado = -1;
            string usuario = Usuario;

            try
            {
                COMANDOSQL = new SqlCommand(string.Format("select * from Usuario where Usuario = '{0}' and PwdCompare('{1}',Contraseña)=1", Usuario, Contraseña), CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    Usuario = dr["Usuario"].ToString();
                    if (usuario.Equals(Usuario))
                    { resultado = 50; }
                    else
                    {
                        resultado = -1;
                       // MessageBox.Show("USUARIO INGRESADO NO GUARDADO EN LA BASE DE DATOS");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            return resultado;
        }

        public int Autentificar(String Usuario)
        {

            int resultado = -1;
            string usuario = Usuario;

            try
            {
                COMANDOSQL = new SqlCommand("select Usuario from Usuario where Usuario = '" + Usuario + "'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    Usuario = dr["Usuario"].ToString();
                    if (usuario.Equals(Usuario))
                    { resultado = 50; }
                    else
                    {
                        resultado = -1;
                      //  MessageBox.Show("USUARIO INGRESADO NO GUARDADO EN LA BASE DE DATOS");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            return resultado;
        }


        public void recuperarContraseña(String txtContraseñaRecuContraseña, String txtUsuarioRecuContraseña)
        {
            try
            {
                COMANDOSQL = new SqlCommand("update Usuario set Contraseña = pwdencrypt('" + txtContraseñaRecuContraseña + "'), ID_Estado = 3,Numero_Intentos = 0 where Usuario = ('" + txtUsuarioRecuContraseña + "') ", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
                //  MessageBox.Show("CONTRASEÑA ACTUALIZADA" ,"Msj");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizo la contraseña" + ex.ToString());
            }


        }

        public void ingresarContraseña(String txtContraseñaRecuContraseña, String txtUsuarioRecuContraseña)
        {
            try
            {
                COMANDOSQL = new SqlCommand("update Usuario set Contraseña = pwdencrypt('" + txtContraseñaRecuContraseña + "'), ID_Estado = 1 where Usuario = ('" + txtUsuarioRecuContraseña + "') ", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
               // MessageBox.Show("CONTRASEÑA ACTUALIZADA", "Msj");
                CONECTARSQL.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE ACTUALIZO LA CONTRASEÑA" + ex.ToString());
            }


        }




        public void obtenerIntentosErroneos(TextBox txtIntentos, TextBox txtUsuario)
        {

            try
            {
                COMANDOSQL = new SqlCommand("select Numero_Intentos from Usuario where Usuario = '" + txtUsuario.Text + "'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    txtIntentos.Text = dr["Numero_Intentos"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE LLENO LA VARIABLE INTENTOS" + ex.ToString());
            }
        }
        public void actualizarErrores(TextBox txtIntentos, TextBox txtUsuario)
        {
            try
            {
                COMANDOSQL = new SqlCommand("update Usuario set Numero_Intentos = '" + txtIntentos.Text + "' where Usuario = '" + txtUsuario.Text + "' ", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
                //MessageBox.Show("AUMENTASTES EL NUMERO DE INTENTOS ERRONEOS", "Msj");
            }

            catch (Exception ex)
            {
                MessageBox.Show("NO SE ACTUALIZO LA CONTRASEÑA" + ex.ToString());
            }


        }

        public void actualizarUsuarioBloqueado(String txtUsuario)
        {
            try
            {
                COMANDOSQL = new SqlCommand("update Usuario set ID_Estado = 2 where Usuario = ('" + txtUsuario + "') ", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
                //  MessageBox.Show("Contraseña actualizada", "Msj");
            }

            catch (Exception ex)
            {
                MessageBox.Show("NO SE HA PODIDO BLOQUEAR EL USUARIO" + ex.ToString());
            }


        }
        public bool obtenerUsuarioExiste(string txtUsuario)
        {
            bool respuesta = false;
            COMANDOSQL = new SqlCommand("select Usuario from Usuario where Usuario = '" + txtUsuario + "'", CONECTARSQL);
            dr = COMANDOSQL.ExecuteReader();

            if (dr.Read())
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            dr.Close();
            return respuesta;
        }

        public int validadUsuarioExistente(String Usuario)
        {

            int resultado = -1;
            string usuario = Usuario;

            try
            {
                COMANDOSQL = new SqlCommand("select Usuario from Usuario where Usuario = '" + Usuario + "'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    Usuario = dr["Usuario"].ToString();
                    if (usuario.Equals(Usuario))
                    {
                        resultado = 50;
                       // MessageBox.Show("Usuario Existente");
                    }
                    else
                    {
                        resultado = -1;
                       // MessageBox.Show("Usuario ingresado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());

            }

            return resultado;

        }

        public string nuevoUsuario(TextBox txtNombreUsuario, TextBox txtUsuario, TextBox txtContrasenia, TextBox txtIdentidad, int cbRol, TextBox txtTelefono, TextBox txtDireccion, TextBox txtCorreo, string sexo)
        {

            string salida = "";

            try
            {
                COMANDOSQL = new SqlCommand("insert into Usuario values (3,'" + txtUsuario.Text + "',pwdencrypt('" + txtContrasenia.Text + "'),'" + txtNombreUsuario.Text.Trim() + "','" + txtIdentidad.Text + "',0,'" + Convert.ToInt32(cbRol) + "','" + txtTelefono.Text + "','" + txtDireccion.Text.Trim() + "','" + txtCorreo.Text + "','" + sexo + "')", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
                salida = "Ingresado";
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se inserto: " + ex.ToString());
            }

            return salida;
        }

        public void actualizar(string nombre, string idusuario, string telefono, string direccion, string correo, string id)
        {
            COMANDOSQL = new SqlCommand("update [dbo].[Usuario] set [Nombre_Usuario]='" + nombre + "', [Identificacion_Usuario]= '" + idusuario + "',[Telefono]='" + telefono + "',[Direccion]='" + direccion + "',[Correo]='" + correo + "' where [ID_Usuario] ='" + id + "' ", CONECTARSQL);
            COMANDOSQL.ExecuteNonQuery();

        }

        public string nuevoProducto(int comboBox1, TextBox txtNomProducto, TextBox txtCodigoBarra, TextBox txtDescripcion, TextBox txtPrecio, TextBox txtCant)
        {

            IngresoModificacionProducto ingreso = new IngresoModificacionProducto();

            string salida = "";

            try
            {
                COMANDOSQL = new SqlCommand("insert into Producto values ( 4,'" + Convert.ToInt16(comboBox1) + "','" + txtCodigoBarra.Text.Trim() + "','"+txtNomProducto.Text.Trim() + "','"  + txtDescripcion.Text.Trim() + "','"+ txtCant.Text.Trim() + "','" + txtPrecio.Text.Trim() +"')", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();

                salida = "Ingresado";
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se inserto: " + ex.ToString());
            }

            return salida;
        }

        public string retornar_id()
        {
            IngresoModificacionProducto ingreso = new IngresoModificacionProducto();

            string valor;

            try
            {
                COMANDOSQL = new SqlCommand("select top 1 [ID_Producto] from [dbo].[Producto] order by [ID_Producto] desc ", CONECTARSQL);
                valor = Convert.ToString(COMANDOSQL.ExecuteNonQuery());
            }

            catch (Exception ex)
            {
                valor = " ";
                MessageBox.Show("No se inserto: " + ex.ToString());
            }

            return valor;
        }

        public string insertar_serie()
        {
            IngresoModificacionProducto ingreso = new IngresoModificacionProducto();

            string salida = "";


            try
            {
                COMANDOSQL = new SqlCommand("insert into [dbo].[Inventario_Serie] values ('" + ingreso.txtCodigoProducto.Text + "', '" + ingreso.txtNum.Text + "'  ) ", CONECTARSQL);
                ingreso.txtCodigoProducto.Text = Convert.ToString(COMANDOSQL.ExecuteNonQuery());

                salida = "Ingresado";
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se inserto: " + ex.ToString());
            }

            return salida;
        }


        public void obtenerLastID(TextBox obtenerIdProductos)
        {

            try
            {
              //  COMANDOSQL = new SqlCommand("", CONECTARSQL);
                
                COMANDOSQL = new SqlCommand( "select ID_Producto from Producto    select top 1 ID_Producto from Producto order by ID_Producto desc", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                   obtenerIdProductos.Text  = dr["ID_Producto"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se obtuvo el ID por lo siguiente: " + ex.ToString());
            }
           
        }

        public void insertarIdSerie(TextBox obtenerIdProductos, String serie)
        {
            int id = Convert.ToInt32(obtenerIdProductos.Text);
         //   String serieId =  Convert.ToString( serie);



            try
            {
                COMANDOSQL = new SqlCommand("insert into Inventario_Serie values ('"+ id+"', '"+serie+"') ", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar en la tabla serie: " + ex.ToString());
            }

        }
        ///////////////////////////////////////////////////////Caja
        public string abrirCaja(TextBox txtMontoInicial)
        {
            string salida = "";
            salida = "Se Inicio Caja";

            try
            {
                COMANDOSQL = new SqlCommand("insert into [dbo].[Arqueo] values (6, '" + txtMontoInicial.Text + "' ,Null,CONVERT(date, GETDATE()) ,Null)", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
                salida = "Ingresado";
                //'" + txtInicialFinal.Text + "'
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se inserto: " + ex.ToString());
            }


            return salida;
        }
        public int validarFecha()
        {

            int resultado = -1;
            string fecha;

            try
            {
                COMANDOSQL = new SqlCommand("SELECT [Fecha_Inicial] FROM [dbo].[Arqueo] WHERE [Fecha_Inicial] =CONVERT(date, GETDATE())", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    fecha = dr["Fecha_Inicial"].ToString();
                    if (fecha.Equals(fecha))
                    {
                        resultado = 50;
                        // MessageBox.Show("Fecha Existente");
                    }
                    else
                    {
                        resultado = -1;
                        MessageBox.Show("Caja Abierta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());

            }

            return resultado;
        }
        /////////////////////////////////////////Cerrar Caja
        public void CerrarCaja(DateTime obtenerFecha, TextBox txtMontoFinal)
        {
            //string salida = "";
            //salida = "Se Cerro Caja";

            try
            {
                COMANDOSQL = new SqlCommand("update [dbo].[Arqueo] set ID_Estado = 7, Monto_Final='" + txtMontoFinal.Text + "' ,Fecha_Final = CONVERT(date,GETDATE()) where ID_Estado = 6  ", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
                MessageBox.Show("Caja cerrada");
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se cerro la caja: " + ex.ToString());
            }
        }
        /////////////////////////////Nuevo Codigo
        public int validarCerrarCaja()
        {

            int resultado = -1;
            string estado;

            try
            {
                COMANDOSQL = new SqlCommand("SELECT Descripcion_Estado FROM dbo.Arqueo As A inner join [dbo].[Estado] As B on A.ID_Estado = b.ID_Estado WHERE(Fecha_Final = CONVERT(date,GETDATE()))", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    estado = dr["Descripcion_Estado"].ToString();
                    if (estado.Equals(estado))
                    {
                        resultado = 50;
                        // MessageBox.Show("Fecha Existente");
                    }
                    else
                    {
                        resultado = -1;
                        MessageBox.Show("Ya habia Cerrado Caja");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());

            }

            return resultado;
        }
        public void validarFacturar(TextBox idEstado)
        {
            try
            {
                COMANDOSQL = new SqlCommand("select ID_Estado from Arqueo where Fecha_Inicial = CONVERT(date, getdate())", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();

                while (dr.Read())
                {
                    idEstado.Text = dr["ID_Estado"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());
            }
        }
        public bool validarFacturar()
        {
            bool idExiste = false;


            try
            {
                COMANDOSQL = new SqlCommand(" select ID_Estado from [dbo].[Arqueo]  select ID_Estado from [dbo].[Arqueo] where [Fecha_Inicial] = GETDATE()", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                if (dr.Read())
                {
                    idExiste = true;

                }
                else
                {
                    idExiste = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());
            }

            return idExiste;
        }

        public void IDCai(TextBox id)
        {
            try
            {
                COMANDOSQL = new SqlCommand("select top 1 [ID_CAI] from [dbo].[CAI] order by [ID_CAI] desc", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();

                while (dr.Read())
                {
                    id.Text = dr["ID_CAI"].ToString();
                }
                dr.Close();
             

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());
            }
        }

        public void IDArqueo(TextBox id)
        {
            try
            {
                COMANDOSQL = new SqlCommand("select top 1 [ID_Arqueo] from [dbo].[Arqueo] order by [ID_Arqueo] desc", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();

                while (dr.Read())
                {
                    id.Text = dr["ID_Arqueo"].ToString();
                }
                dr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());
            }
        }
        
        public void IDUsuario(TextBox id)
        {
            try
            {
                COMANDOSQL = new SqlCommand("select [ID_Usuario] from [dbo].[Usuario] where [Usuario] = 'Cajero'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();

                while (dr.Read())
                {
                    id.Text = dr["ID_Usuario"].ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());
            }

        }

        public string nuevaFactura(TextBox idcliente, TextBox iduser, TextBox idarqueo, TextBox idcai)
        {
            string salida = "";

            try
            {
                COMANDOSQL = new SqlCommand("insert into Factura values ('"+idcliente.Text+"', '"+iduser.Text+"', '"+idarqueo.Text+"', 8, 1, '"+idcai.Text+ "', CONVERT(date, GETDATE()), 0.15)", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();

                salida = "Ingresado";
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se inserto: " + ex.ToString());
            }

            return salida;
        }

        public int validarClienteExistente(String Cliente)
        {

            int resultado = -1;
            string cliente = Cliente;

            try
            {
                COMANDOSQL = new SqlCommand("select [Nombre_Cliente] from [dbo].[Cliente]  where [Nombre_Cliente] = '" + Cliente + "'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    Cliente = dr["Nombre_Cliente"].ToString();
                    if (cliente.Equals(Cliente))
                    {
                        resultado = 50;
                        // MessageBox.Show("Usuario Existente");
                    }
                    else
                    {
                        resultado = -1;
                        // MessageBox.Show("Usuario ingresado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo verificar si existe" + ex.ToString());

            }

            return resultado;

        }

        public string nuevoCliente(int cbTipoIden, TextBox txtNombreCliente, TextBox txtIdentidad, TextBox txtTelefono, TextBox txtDireccion, TextBox txtCorreo)
        {

            string salida = "";

            try
            {
                COMANDOSQL = new SqlCommand("insert into [Cliente] values (1,'" + Convert.ToInt32(cbTipoIden) + "','" + txtTelefono.Text + "','" + txtNombreCliente.Text.Trim() + "','" + txtDireccion.Text.Trim() + "','" + txtCorreo.Text + "','" + txtIdentidad.Text.Trim() + "')", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();
                salida = "Ingresado";
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se inserto: " + ex.ToString());
            }

            return salida;
        }

        public void obtenerTipoIdentidad(ComboBox cbTipoIden)
        {
            try
            {
                COMANDOSQL = new SqlCommand("SELECT Descripcion_Identificacion FROM dbo.Tipo_Identificacion", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();
                while (dr.Read())
                {
                    cbTipoIden.Items.Add(dr["Descripcion_Identificacion"].ToString());
                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox" + ex.ToString());
            }
        }
        //////UPDATE
        public void actualizar(string telefono, string direccion, string correo, string id)
        {
            COMANDOSQL = new SqlCommand("update [dbo].[Cliente] set [Telefono_Cliente]='" + telefono + "',[Direccion_Cliente]='" + direccion + "',[Correo_Cliente]='" + correo + "' where [ID_Cliente] ='" + id + "' ", CONECTARSQL);
            COMANDOSQL.ExecuteNonQuery();

        }
        /////////////////Validar Factura

        public void obtenerDetalleProducto(String Nombre, TextBox inventarioSerie, TextBox idProducto, TextBox precioUnitario)
        {
            try
            {
                COMANDOSQL = new SqlCommand("SELECT dbo.Inventario_Serie.ID_Inventario_Serie, dbo.Producto.ID_Producto, dbo.Producto.Precio FROM dbo.Inventario_Serie INNER JOIN dbo.Producto ON dbo.Inventario_Serie.ID_Producto = dbo.Producto.ID_Producto where dbo.Producto.Nombre_Producto = '" + Nombre + "'", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();

                while (dr.Read())
                {
                    inventarioSerie.Text = dr["ID_Inventario_Serie"].ToString();
                    idProducto.Text = dr["ID_Producto"].ToString();
                    precioUnitario.Text = dr["Precio"].ToString();
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron obtener los datos" + ex.ToString());
            }

        }


        public void obtenerIdFactura(TextBox idFactura)
        {
            try
            {
                COMANDOSQL = new SqlCommand("select top 1 ID_Factura from Factura order by ID_Factura desc", CONECTARSQL);
                dr = COMANDOSQL.ExecuteReader();

                while (dr.Read())
                {
                    idFactura.Text = dr["ID_Factura"].ToString();

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener el ID de factura" + ex.ToString());
            }

        }



        public void insertarDetalleFactura(int inventarioSerie, int idProducto, int idFactura, int cantidad, double precioUnitario)
        {
            try
            {
                COMANDOSQL = new SqlCommand("insert into Detalles_Factura values('" + inventarioSerie + "','" + idProducto + "','" + idFactura + "','" + cantidad + "','" + precioUnitario + "') ", CONECTARSQL);
                COMANDOSQL.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo insertar " + e.ToString());
            }

        }




    }
}
        