using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(frmagregarEspañol.GetInstancia());
            Application.Run(new frmprincipal());
            //Application.Run(new grabar_audio());
            //Application.Run(new FRMLogin());
            //Application.Run(new Agregar_Audio());
        }
    }
}
