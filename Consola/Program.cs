using Dominio;
namespace Consola
{
    internal class Program
    {
        static Sistema miSistema;

        static void Main(string[] args)
        {

            miSistema = new Sistema();

            string opcion = "";
            while (opcion != "0")
            {
                MostrarMenu();
                Console.Write("Ingrese una opción -> ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        //Listar Clientes
                        ListadoClientes();
                        break;
                    case "2":
                    // Listar vuelos por codigo de aeropuerto

                    case "3":
                        //Alta Cliente Ocasional
                        CrearClienteOcasional();

                        break;
                    case "4":
                    // Listar pasajes entre fechas  


                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        MostrarError("ERROR: Opción inválida");
                        PressToContinue();
                        break;
                }
            }

        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****** MENU ******");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1 - Listar Clientes");
            Console.WriteLine("2 - Listar vuelos por código de aeropuerto");
            Console.WriteLine("3 - Alta Cliente Ocasional");
            Console.WriteLine("4 - Listar pasajes entre fechas");
            Console.WriteLine("0 - Salir");
        }

        static void PressToContinue()
        {
            Console.WriteLine("Presione una tecla para continuar…");
            Console.ReadKey();
        }

        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void MostrarExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static string PedirPalabras(string mensaje)
        {
            Console.Write(mensaje);
            string dato = Console.ReadLine();
            return dato;
        }

        static int PedirNumeros(string mensaje)
        {
            bool exito = false;
            int numero = 0;
            while (!exito)
            {
                Console.Write(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);

                if (!exito) MostrarError("ERROR: Debe ingresar solo números");
            }

            return numero;
        }

        public static void CrearClienteOcasional()
        {
            Console.Clear();
            Console.WriteLine("**** CREAR CLIENTE OCASIONAL ****");
            Console.WriteLine();

            string documento = PedirPalabras("Ingrese el documento del cliente: ");
            string nombre = PedirPalabras("Ingrese el nombre del cliente: ");
            string nacionalidad = PedirPalabras("Ingrese la nacionalidad del cliente: ");
            string mail = PedirPalabras("Ingrese el mail del cliente: ");
            string contrasenia = PedirPalabras("Ingrese la contraseña del cliente: ");
            try
            {
                Cliente cl = new Cliente(documento, nombre, mail, contrasenia, nacionalidad);
                miSistema.AgregarUsuario(cl);
                MostrarExito("Cliente agregado correctamente...");
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }

        }

        public static void ListadoClientes()
        {
            Console.Clear();
            Console.WriteLine("**** LISTADO DE CLIENTES ****");
            Console.WriteLine();

            try
            {
                List<Cliente> listaClientes = miSistema.ListaUsuarios;
                if (listaClientes.Count == 0) throw new Exception("No hay clientes registrados en el sistema.");
                foreach (Cliente c in listaClientes)
                {
                    Console.WriteLine(c.ToString());
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
        }
    }
}
