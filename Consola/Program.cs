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
                Console.Write("Ingrese una opcion -> ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":                        
                        PressToContinue();
                        break;
                    case "2":                        
                        PressToContinue();
                        break;
                    case "3":                       
                        PressToContinue();
                        break;
                    case "4":
                        PressToContinue();
                        break;
                    case "5":
                        PressToContinue();
                        break;
                    case "0":
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        MostrarError("ERROR: Opcion inválida");
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
            Console.WriteLine("1 - Crear Usuario");
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - ");
            Console.WriteLine("0 - Salir ");
        }

        static void PressToContinue()
        {
            Console.WriteLine("Presione una tecla para continuar");
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

                if (!exito) MostrarError("ERROR: Debe ingresar solo numeros");
            }

            return numero;
        }

        public static void CrearUsuario()
        {
            Console.Clear();
            Console.WriteLine("****** CREAR USUARIO ******");
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese nacionalidad: ");
            string nacionalidad = Console.ReadLine();
            Console.Write("Ingrese el email: ");
            string mail = Console.ReadLine();
            Console.Write("Ingrese la contraseña: ");
            string contrasenia = Console.ReadLine();


            if (string.IsNullOrEmpty(nombre)) throw new Exception("El nombre no puede ser vacio");
            if (string.IsNullOrEmpty(apellido)) throw new Exception("El apellido no puede ser vacio");
            if (string.IsNullOrEmpty(nacionalidad)) throw new Exception("La nacionalidad no puede ser vacio");
            if (string.IsNullOrEmpty(mail)) throw new Exception("El email no puede ser vacio");
            if (string.IsNullOrEmpty(contrasenia)) throw new Exception("La contraseña no puede ser vacio");

            

        }
    }
}
