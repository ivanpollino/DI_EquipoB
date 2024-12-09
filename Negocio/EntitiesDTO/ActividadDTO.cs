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
        public string DNI_Monitor { get; set; }

        public byte MediaValoracion { get; set; }

        public ActividadDTO()
        {
        }

        public ActividadDTO(int idActividad, string nombre, string descripcion, string dniMonitor)
        {
            Id_Actividad = idActividad;
            Nombre = nombre;
            Descripcion = descripcion;
            DNI_Monitor = dniMonitor;
            MediaValoracion = 1;
        }

    }
}
