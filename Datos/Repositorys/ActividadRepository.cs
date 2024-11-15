using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorys
{
    public class ActividadRepository
    {
        public String bajaActividad(Actividad actividad)
        {
            using (var contexto = new equipobEntities3())
            {
                contexto.Actividad.Remove(actividad);
                contexto.SaveChanges();

            }
            return "Actividad borrada con exito";
        }
        public Actividad sacarActividad(Actividad actividad) {
            Actividad actividadAux = new Actividad();
            using (var contexto = new equipobEntities3())
            {
                actividadAux = contexto.Actividad.FirstOrDefault(a => a.Nombre == actividad.Nombre);
            }
            return actividadAux;
        }

        public int ObtenerProximoIdActividad()
        {
            using (var contexto = new equipobEntities3())
            {
                return contexto.Actividad.Any() ?
                    contexto.Actividad.Max(a => a.Id_Actividad) + 1 : 1;
            }
        }

        public void RegistrarActividad(Actividad nuevaActividad)
        {
            using (var contexto = new equipobEntities3())
            {
                contexto.Actividad.Add(nuevaActividad);
                contexto.SaveChanges();
            }
        }
        /*public void RegistrarMonitorActividad(int idActividad, string dniMonitor)
        {
            using (var contexto = new equipobEntities3())
            {
                var relacion = new Monitor_Actividad
                {
                    Id_Actividad = idActividad,  
                    DNI = dniMonitor 
                };

                contexto.Monitor_Actividad.Add(relacion);
                contexto.SaveChanges(); 
            }
        }*/
    }
}
