namespace ProgramacionEstructurada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        public static void Main(string[] args)
        {
            IngresarValores();
            Console.WriteLine("Presione una tecla para salir..");
            Console.ReadKey();
        }

        public static void IngresarValores()
        {
            double sumar, CantidadDeNúmeros, promedio; // min, max;
            sumar = 0;
            CantidadDeNúmeros = 0;
            Console.WriteLine("Ingrese valores numericos hasta que el valor sea multiplo de 3, multiplo de 7 y ademas sea mayor a 300 y menor a 1000");
            bool exit = false;

            while (!exit)
            {
                var número = ValorIngresado();
                sumar += número;
                CantidadDeNúmeros++;
                promedio = sumar / CantidadDeNúmeros;
                //min = double.MinValue;
                //max = double.MaxValue;


                if (número % 3 == 0 && número % 7 == 0 && número > 300 && número < 1000)
                {

                    Console.WriteLine("El valor ingresado es multiplo de 3, multiplo de 7 y ademas es mayor a 300 y menor a 1000");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    exit = true;

                }
                else if (número == -672389892382)
                {
                    Console.WriteLine("El valor ingresado no es un número intente nuevamente...");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    ValorIngresado();
                }
                else
                {
                    
                    ValorIngresado();
                }

            }
            promedio = sumar / CantidadDeNúmeros;
            Console.WriteLine($"El promedio de los valores ingresados es {promedio}");
            Console.WriteLine($"La cantidad de numeros ingresados fueron {CantidadDeNúmeros}");
            Console.WriteLine($"La suma de los números ingresados es {sumar}");
            Console.WriteLine($"El valor mínimo ingresado es ");
            Console.WriteLine($"El valor máximo ingresado es ");
            Console.ReadKey();

        }


        public static double ValorIngresado()
        {
            double número;
            try
            {
               
                var parsednúmero = Console.ReadLine();
                número = double.Parse(parsednúmero);
            }
            catch (Exception)
            {
                número = -672389892382;
            }
            return número;
        }

    }


}

