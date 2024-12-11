using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class UsuarioActividadDTO
    {
        public string DNI { get; set; }
        public int Id_Actividad { get; set; }
        public Nullable<byte> Valoracion { get; set; }

        public UsuarioActividadDTO(string dni, int id_actividad) { 
            this.DNI = dni;
            this.Id_Actividad = id_actividad;
            Valoracion = null;
        }

        public UsuarioActividadDTO() { 
        
        
        }
    }
}
