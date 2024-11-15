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
            using (var contexto = new equipobEntities())
            {
                contexto.Actividad.Remove(actividad);
                contexto.SaveChanges();

            }
            return "Actividad borrada con exito";
        }
        public Actividad sacarActividad(Actividad actividad) {
            Actividad actividadAux = new Actividad();
            using (var contexto = new equipobEntities())
            {
                actividadAux = contexto.Actividad.FirstOrDefault(a => a.Nombre == actividad.Nombre);
            }
            return actividadAux;
        }

        public List<Actividad> listadoActividades()
        {
            List<Actividad> actividades = new List<Actividad>();

            using (var contexto = new equipobEntities())
            {
                actividades = contexto.Actividad.ToList();
            }

            return actividades;
        }
    }
}
