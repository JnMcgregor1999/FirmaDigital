using System;
namespace Utn.FirmaDigital.Backend.Common
{
    public class Usuarios
    {
        public Usuarios()
        {
            Id = 0;
            Nombre = "";
            Contrasena = "";
            Email = "";
        }
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public String Contrasena { get; set; }
        public String Email { get; set; }
    }
}
