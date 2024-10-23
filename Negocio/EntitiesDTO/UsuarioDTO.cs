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

    }
}
