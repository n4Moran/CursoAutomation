namespace Taller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static List<Usuario> UsuariosGuardados = new List<Usuario>();
        static void Main(string[] args)
        {
            Console.Title = "Carrito Nahual";
            bool exit = false;
            while (!exit)
            {
                PresentarMenu();
                var Opcion = ValorIngresado();
                switch (Opcion)
                {
                    case 1:
                        RegistrarUsuario();
                        break;
                    case 2:
                        LoginUsuario();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Gracias por pasar...");
                        Console.ReadKey();
                        exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opcion valida.");
                        Console.WriteLine("Presione una tecla cualquiera para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public static void PresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("Elija una de las siguientes opciones");
            Console.WriteLine("1- Registrar usuario");
            Console.WriteLine("2- Login");
            Console.WriteLine("3- Salir");
        }
        public static int ValorIngresado()
        {
            int valor = 0;
            try
            {
                var parsevalor = Console.ReadLine();
                valor = int.Parse(parsevalor);
            }
            catch (Exception)
            {
                valor = -1;
            }
            return valor;
        }
        public static void RegistrarUsuario()
        {
            Console.Clear();
            Console.WriteLine("A continuacion ingrese los siguientes datos:");
            Console.Write("Nombre: ");
            var nombreUsuario = Console.ReadLine();
            Console.Write("Apellido: ");
            var apellidoUsuario = Console.ReadLine();
            Console.Write("E-mail: ");
            var mailUsuario = Console.ReadLine();
            Console.Write("Constraseña: ");
            var contraseña = Console.ReadLine();
            Console.Write("Dirección: ");
            var direccionUsuario = Console.ReadLine();
            Console.Write("Teléfono: ");
            var telefonoUsuario = int.Parse(Console.ReadLine());
            var usuario = new Usuario(nombreUsuario, apellidoUsuario, mailUsuario, direccionUsuario, contraseña, telefonoUsuario);
            UsuariosGuardados.Add(usuario);
            Console.Clear();
            Console.WriteLine("Registro Exitoso");
            Console.WriteLine("Presione una tecla para continuar....");
            Console.ReadKey();
        }
        public static void LoginUsuario()
        {
            Console.Clear();
            Console.Write("Ingrese su mail: ");
            var email = Console.ReadLine();
            Console.Write("Ingrese su Contraseña: ");
            var contraseña = Console.ReadLine();
            Usuario us = null;
            foreach (var usuario in UsuariosGuardados)
            {
                if (usuario.MailUsuario.Equals(email) && usuario.ValidarContraseña(contraseña))
                {
                    us = usuario;
                    break;
                }
            }

            if (us != null)
            {
                Console.Clear();
                Console.WriteLine("Logeo Exitoso");
                Console.WriteLine($"Bienvenid@ {us.NombreUsuario}");
                Console.WriteLine("Presione una tecla para continuar....");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Los datos ingresados no son correctos");
                Console.WriteLine("Por favor intentelo nuevamente");
                Console.WriteLine("Presione una tecla para continuar....");
                Console.ReadKey();
            }
        }
    }

}
