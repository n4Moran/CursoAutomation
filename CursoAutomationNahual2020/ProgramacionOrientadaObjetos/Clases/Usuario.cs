namespace ProgramacionOrientadaObjetos.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Usuario
    {
        public string NombreDelUsuario { get; set; }
        public string ApellidoDelUsuario { get; set; }
        public string Mail { get; set; }
        public string Contraseña { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string DirecciónDelUsuario { get; set; }
        public int TelefonoDelUsuario { get; set; }

        public Usuario()
        {

        }

        public void Comprar()
        {
            Console.WriteLine($"{NombreDelUsuario} {ApellidoDelUsuario}, esta comprando:");
        }






    }
}
