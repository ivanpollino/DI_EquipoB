using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.EntitiesDTO
{
    public class MonitorDTO
    {
        public MonitorDTO()
        {
            this.Actividades = new HashSet<ActividadDTO>();
        }

        public string DNI { get; set; }

        // Relación uno a muchos: Un monitor tiene múltiples actividades
        public virtual ICollection<ActividadDTO> Actividades { get; set; }
    }
}

