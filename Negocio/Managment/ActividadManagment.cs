using Datos.Infrastructure;
using Datos.Repositorys;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Managment
{
    public class ActividadManagment
    {
        /// <summary>
        /// Elimina una actividad de la base de datos utilizando su DTO.
        /// </summary>
        /// <param name="actividadDTO">El DTO que representa la actividad a eliminar.</param>
        /// <returns>Un mensaje de éxito indicando que la actividad fue eliminada.</returns>
        public String bajaActividad(ActividadDTO actividadDTO)
        {
            Actividad actividad = new Actividad();
            ActividadRepository datos = new ActividadRepository();
            actividad.Nombre = actividadDTO.Nombre;
            Actividad actividadBase = datos.sacarActividad(actividad);

            actividad.Id_Actividad = actividadBase.Id_Actividad;
            actividad.Nombre = actividadBase.Nombre;
            actividad.Descripcion = actividadBase.Descripcion;

            return datos.bajaActividad(actividad);

        }
        /// <summary>
        /// Obtiene todas las actividades desde la base de datos y las convierte en una lista de DTOs.
        /// </summary>
        /// <returns>Una lista de DTOs que representa todas las actividades.</returns>
        public List<ActividadDTO> ObtenerActividades()
        {
            List<Actividad> actividades = new Datos.Repositorys.ActividadRepository().listadoActividades();
            List<ActividadDTO> listaDTO = new List<ActividadDTO>();
            foreach (Actividad actividadNormal in actividades)
            {
                ActividadDTO aux = new ActividadDTO();
                aux.Id_Actividad = actividadNormal.Id_Actividad;
                aux.Nombre = actividadNormal.Nombre;
                aux.Descripcion = actividadNormal.Descripcion;

                listaDTO.Add(aux);
            }
            return listaDTO;
        }
        /// <summary>
        /// Registra una nueva actividad en la base de datos.
        /// Asocia un monitor con la actividad usando su DNI.
        /// </summary>
        /// <param name="nuevaActividad">El DTO que representa la nueva actividad que se desea registrar.</param>
        /// <param name="dniMonitor">El DNI del monitor que se asociará con la actividad.</param>
        public void RegistrarActividad(ActividadDTO nuevaActividad)
        {
            ActividadRepository actividadRepository = new ActividadRepository();
            MonitorRepository monitorRepository = new MonitorRepository();

            // Obtenemos un nuevo ID para la actividad
            int nuevoId = actividadRepository.ObtenerNuevoIdActividad();

            // Creamos una nueva instancia de actividad
            Actividad actividad = new Actividad
            {
                Id_Actividad = nuevoId,
                Nombre = nuevaActividad.Nombre,
                Descripcion = nuevaActividad.Descripcion,
            };

            List<Monitor> monitores = new List<Monitor>();

            // Procesamos cada monitor
            foreach (var dto in nuevaActividad.Monitor)
            {
                // Verificamos si el monitor ya existe en la base de datos
                var monitorExistente = monitorRepository.ObtenerMonitorPorDni(dto.DNI);

                if (monitorExistente != null)
                {
                    // Si el monitor ya existe, simplemente lo asociamos
                    monitores.Add(monitorExistente);
                }
                else
                {
                    // Si el monitor no existe, lo creamos e insertamos
                    Monitor nuevoMonitor = new Monitor
                    {
                        DNI = dto.DNI
                    };

                    // Insertamos el nuevo monitor
                    string resultadoInsercion = monitorRepository.AltaMonitor(nuevoMonitor);

                    // Verificamos el resultado de la inserción
                    if (resultadoInsercion.Contains("ya existe"))
                    {
                        // Si ya existe, lo asociamos sin intentar insertarlo nuevamente
                        monitores.Add(monitorRepository.ObtenerMonitorPorDni(dto.DNI));
                    }
                    else
                    {
                        // Si el monitor fue insertado correctamente, lo agregamos a la lista
                        monitores.Add(nuevoMonitor);
                    }
                }
            }

            // Asociamos los monitores a la actividad
            actividad.Monitor = monitores;

            // Guardamos la actividad en la base de datos
            actividadRepository.GuardarActividad(actividad);
        }
    }
}
