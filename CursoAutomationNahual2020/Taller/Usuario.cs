namespace Taller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Usuario
    {
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string MailUsuario { get; set; }
        private string Contraseña { get; set; }
        public string DireccionUsuario { get; set; }
        public int TelefonoUsuario { get; set; }
        public Usuario()
        {
        }
        public Usuario(string nombre, string apellido, string Mail, string adress, string contraseña, int PhoneNumber)
        {
            NombreUsuario = nombre;
            ApellidoUsuario = apellido;
            MailUsuario = Mail;
            Contraseña = contraseña;
            DireccionUsuario = adress;
            TelefonoUsuario = PhoneNumber;
        }
        public Usuario(string Mail, string contraseña)
        {
            MailUsuario = Mail;
            Contraseña = contraseña;
        }

        public bool ValidarContraseña(string pass)
        {
            return Contraseña.Equals(pass);
        }
    }

}
