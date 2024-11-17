using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorys
{
    public class ActividadRepository
    {
        /// <summary>
        /// Elimina una actividad de la base de datos.
        /// </summary>
        /// <param name="actividad">La actividad que se desea eliminar.</param>
        /// <returns>Un mensaje de éxito indicando que la actividad ha sido eliminada correctamente.</returns>
        public String bajaActividad(Actividad actividad)
        {
            using (var contexto = new equipobEntities())
            {
                var actividadExistente = contexto.Actividad.Find(actividad.Id_Actividad);
                if (actividadExistente != null)
                {
                    contexto.Actividad.Remove(actividadExistente);
                    contexto.SaveChanges();
                }
                else
                {
                    return "Actividad no encontrada";
                }
            }
            return "Actividad borrada con exito";
        }
        /// <summary>
        /// Recupera una actividad de la base de datos a partir de su nombre.
        /// </summary>
        /// <param name="actividad">La actividad que se desea buscar (por nombre).</param>
        /// <returns>La actividad encontrada en la base de datos, o un objeto vacío si no se encuentra ninguna coincidencia.</returns>
        public Actividad sacarActividad(Actividad actividad)
        {
            Actividad actividadAux = new Actividad();
            using (var contexto = new equipobEntities())
            {
                actividadAux = contexto.Actividad.FirstOrDefault(a => a.Nombre == actividad.Nombre);
            }
            return actividadAux;
        }
        /// <summary>
        /// Obtiene una lista de todas las actividades almacenadas en la base de datos.
        /// </summary>
        /// <returns>Una lista con todas las actividades de la base de datos.</returns>
        public List<Actividad> listadoActividades()
        {
            List<Actividad> actividades = new List<Actividad>();

            using (var contexto = new equipobEntities())
            {
                actividades = contexto.Actividad.ToList();
            }

            return actividades;
        }
        /// <summary>
        /// Obtiene el próximo ID disponible para una nueva actividad, basado en el último ID utilizado.
        /// </summary>
        /// <returns>El siguiente ID disponible para una nueva actividad.</returns>
        public int ObtenerNuevoIdActividad()
        {
            using (var context = new equipobEntities())
            {
                var ultimoId = context.Actividad
                                      .OrderByDescending(a => a.Id_Actividad)
                                      .FirstOrDefault()?.Id_Actividad ?? 0; // Si no hay actividades devuelve 0
                return ultimoId + 1;
            }
        }
        /// <summary>
        /// Recupera un monitor de la base de datos utilizando su DNI.
        /// </summary>
        /// <param name="dniMonitor">El DNI del monitor que se desea buscar.</param>
        /// <returns>El monitor encontrado o null si no se encuentra ningún monitor con ese DNI.</returns>
        public Monitor ObtenerMonitorPorDni(string dniMonitor)
        {
            using (var context = new equipobEntities())
            {
                return context.Monitor.FirstOrDefault(m => m.DNI == dniMonitor);
            }
        }
        /// <summary>
        /// Guarda una nueva actividad en la base de datos.
        /// </summary>
        /// <param name="actividad">La actividad que se desea guardar.</param>
        public void GuardarActividad(Actividad actividad)
        {
            using (var context = new equipobEntities())
            {
                context.Actividad.Add(actividad);
                context.SaveChanges();
            }
        }
    }
}
