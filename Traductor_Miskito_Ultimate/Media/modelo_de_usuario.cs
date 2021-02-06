using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Media
{
    public class modelo_de_usuario
    {
        InicioSesion sesion = new InicioSesion();   

        public bool LoginUser(string user, string pass)
        {
            return sesion.login(user, pass);
        } 
    }
}
