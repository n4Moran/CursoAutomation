

namespace Carrito
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static string firstName;
        static string lastName;
        static string email = "a@a.com";
        static string birthday;
        static string Adress;
        static string phone;
        static int password = 0;
        static void Main(string[] args)
        {
            Console.Title = "Carrito Nahual";
            var exit = false;
            while (!exit)
            {
                PresentarMenu();
                var opcion = GuardarOpcion();

                if (opcion == 1)
                {
                    RegistrarUsuario();
                }
                else if (opcion == 2)
                {
                    LoginUsuario();
                }
                else if (opcion == 3)
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("La opcion ingresada no es valida");
                }
            }


            Console.WriteLine(email);
            Console.WriteLine(password);
            Console.WriteLine("Para salir presione una tecla cualquiera");
            Console.ReadLine();

        }

        private static void PresentarMenu()
        {
            Console.WriteLine("Bienvenido a carrito. Elija una de las siguientes opciones:");
            Console.WriteLine("1 - Registrarse");
            Console.WriteLine("2 - Login");
            Console.WriteLine("3 - Salir");
        }

        private static int GuardarOpcion()
        {
            Console.Clear();
            var opcion = Console.ReadLine();
            return int.Parse(opcion);
        }

        private static void RegistrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su mail: ");
            email = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña: ");
            password = Console.ReadLine();
            
        }

        private static void LoginUsuario()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su mail: ");
            var mail = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            var pass = Console.ReadLine();

            if("password" == "pass" && "email" == "mail")
            {
                Console.WriteLine("Login correcto. Bienvenido a carrito");
            }
            else
            {
                Console.WriteLine("El usuario y/o la contraseña es incorrecta, intente nuevamente");
            }
        }
    }
}
