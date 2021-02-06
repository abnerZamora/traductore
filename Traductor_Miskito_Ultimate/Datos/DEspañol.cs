using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DEspañol
    {
        private int _idEspañol;

        public int IdEspañol
        {
            get { return _idEspañol; }
            set { _idEspañol = value; }
        }
        private string _Español;

        public string Español
        {
            get { return _Español; }
            set { _Español = value; }
        }
        private string _Miskito;

        public string Miskito
        {
            get { return _Miskito; }
            set { _Miskito = value; }
        }
        private byte[] _Imagen;

        public byte[] Imagen
        {
            get { return _Imagen; }
            set { _Imagen = value; }
        }
        private int _Idaudio;

        public int Idaudio
        {
            get { return _Idaudio; }
            set { _Idaudio = value; }
        }
        private string _BuscarPalabra;

        public string BuscarPalabra
        {
            get { return _BuscarPalabra; }
            set { _BuscarPalabra = value; }
        }


        
       
       

       


       

        
        public DEspañol()
        {

        }

       public DEspañol(int idespañol, string español, string miskito,byte[] imagen, int idaudio,string buscarpalabra)
        {
            this.IdEspañol = idespañol;
            this.Español = español;
            this.Miskito = miskito;
            this.Imagen = imagen;
            this.Idaudio = idaudio;
            this.BuscarPalabra = buscarpalabra;

        }
       //Metodos
       #region Metodos_CRUD


       public string Insertar (DEspañol Español)
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
               comandos.CommandText = "insertar_palabra";
               comandos.CommandType = CommandType.StoredProcedure;

               SqlParameter parametro_Idespañol = new SqlParameter();
               parametro_Idespañol.ParameterName = "@idespañol";
               parametro_Idespañol.SqlDbType = SqlDbType.Int;
               parametro_Idespañol.Direction = ParameterDirection.Output;
               comandos.Parameters.Add(parametro_Idespañol);

               SqlParameter parametro_palabra_español = new SqlParameter();
               parametro_palabra_español.ParameterName = "@Español";
               parametro_palabra_español.SqlDbType = SqlDbType.VarChar;
               parametro_palabra_español.Size = 50;
               parametro_palabra_español.Value = Español.Español;
               comandos.Parameters.Add(parametro_palabra_español);


               SqlParameter parametro_descripcion = new SqlParameter();
               parametro_descripcion.ParameterName = "@Miskito";
               parametro_descripcion.SqlDbType = SqlDbType.VarChar;
               parametro_descripcion.Size = 50;
               parametro_descripcion.Value = Español.Miskito;
               comandos.Parameters.Add(parametro_descripcion);


               SqlParameter parametro_imagen = new SqlParameter();
               parametro_imagen.ParameterName = "@imagen";
               parametro_imagen.SqlDbType = SqlDbType.VarBinary;
               parametro_imagen.Value = Español.Imagen;
               comandos.Parameters.Add(parametro_imagen);


               SqlParameter parametro_idaudio = new SqlParameter();
               parametro_idaudio.ParameterName = "@idaudio";
               parametro_idaudio.SqlDbType = SqlDbType.VarChar;
               parametro_idaudio.Value = Español.Idaudio;
               comandos.Parameters.Add(parametro_idaudio);

               //ejecucion de los comandos 
               respuesta = comandos.ExecuteNonQuery() == 1 ? "Palabra insertada" : " NO se ingreso la palabra";



           }
           catch ( Exception ex)
           {

               respuesta = ex.Message;
           }

           finally
           {
               if (sqlcon.State== ConnectionState.Open)
               {
                   sqlcon.Close();
               }
           }
           return respuesta;
            
       }












        public string Editar (DEspañol Español)
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
                comandos.CommandText = "speditar_palabra";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_Idespañol = new SqlParameter();
                parametro_Idespañol.ParameterName = "@idespañol";
                parametro_Idespañol.SqlDbType = SqlDbType.Int;
                parametro_Idespañol.Value = Español.IdEspañol;
                comandos.Parameters.Add(parametro_Idespañol);

                SqlParameter parametro_palabra_español = new SqlParameter();
                parametro_palabra_español.ParameterName = "@Español";
                parametro_palabra_español.SqlDbType = SqlDbType.VarChar;
                parametro_palabra_español.Size = 50;
                parametro_palabra_español.Value = Español.Español;
                comandos.Parameters.Add(parametro_palabra_español);


                SqlParameter parametro_descripcion = new SqlParameter();
                parametro_descripcion.ParameterName = "@Miskito";
                parametro_descripcion.SqlDbType = SqlDbType.VarChar;
                parametro_descripcion.Size = 256;
                parametro_descripcion.Value = Español.Miskito;
                comandos.Parameters.Add(parametro_descripcion);


                 SqlParameter parametro_imagen = new SqlParameter();
               parametro_imagen.ParameterName = "@imagen";
               parametro_imagen.SqlDbType = SqlDbType.VarBinary;
               parametro_imagen.Value = Español.Imagen;
               comandos.Parameters.Add(parametro_imagen);


               SqlParameter parametro_idaudio = new SqlParameter();
               parametro_idaudio.ParameterName = "@idaudio";
               parametro_idaudio.SqlDbType = SqlDbType.VarChar;
               parametro_idaudio.Value = Español.Idaudio;
               comandos.Parameters.Add(parametro_idaudio);

                //ejecucion de los comandos 
                respuesta = comandos.ExecuteNonQuery() == 1 ? "Palabra actualizada" : " NO se actualizó la palabra";



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










        public string Eliminar(DEspañol Español)
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
                comandos.CommandText = "eliminar_palabra";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_Idespañol = new SqlParameter();
                parametro_Idespañol.ParameterName = "@idespañol";
                parametro_Idespañol.SqlDbType = SqlDbType.Int;
                parametro_Idespañol.Value = Español.IdEspañol;
                comandos.Parameters.Add(parametro_Idespañol);

               

                //ejecucion de los comandos 
                respuesta = comandos.ExecuteNonQuery() == 1 ? "Eliminado" : " NO se Eliminó la palabra";



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
            DataTable dataresultado = new DataTable("Español");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = ClsConexion.conexion;
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "spmostrar_palabra";
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

        public DataTable Mostrar_miskito()
        {
            DataTable dataresultado = new DataTable("Español");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = ClsConexion.conexion;
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "spmostrar_miskito";
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

        public DataTable Buscar_palabra(DEspañol Español)
        {
            DataTable dataresultado = new DataTable("Español");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = ClsConexion.conexion;
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "spbuscar_palabra";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_buscar_palabra = new SqlParameter();
                parametro_buscar_palabra.ParameterName = "@buscarpalabra";
                parametro_buscar_palabra.SqlDbType = SqlDbType.VarChar;
                parametro_buscar_palabra.Size = 50;
                parametro_buscar_palabra.Value = Español.BuscarPalabra;
                comandos.Parameters.Add(parametro_buscar_palabra);

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

        public DataTable Buscar_miskito(DEspañol Español)
        {
            DataTable dataresultado = new DataTable("Español");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = ClsConexion.conexion;
                SqlCommand comandos = new SqlCommand();
                comandos.Connection = sqlcon;
                comandos.CommandText = "spbuscar_miskito";
                comandos.CommandType = CommandType.StoredProcedure;

                SqlParameter parametro_buscar_palabra = new SqlParameter();
                parametro_buscar_palabra.ParameterName = "@buscarmiskito";
                parametro_buscar_palabra.SqlDbType = SqlDbType.VarChar;
                parametro_buscar_palabra.Size = 50;
                parametro_buscar_palabra.Value = Español.BuscarPalabra;
                comandos.Parameters.Add(parametro_buscar_palabra);

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
