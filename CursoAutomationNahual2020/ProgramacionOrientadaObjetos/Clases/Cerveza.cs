namespace ProgramacionOrientadaObjetos.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Cerveza
    {
        public string Marca { get; set; }
        public int Precio { get; set; }
        public double Peso { get; set; }
        public string Procedencia { get; set; }


        public Cerveza()
        {

        }

        public void ComprarCerveza()
        {
            Console.WriteLine($"Una cerveza marca {Marca} a ${Precio}, de {Procedencia} y que pesa {Peso} kg.");
        }


    }
}
