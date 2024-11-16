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
            this.Actividad = new HashSet<Actividad>();
        }

        public string DNI { get; set; }
        public virtual ICollection<Actividad> Actividad { get; set; }
    }
}

