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

            actividad.Id_Actividad = actividadDTO.Id_Actividad;
            actividad.Nombre = actividadDTO.Nombre;
            actividad.Descripcion = actividadDTO.Descripcion;
            actividad.DNI_Monitor = actividadDTO.DNI_Monitor;
            actividad.Media_Valoracion = (decimal?)actividadDTO.MediaValoracion;

            return new Datos.Repositorys.ActividadRepository().bajaActividad(actividad);

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
                aux.DNI_Monitor = actividadNormal.DNI_Monitor;
                aux.MediaValoracion = (double) actividadNormal.Media_Valoracion;

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
        public String RegistrarActividad(ActividadDTO nuevaActividad)
        {
            ActividadRepository actividadRepository = new ActividadRepository();
            int nuevoId = actividadRepository.ObtenerNuevoIdActividad();
            Actividad actividad = new Actividad
            {
                Id_Actividad = nuevoId,
                Nombre = nuevaActividad.Nombre,
                Descripcion = nuevaActividad.Descripcion,
                DNI_Monitor = nuevaActividad.DNI_Monitor,
                Media_Valoracion = (decimal?)nuevaActividad.MediaValoracion
            };
            return actividadRepository.GuardarActividad(actividad);
        }

        public ActividadDTO ObtenerActividadPorId(int idActividad)
        {
                Actividad actividadNormal = new Datos.Repositorys.ActividadRepository().ObtenerActividadPorId(idActividad);
                ActividadDTO aux = new ActividadDTO
                {
                    Id_Actividad = actividadNormal.Id_Actividad,
                    Nombre = actividadNormal.Nombre,
                    Descripcion = actividadNormal.Descripcion,
                    DNI_Monitor = actividadNormal.DNI_Monitor,
                    MediaValoracion = (double)actividadNormal.Media_Valoracion
                };

                return aux;
        }
    }
}
