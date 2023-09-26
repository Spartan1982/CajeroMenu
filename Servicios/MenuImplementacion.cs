using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenu.Servicios
{

    /// <summary>
    /// Clase que implementa la interfaz del menu
    /// 250923 - jrp
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarmensajeBienvenida()
        {

            string mensaje = "Banco CSI1";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion() { 
                int opcionIntroducida;
                Console.WriteLine("#########################");
                Console.WriteLine("0. Cerrar aplicacion");
                Console.WriteLine("1. Darse de alta");
                Console.WriteLine("2. Ingresar dinero");
                Console.WriteLine("3. Sacar dinero");
                Console.WriteLine("Transferir dineo");
                Console.WriteLine("5. Historial operaciones");
                Console.WriteLine("############################");
                Console.WriteLine("Seleccione una opcion:");

                opcionIntroducida = Console.ReadKey(true).KeyChar-('0');

                return opcionIntroducida;

            
        }
    }
}
