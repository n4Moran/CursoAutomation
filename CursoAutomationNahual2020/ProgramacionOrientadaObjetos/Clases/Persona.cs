namespace ProgramacionOrientadaObjetos.Clases
{
    using System;
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string LugarDeNacimiento { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string EmpresaDeTrabajo { get; set; }
        public string PuestoDeTrabajo { get; set; }
        
        public Persona()
        {

        }

        public void Caminar()
        {
            Console.WriteLine($"{Nombre} {Apellido}, de {Edad} años, esta caminando.");
        }
        public void Saludar()
        {
            Console.WriteLine($"{Nombre} {Apellido}, de {Edad} años, esta saludando.");
        }
        public void FestejarCumpleaños()
        {
            Console.WriteLine($"{Nombre} {Apellido} de {Edad} años, Festeja su cumpleaños.");
        }
        public void Trabajar()
        {
            Console.WriteLine($"{Nombre} {Apellido} esta Trabajando como {PuestoDeTrabajo} en la empresa {EmpresaDeTrabajo}.");
        }
       
       

    }
}
