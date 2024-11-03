using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class UsuarioDTO
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Direccion { get; set; }
        public string Cuenta_Corriente { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }

        public UsuarioDTO(string dNI, string nombre, string apellidos, int? telefono, string direccion, string cuenta_Corriente, string email, string passwd)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            Cuenta_Corriente = cuenta_Corriente;
            Email = email;
            Passwd = passwd;
        }
        public UsuarioDTO()
        {

        }
    }
}
