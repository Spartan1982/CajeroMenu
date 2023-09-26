using CajeroMenu.Servicios;

namespace CajeroMenu.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 250923 - jrp
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo de entrada de la aplicacion
        /// 250923 -jrp
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
           
            MenuInterfaz mi = new MenuImplementacion();
            mi.mostrarmensajeBienvenida();

            //variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //contener la opcion del usuario
            int opcionSeleccionada;


            //desde la primera iteracion debe cumplirse la condicion
            while (!cerrarMenu)
            {

                opcionSeleccionada = mi.mostrarMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO]- se ejecuta caso 0");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO]- se ejecuta caso 1");
                        break;

                    case 2:
                        Console.WriteLine("[INFO]- se ejecuta caso 2");
                        break;

                    case 3:
                        Console.WriteLine("[INFO]- se ejecuta caso 3");
                        break;

                    case 4:
                        Console.WriteLine("[INFO]- se ejecuta caso 4");
                        break;

                    case 5:
                        Console.WriteLine("[INFO]- se ejecuta caso 5");
                        break;

                    default:
                    
                      Console.WriteLine("[INFO] - La opcion seleccionada no esta disponible");
                        break;
                }

            }

        }
    }
}
