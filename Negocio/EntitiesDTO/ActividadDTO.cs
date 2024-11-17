using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class ActividadDTO
    {
        public int Id_Actividad { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<MonitorDTO> Monitor { get; set; }

        public ActividadDTO()
        {
            Monitor = new HashSet<MonitorDTO>();
        }
    }

}
