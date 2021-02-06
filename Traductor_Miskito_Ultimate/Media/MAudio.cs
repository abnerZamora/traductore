using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Datos;

namespace Media
{
    public class MAudio
    {

        public static string Insertar(string nombre, string direccion)
        {
            DAudio obj = new DAudio();
            obj.Nombre = nombre;
            obj.Direccion = direccion;
            return obj.Insertar(obj);
        }


        // instancia del metodo editar de la clase DEspañol
        public static string Editar(int idaudio, string nombre, string direccion)
        {
            DAudio obj = new DAudio();
            obj.Idaudio = idaudio;
            obj.Nombre = nombre;
            obj.Direccion = direccion;
           
            return obj.Editar(obj);

        }

        // instancia del metodo eliminar de la clase DEspañol
        public static string Eliminar(int idaudio)
        {
            DAudio obj = new DAudio();
            obj.Idaudio = idaudio;

            return obj.Eliminar(obj);

        }

        //  metodo mostrar que llama al metodo de la clase DEspañol en la capa datos

        public static DataTable Mostrar()
        {
            return new DAudio().Mostrar();
        }

        public static DataTable Buscarpalabra(string buscarpalabra)
        {
            DAudio obj = new DAudio();
            obj.Buscaraudio = buscarpalabra;
            return obj.Buscar_audio(obj);

        }
    }
}
