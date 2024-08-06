
namespace ProgramacionEstructurada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Class1
    {
        public static void Clase3(string[] args)
        {

            Console.Write("ingrese el primer numero:");
            var a = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("ingrese el segundo numero:");
            var b = float.Parse(Console.ReadLine());
            Console.Clear();

            Sumar(a, b);
            Restar(a, b);
            Multiplicar(a, b);
            Dividir(a, b);



            Console.WriteLine("Para salir presione una tecla cualquiera...");
            Console.ReadKey();

        }
        public static void Sumar(double a, float b)
        {
            double c = a + b;
            Console.WriteLine($"la suma de {a} mas {b} es igual a {c} ");
        }

        public static void Restar(double a, float b)
        {

            double c = a - b;

            Console.WriteLine($"Si restamos {a} menos {b} es igual a {c} ");
        }

        public static void Multiplicar(double a, float b) //*Multiplicar
        {

            double c = a * b;

            Console.WriteLine($"Si multiplicamos {a} por {b} es igual a {c}");
        }

        public static void Dividir(double a, float b) // /Dividir
        {

            double c = a / b;

            Console.WriteLine($"Si dividimos {a} por {b} es igual a {c}");
        }

        public static void DividirPorCero()
        {
            int m = 20;
            int n = 0;
            int o = m / n;

            Console.WriteLine($"{m} dividido {n} es igual a {o}");
        }
        public static void TareaClase3()
        {
            double a, b, c;

            Console.WriteLine("Ingrese el primer número: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            c = double.Parse(Console.ReadLine());
            Console.Clear();

            Suma(a, b, c);
            Console.WriteLine();
            Resta(a, c);
            Console.WriteLine();
            Multiplicación(a, b);
            Console.WriteLine();
            Division(a, b);
            Console.WriteLine();
            RestoDeLaDivision(b, c);
            Console.WriteLine();
            Console.WriteLine("Para salir presione una tecla cualquiera...");
            Console.ReadKey();
        }
        public static void Suma(double a, double b, double c)
        {
            double d = a + b + c;
            Console.WriteLine($"La suma de {a} mas {b} mas {c} es igual a {d} ");
        }
        public static void Resta(double a, double c)
        {
            double d = a - c;
            Console.WriteLine($"La resta entre {a} y {c} es igual a {d}");
        }
        public static void Multiplicación(double a, double b)
        {
            double d = a * b;
            Console.WriteLine($"La multiplicacion entre {a} y {b} es igual a {d}");
        }
        public static void Division(double a, double b)
        {
            double d = a / b;
            Console.WriteLine($"La division entre {a} y {b} es igual a {d}");

        }
        public static void RestoDeLaDivision(double b, double c)
        {
            double d = b % c;
            Console.WriteLine($"El resto de la division entre {b} y {c} es igual a {d}");
        }
    }
}
