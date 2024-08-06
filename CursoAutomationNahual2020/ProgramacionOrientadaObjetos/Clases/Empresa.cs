namespace ProgramacionOrientadaObjetos.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Empresa
    {
        public string Nombre { get; set; }
        public string Cuil { get; set; }
        public string Rama { get; set; }
        public string CantidadDeEmpleados { get; set; }

        public Empresa()
        {

        }

        public void PagarSueldos()
        {
            Console.WriteLine($"La empresa {Nombre} número de cuil {Cuil}, le esta pagando a sus empleados.");
        }
        public void PagarVacaciones()
        {
            Console.WriteLine($"La empresa {Nombre} número de cuil {Cuil}, le esta pagando las vacaciones a sus empleados.");
        }
        


    }
}
