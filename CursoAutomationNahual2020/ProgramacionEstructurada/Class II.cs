
namespace ProgramacionEstructurada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Class_II
    {
        public static void VariableConstante()
        {
            const string name = "Natasha";
            const bool verdadero = true;
            const int one = 1;

            string surname = "Apellido";
            var two = 2;
            bool falso = false;

            Console.WriteLine(name);
            Console.WriteLine(verdadero);
            Console.WriteLine(one);
            Console.WriteLine(surname);
            Console.WriteLine(two);
            Console.WriteLine(falso);
        }

        /* public static void Main(string[] args)
        {
            Console.WriteLine("Debera ingresar 10 numero.");
            IngresarValor();
            Console.WriteLine("Presione una tecla cualquiera para finalizar...");
            Console.ReadKey();
        }
        public static void IngresarValor()
        {
            double i, valor, promedio;
            double suma = 0;
            //minimo = valor;
            //maximo= valor;
            for (i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero:");
                valor = ValorIngresado();
                suma = suma + valor;
                //minimo = (minimo <= valor);
                //maximo = (maximo >= valor);
            }
            promedio = suma / 10;
            Console.WriteLine("Usted a ingresado los 10 numero, presione una tecla cualquiera para continuar.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"La suma de los valores ingresados es de:{suma}");
            Console.WriteLine($"El promedio de los valores ingresados es de:{promedio}");
            //Console.WriteLine($"El minimo de los valores ingresado es de:{minimo}");
            //Console.WriteLine($"El maximo de los valores ingresado es de:{maximo}");
        }
        public static double ValorIngresado()
        {
            double valor = 0;
            try
            {
                var parsevalor = Console.ReadLine();
                valor = double.Parse(parsevalor);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Lo ingreado no es un numero.Intentelo nuevamente.");
                Console.WriteLine("Presione una tecla cualquiera para continuar...");
                Console.ReadKey();
                Console.Clear();
                IngresarValor();
            }
            return valor;
        }
     } */



   

        /* public static void Main(string[] args)
            {

        IngresarValoresNuméricos();
        ValorIngresado();
        Console.WriteLine("Para finalizar toque una tecla cualquiera..");
        Console.ReadKey();

            }
        public static void IngresarValoresNuméricos()
                {
        Console.Clear();
        Console.WriteLine("Ingrese 10 veces un valor numérico:");
        double valor = ValorIngresado();
        Console.Clear();
        Valor(valor);
        Console.ReadKey();

        }
        public static double ValorIngresado()
            {
        double valor = 0;
        try
        {
            var parsevalor = Console.ReadLine();
            valor = double.Parse(parsevalor);
        }
        catch (Exception)
        {
            Console.Clear();
            Console.WriteLine("El valor ingresado no es un número. Intentelo nuevamente.");
            Console.WriteLine("Presione una tecla cualquiera para continuar...");
            Console.ReadKey();
            IngresarValoresNuméricos();

        }
        return valor;
        }       
        public static void Valor(double valor)
        {
        while (valor > 0)
        {
            Console.WriteLine(valor);
            valor -= 1;

        }

            }
        public static void ValorMaximo()
        {

            }*/







    }
}
