using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos.Clases
{
    class Banana
    {
        public string Marca { get; set; }
        public int Precio { get; set; }
        public double Peso { get; set; }
        public string Procedencia { get; set; }


        public Banana()
        {

        }

        public void ComprarBanana()
        {
            Console.WriteLine($"Una banana marca {Marca} a ${Precio}, de {Procedencia} y que pesa {Peso} kg.");
        }



    }
}
