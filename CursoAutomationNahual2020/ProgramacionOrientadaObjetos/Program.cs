namespace ProgramacionOrientadaObjetos
{
    using ProgramacionOrientadaObjetos.Clases;
    using System;
    class Program
    {
        static double distanciaTotal = 0;
        static double avanzar = 0;
        static double retroceder = 0;
        static double metros = 0;
        static double parsearValor = 0;
        static void Main(string[] args)
        {
            var auto1 = new Auto();
            IngresarDatosDelAuto(auto1);

            var conductor1 = new Conductor();
            IngresarDatosDelConductor(conductor1);
            conductor1.AsignarAuto(auto1);
            conductor1.MostrarAuto();
            Console.ReadKey();
            Console.Clear();

            var conductor2 = new Conductor("Natt", "Hiporre", 42345567, 1000000);
            conductor2.MostrarAuto();
            Console.ReadKey();
            Console.Clear();

            conductor1.VenderAuto(auto1, conductor1);
            conductor2.ComprarAuto(auto1, conductor2, conductor1);


            var metros = new Auto();
            var kilometros = new Conductor();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            ConsignaIngresarNumeros();
            DistanciaRecorrida(kilometros, metros);


        }

        public static void IngresarDatosDelConductor(Conductor conductor)
        {
            Console.Clear();
            Console.WriteLine("Ingrese Los datos del conductor");
            Console.WriteLine("Ingresar nombre:");
            conductor.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresar apellido:");
            conductor.Apellido = Console.ReadLine();
            Console.WriteLine("Ingresar DNI:");
            conductor.DNI = ParsearValor();
            Console.WriteLine("Ingresar ahorros:");
            conductor.Ahorros = ParsearValor();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
        public static void IngresarDatosDelAuto(Auto auto)
        {
            Console.Clear();
            Console.WriteLine("Ingrese los datos del auto");
            Console.WriteLine("Ingresar marca:");
            auto.Marca = Console.ReadLine();
            Console.WriteLine("Ingresar modelo:");
            auto.Modelo = Console.ReadLine();
            Console.WriteLine("Ingresar patente:");
            auto.Patente = Console.ReadLine();
            Console.WriteLine("Ingresar valor en pesos:");
            auto.ValorEnPesos = ParsearValor();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();

        }
        private static double ParsearValor()
        {
            try
            {
                var valor = Console.ReadLine();
                parsearValor = double.Parse(valor);

            }
            catch (Exception)
            {
                Console.WriteLine("El valor ingresado no es valido, intente nuevamente.");
                ParsearValor();
            }
            return parsearValor;


        }
        public static void ConsignaIngresarNumeros()
        {
            Console.Clear();
            Console.WriteLine("A contunuación podrá ingresar valores numéricos:");
            Console.WriteLine("Si ingresa un valor positivo se avanzara esa cantidad de kilómetros");
            Console.WriteLine("si ingresa un valor negativo se retrocede esa cantidad de kilómetros.");
            Console.WriteLine("Al ingresar el 0 se le informara a cuántos metros está del punto inicial.");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        public static double IngresarValoresNumericos()
        {

            try
            {
                Console.WriteLine("Ingrese un número");
                metros = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("El valor ingresado no es un valido, intente nuevamente.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                IngresarValoresNumericos();
            }
            return metros;
        }
        public static void DistanciaRecorrida(Conductor kilometros, Auto metros)
        {
            metros.Metros = IngresarValoresNumericos();
            kilometros.Kilometros = metros.Metros / 1000;

            while (!(kilometros.Kilometros == 0))
            {
                if (kilometros.Kilometros > 0)
                {
                    avanzar += metros.Metros;
                    kilometros.ManejarAutoAvanza();
                    metros.AutoAvanza();

                }
                else if (kilometros.Kilometros < 0)
                {
                    retroceder += metros.Metros;
                    kilometros.ManejarAutoRetrocede();
                    metros.AutoRetrocede();
                }
                Console.ReadKey();
                Console.Clear();
                DistanciaRecorrida(kilometros, metros);

            }

            distanciaTotal = avanzar + retroceder;

            if (distanciaTotal > 0)
            {
                Console.WriteLine($"El conductor avanzo {distanciaTotal} metros del punto de partida");
            }
            else if (distanciaTotal < 0)
            {
                var s = Math.Abs(distanciaTotal);
                Console.WriteLine($"El conductor retrocedio {s} metros del punto de partida.");
            }
            else
            {
                Console.WriteLine("El conductor sigue en el punto de partida");
            }
            Console.ReadKey();
            

        }

    }
}
