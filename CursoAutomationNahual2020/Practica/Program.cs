namespace Practica
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static string mail;
        static string pass;

        static void Main(string[] args)
        {
            Console.Title = "Carrito Nahal";
            bool exit = false;

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
                    LoginDeUsuario();
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
            Console.ReadKey();
        }

        private static void PresentarMenu()
        {
            Console.WriteLine("Bienvenido Carrito ingrese una de las siguientes opciones:");
            Console.WriteLine("1- Registrarse");
            Console.WriteLine("2- Login");
            Console.WriteLine("3- Salir");

        }

        private static int GuardarOpcion()
        {
            return int.Parse(Console.ReadLine());
           
        }

        private static void RegistrarUsuario()
        {
            Console.WriteLine("ingresar email:");
            var mail = Console.ReadLine();
            Console.WriteLine("ingresar contraseña:");
            var pass = Console.ReadLine();

        }

        private static void LoginDeUsuario()
        {
            Console.WriteLine("ingrese su mail");
            var email = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña");
            var password = Console.ReadLine();
        }
    }
}
