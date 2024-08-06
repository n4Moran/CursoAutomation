namespace ProgramacionOrientadaObjetos.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public double ValorEnPesos { get; set; }
        public double Metros { get; set; }


        public Auto()
        {

        }
        public Auto( string marca, string modelo, string patente, double valorEnPesos)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            ValorEnPesos = valorEnPesos;
        }
        public void AutoAvanza()
        {
            Console.WriteLine($"El auto avanza {Metros} metros");
        }
        public void AutoRetrocede()
        {
            var s = Math.Abs(Metros);
            Console.WriteLine($"El auto retrocede {s} metros");
        }


    }
}
