using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class DAudio 
    {
        private int _Idaudio;
        private string _nombre;
        private string _Direccion;
        private string _Buscaraudio;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
      

        public int Idaudio
        {
            get { return _Idaudio; }
            set { _Idaudio = value; }
        }




        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
       


        public string Buscaraudio
        {
            get { return _Buscaraudio; }
            set { _Buscaraudio = value; }
        }



        public  DAudio()
        {

        }

        public DAudio(int idaudio, string nombre, string direccion, string buscaraudio)
        {
            this.Idaudio = idaudio;
            this.Direccion = direccion;
            this.Nombre = nombre;
            this.Buscaraudio = buscaraudio;
        }



       

        //Metodos
        #region Metodos_CRUD
        public string Insertar(DAudio Audio)
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
                comandos.CommandText = "insertar_audio";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_Idaudio = new SqlParameter();
                parametro_Idaudio.ParameterName = "@idaudio";
                parametro_Idaudio.SqlDbType = SqlDbType.Int;
                parametro_Idaudio.Direction = ParameterDirection.Output;
                comandos.Parameters.Add(parametro_Idaudio);

                SqlParameter parametro_nombre = new SqlParameter();
                parametro_nombre.ParameterName = "@nombre";
                parametro_nombre.SqlDbType = SqlDbType.VarChar;
                parametro_nombre.Size = 500;
                parametro_nombre.Value = Audio.Nombre;
                comandos.Parameters.Add(parametro_nombre);

                SqlParameter parametro_direccion = new SqlParameter();
                parametro_direccion.ParameterName = "@direccion";
                parametro_direccion.SqlDbType = SqlDbType.VarChar;
                parametro_direccion.Size= 500;
                parametro_direccion.Value = Audio.Direccion;
                comandos.Parameters.Add(parametro_direccion);


               


               


                //ejecucion de los comandos 
                respuesta = comandos.ExecuteNonQuery() == 1 ? "Registro insertado" : " NO se ingresó el registro";



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












        public string Editar(DAudio Audio)
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
                comandos.CommandText = "speditar_audio";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_Idaudio = new SqlParameter();
                parametro_Idaudio.ParameterName = "@idaudio";
                parametro_Idaudio.SqlDbType = SqlDbType.Int;
                parametro_Idaudio.Value = Audio.Idaudio;
                comandos.Parameters.Add(parametro_Idaudio);

                SqlParameter parametro_nombre = new SqlParameter();
                parametro_nombre.ParameterName = "@nombre";
                parametro_nombre.SqlDbType = SqlDbType.VarChar;
                parametro_nombre.Size = 500;
                parametro_nombre.Value = Audio.Nombre;
                comandos.Parameters.Add(parametro_nombre);
            

                SqlParameter parametro_direccion = new SqlParameter();
                parametro_direccion.ParameterName = "@direccion";
                parametro_direccion.SqlDbType = SqlDbType.VarChar;
                parametro_direccion.Size = 500;
                parametro_direccion.Value = Audio.Direccion;
                comandos.Parameters.Add(parametro_direccion);


                

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










        public string Eliminar(DAudio Audio)
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
                comandos.CommandText = "eliminar_audio";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_Idaudio = new SqlParameter();
                parametro_Idaudio.ParameterName = "@idaudio";
                parametro_Idaudio.SqlDbType = SqlDbType.Int;
                parametro_Idaudio.Value = Audio.Idaudio;
                comandos.Parameters.Add(parametro_Idaudio);



                //ejecucion de los comandos 
                comandos.ExecuteNonQuery() ;

                

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
            DataTable dataresultado = new DataTable("Audio");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = ClsConexion.conexion;
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "spmostrar_audio";
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

        public DataTable Buscar_audio(DAudio Audio)
        {
            DataTable dataresultado = new DataTable("Audio");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = ClsConexion.conexion;
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "spbuscar_audio";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_buscar_audio = new SqlParameter();
                parametro_buscar_audio.ParameterName = "@buscaraudio";
                parametro_buscar_audio.SqlDbType = SqlDbType.VarChar;
                parametro_buscar_audio.Size = 50;
                parametro_buscar_audio.Value = Audio.Buscaraudio;
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
