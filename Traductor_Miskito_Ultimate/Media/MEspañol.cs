using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Media
{
    public class MEspañol
    {
        // instancia al metodo isertar de la clase DEspañol
        public static string Insertar(string español, string miskito, byte[] imagen, int idaudio)
        {
            DEspañol obj = new DEspañol();
            DAudio ob = new DAudio();
            obj.Español = español;
            obj.Miskito = miskito;
            obj.Imagen = imagen;
            obj.Idaudio = idaudio;
          

            return obj.Insertar(obj) ;

            
            
        }


        // instancia del metodo editar de la clase DEspañol
        public static string Editar(int idespañol, string español, string miskito, byte[] imagen, int idaudio)
        {
            DEspañol obj = new DEspañol();
            obj.IdEspañol = idespañol;
            obj.Español = español;
            obj.Miskito = miskito;
            obj.Imagen = imagen;
            obj.Idaudio = idaudio;
            return obj.Editar(obj);

        }

        // instancia del metodo eliminar de la clase DEspañol
        public static string Eliminar(int idespañol)
        {
            DEspañol obj = new DEspañol();
            obj.IdEspañol = idespañol;
          
            return obj.Eliminar(obj);

        }

        //  metodo mostrar que llama al metodo de la clase DEspañol en la capa datos

        public static DataTable Mostrar()
        {
            return new DEspañol().Mostrar();
        }

        public static DataTable Mostrar_miskito()
        {
            return new DEspañol().Mostrar_miskito();
        }

        public static DataTable Buscarpalabra(string buscarpalabra)
        {
            DEspañol obj = new DEspañol();
            obj.BuscarPalabra = buscarpalabra;
            return obj.Buscar_palabra(obj);
            
        }

        public static DataTable Buscarmiskito(string buscarmiskito)
        {
            DEspañol obj = new DEspañol();
            obj.BuscarPalabra = buscarmiskito;
            return obj.Buscar_miskito(obj);

        }

    }
}
