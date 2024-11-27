using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class UsuarioActiviadDTO
    {
        public string DNI { get; set; }
        public int Id_Actividad { get; set; }
        public Nullable<byte> Valoracion { get; set; }

        public virtual Actividad Actividad { get; set; }
        public virtual Usuario_Normal Usuario_Normal { get; set; }
    }
}
