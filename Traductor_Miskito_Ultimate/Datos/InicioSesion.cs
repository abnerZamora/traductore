using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class InicioSesion
    {

        private int _IdUsuario;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }


        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }


        private string _Contraseña;

        public string Contraseña
        {
            get { return _Contraseña; }
            set { _Contraseña = value; }
        }


        private string _PrimerNombre;

        public string PrimerNombre
        {
            get { return _PrimerNombre; }
            set { _PrimerNombre = value; }
        }
        private string _Apellidos;

        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        private string _TipoUsuario;

        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { _TipoUsuario = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        private string _Buscarusuario;

        public string Buscarusuario
        {
            get { return _Buscarusuario; }
            set { _Buscarusuario = value; }
        }

        public InicioSesion()
        {

        }


        public InicioSesion( int idusuario, string primer_nombre, string apellidos, string tipousuario, string email)
        {
            this.IdUsuario = idusuario;
            this.PrimerNombre = primer_nombre;
            this.Apellidos = apellidos;
            this.TipoUsuario = tipousuario;
            this.Email = email;
        }



        public bool login(string user, string pass)
        {
            
           
             SqlConnection sqlcon = new SqlConnection();
             sqlcon.ConnectionString = ClsConexion.conexion;
                sqlcon.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = sqlcon;
                    command.CommandText = "select *from Usuarios where Usuariio=@user and Contraseña=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            IdUsuario = reader.GetInt32(0);
                          PrimerNombre = reader.GetString(3);
                            Apellidos = reader.GetString(4);
                            TipoUsuario = reader.GetString(5);
                           Email = reader.GetString(6);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        








        //Metodos
        #region Metodos_CRUD
        public string Insertar(InicioSesion inicioSesion)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //codigo
                sqlcon.ConnectionString = ClsConexion.conexion;
                sqlcon.Open();
                //establecer comandos sql
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "insertar_usuario";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_Id = new SqlParameter();
                parametro_Id.ParameterName = "@id";
                parametro_Id.SqlDbType = SqlDbType.Int;
                parametro_Id.Direction = ParameterDirection.Output;
                comandos.Parameters.Add(parametro_Id);

                SqlParameter parametro_usuario = new SqlParameter();
                parametro_usuario.ParameterName = "@Usuariio";
                parametro_usuario.SqlDbType = SqlDbType.VarChar;
                parametro_usuario.Size = 30;
                parametro_usuario.Value = inicioSesion.Usuario;
                comandos.Parameters.Add(parametro_usuario);

                SqlParameter parametro_contraseña = new SqlParameter();
                parametro_contraseña.ParameterName = "@Contraseña";
                parametro_contraseña.SqlDbType = SqlDbType.VarChar;
                parametro_contraseña.Size = 30;
                parametro_contraseña.Value = inicioSesion.Contraseña;
                comandos.Parameters.Add(parametro_contraseña);

                SqlParameter parametro_nombre = new SqlParameter();
                parametro_nombre.ParameterName = " @Nombres";
                parametro_nombre.SqlDbType = SqlDbType.VarChar;
                parametro_nombre.Size = 30;
                parametro_nombre.Value = inicioSesion.PrimerNombre;
                comandos.Parameters.Add(parametro_nombre);

                SqlParameter parametro_apellidos = new SqlParameter();
                parametro_apellidos.ParameterName = "@Apellidos";
                parametro_apellidos.SqlDbType = SqlDbType.VarChar;
                parametro_apellidos.Size = 30;
                parametro_apellidos.Value = inicioSesion.Apellidos;
                comandos.Parameters.Add(parametro_apellidos);


                SqlParameter parametro_privilegio = new SqlParameter();
                parametro_privilegio.ParameterName = "@Privilegios";
                parametro_privilegio.SqlDbType = SqlDbType.VarChar;
                parametro_privilegio.Size = 30;
                parametro_privilegio.Value = inicioSesion.TipoUsuario;
                comandos.Parameters.Add(parametro_privilegio);

                SqlParameter parametro_email = new SqlParameter();
                parametro_email.ParameterName = "@Email";
                parametro_email.SqlDbType = SqlDbType.VarChar;
                parametro_email.Size = 30;
                parametro_email.Value = inicioSesion.Email;
                comandos.Parameters.Add(parametro_email);








                //ejecucion de los comandos 
                respuesta = comandos.ExecuteNonQuery() == 1 ? "Usuario insertado" : " NO se registró el usuario";



            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return respuesta;

        }












        public string Editar(InicioSesion inicioSesion)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //codigo
                sqlcon.ConnectionString = ClsConexion.conexion;
                sqlcon.Open();
                //establecer comandos sql
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "speditar_usuario";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_Id = new SqlParameter();
                parametro_Id.ParameterName = "@id";
                parametro_Id.SqlDbType = SqlDbType.Int;
                parametro_Id.Value = inicioSesion.IdUsuario;
                comandos.Parameters.Add(parametro_Id);

                SqlParameter parametro_usuario = new SqlParameter();
                parametro_usuario.ParameterName = "@Usuariio";
                parametro_usuario.SqlDbType = SqlDbType.VarChar;
                parametro_usuario.Size = 30;
                parametro_usuario.Value = inicioSesion.Usuario;
                comandos.Parameters.Add(parametro_usuario);

                SqlParameter parametro_contraseña = new SqlParameter();
                parametro_contraseña.ParameterName = "@Contraseña";
                parametro_contraseña.SqlDbType = SqlDbType.VarChar;
                parametro_contraseña.Size = 30;
                parametro_contraseña.Value = inicioSesion.Contraseña;
                comandos.Parameters.Add(parametro_contraseña);

                SqlParameter parametro_nombre = new SqlParameter();
                parametro_nombre.ParameterName = " @Nombres";
                parametro_nombre.SqlDbType = SqlDbType.VarChar;
                parametro_nombre.Size = 30;
                parametro_nombre.Value = inicioSesion.PrimerNombre;
                comandos.Parameters.Add(parametro_nombre);

                SqlParameter parametro_apellidos = new SqlParameter();
                parametro_apellidos.ParameterName = "@Apellidos";
                parametro_apellidos.SqlDbType = SqlDbType.VarChar;
                parametro_apellidos.Size = 30;
                parametro_apellidos.Value = inicioSesion.Apellidos;
                comandos.Parameters.Add(parametro_apellidos);


                SqlParameter parametro_privilegio = new SqlParameter();
                parametro_privilegio.ParameterName = "@Privilegios";
                parametro_privilegio.SqlDbType = SqlDbType.VarChar;
                parametro_privilegio.Size = 30;
                parametro_privilegio.Value = inicioSesion.TipoUsuario;
                comandos.Parameters.Add(parametro_privilegio);

                SqlParameter parametro_email = new SqlParameter();
                parametro_email.ParameterName = "@Email";
                parametro_email.SqlDbType = SqlDbType.VarChar;
                parametro_email.Size = 30;
                parametro_email.Value = inicioSesion.Email;
                comandos.Parameters.Add(parametro_email);




                //ejecucion de los comandos 
                respuesta = comandos.ExecuteNonQuery() == 1 ? "Edicion actualizada" : " NO se actualizó la Edición";



            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return respuesta;

        }










        public string Eliminar(InicioSesion InicioSesion)
        {
            string respuesta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //codigo
                sqlcon.ConnectionString = ClsConexion.conexion;
                sqlcon.Open();
                //establecer comandos sql
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "eliminar_usuario";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_Id = new SqlParameter();
                parametro_Id.ParameterName = "@id";
                parametro_Id.SqlDbType = SqlDbType.Int;
                parametro_Id.Value = InicioSesion.IdUsuario;
                comandos.Parameters.Add(parametro_Id);



                //ejecucion de los comandos 
                comandos.ExecuteNonQuery();



            }
            catch (Exception ex)
            {

                respuesta = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return respuesta;

        }







        public DataTable Mostrar()
        {
            DataTable dataresultado = new DataTable("Usuarios");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = ClsConexion.conexion;
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "spmostrar_usuarios";
                comandos.CommandType = CommandType.StoredProcedure;

                // ejecutar el comando y llenar el datatable
                SqlDataAdapter sqldata = new SqlDataAdapter(comandos);
                sqldata.Fill(dataresultado);
            }
            catch (Exception ex)
            {

                dataresultado = null;
            }

            return dataresultado;


        }

        public DataTable Buscar_audio(InicioSesion InicioSesion)
        {
            DataTable dataresultado = new DataTable("Usuarios");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = ClsConexion.conexion;
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "spbuscar_usuario";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_buscar_audio = new SqlParameter();
                parametro_buscar_audio.ParameterName = "@buscarusuario";
                parametro_buscar_audio.SqlDbType = SqlDbType.VarChar;
                parametro_buscar_audio.Size = 50;
                parametro_buscar_audio.Value = InicioSesion.Buscarusuario;
                comandos.Parameters.Add(parametro_buscar_audio);

                // ejecutar el comando y llenar el datatable
                SqlDataAdapter sqldata = new SqlDataAdapter(comandos);
                sqldata.Fill(dataresultado);
            }
            catch (Exception ex)
            {

                dataresultado = null;
            }

            return dataresultado;

        }


        #endregion
    }

  

}
