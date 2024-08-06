namespace ProgramacionOrientadaObjetos.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Conductor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double DNI { get; set; }
        public double Ahorros { get; set; }
        public double Kilometros { get; set; }
        public double Avanzar { get; set; }
        public double Retroceder { get; set; }
        public Auto Auto { get; set; }

        public Conductor()
        {

        }
        public Conductor(string nombre, string apellido, double dni, double ahorros)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Ahorros = ahorros;
        }

        public void AsignarAuto(Auto auto)
        {
            Console.Clear();
            Auto = auto;
        }

        public void MostrarAuto()
        {
            Console.Clear();
            if (Auto == null)
            {
                Console.WriteLine($"{Nombre} {Apellido} no tiene auto.");
            }
            else
            {
                Console.WriteLine($"{Nombre} {Apellido} posee un auto marca {Auto.Marca} modelo {Auto.Modelo}.");
            }
        }

        public void ComprarAuto(Auto auto, Conductor conductor2, Conductor conductor1)
        {

            Console.WriteLine($"{conductor1.Nombre} {conductor1.Apellido} le vende el auto a {conductor2.Nombre} {conductor2.Apellido}.");
            Console.ReadKey();
            Console.Clear();

            var RealizarCompra = CalcularCosto(auto.ValorEnPesos);

            if (RealizarCompra)
            {
                Console.WriteLine($"{conductor2.Nombre} {conductor2.Apellido} le compro el auto a {conductor1.Nombre}, de marca {auto.Marca} modelo {auto.Modelo}");
                Console.ReadKey();
                Console.Clear();
                conductor2.Ahorros -= auto.ValorEnPesos;
                AsignarAuto(auto);
                MostrarAuto();
                Console.WriteLine($"El dinero actual de {conductor2.Nombre} {conductor2.Apellido} es de ${conductor2.Ahorros}");
                Console.ReadKey();
                conductor1.Ahorros += auto.ValorEnPesos;
                Console.WriteLine($"El dinero actual de {conductor1.Nombre} {conductor1.Apellido} es de ${conductor1.Ahorros}");
                
            }
            else
            {
                Console.WriteLine($"No le alcanza para comprar el auto.");
            }
            Console.ReadKey();
            Console.Clear();
        }
        private bool CalcularCosto(double costo)
        {
            if (Ahorros >= costo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void VenderAuto(Auto auto, Conductor conductor)
        {
            Console.WriteLine($"{conductor.Nombre} {conductor.Apellido} vende un auto marca {auto.Marca}, modelo {auto.Modelo} a un costo de ${auto.ValorEnPesos}.");
            Console.ReadKey();
            Console.Clear();
        }

        public void ManejarAutoAvanza()
        {
            Console.WriteLine($"El condutor maneja el auto {Kilometros} Kilometros hacia delante");
        }
        public void ManejarAutoRetrocede()
        {
            var s = Math.Abs(Kilometros);
            Console.WriteLine($"El conductor maneja el auto {s} Kilometros hacia atras");

        }



    }
}
