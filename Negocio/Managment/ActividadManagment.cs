using Datos.Infrastructure;
using Datos.Repositorys;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;

namespace Negocio.Managment
{
    /// <summary>
    /// Clase que gestiona las operaciones relacionadas con las actividades en el sistema.
    /// </summary>
    public class ActividadManagment
    {
        /// <summary>
        /// Elimina una actividad de la base de datos utilizando su DTO.
        /// </summary>
        /// <param name="actividadDTO">El DTO que representa la actividad a eliminar.</param>
        /// <returns>Un mensaje de éxito indicando que la actividad fue eliminada.</returns>
        public String bajaActividad(ActividadDTO actividadDTO)
        {
            // Crear una instancia de Actividad y asignar valores del DTO
            Actividad actividad = new Actividad
            {
                Id_Actividad = actividadDTO.Id_Actividad,
                Nombre = actividadDTO.Nombre,
                Descripcion = actividadDTO.Descripcion,
                DNI_Monitor = actividadDTO.DNI_Monitor
            };

            // Llamar al método del repositorio para eliminar la actividad
            return new ActividadRepository().bajaActividad(actividad);
        }

        /// <summary>
        /// Obtiene todas las actividades desde la base de datos y las convierte en una lista de DTOs.
        /// </summary>
        /// <returns>Una lista de DTOs que representa todas las actividades.</returns>
        public List<ActividadDTO> ObtenerActividades()
        {
            // Obtener la lista de actividades desde el repositorio
            List<Actividad> actividades = new ActividadRepository().listadoActividades();
            List<ActividadDTO> listaDTO = new List<ActividadDTO>();

            // Convertir cada Actividad en un ActividadDTO
            foreach (Actividad actividadNormal in actividades)
            {
                ActividadDTO aux = new ActividadDTO
                {
                    Id_Actividad = actividadNormal.Id_Actividad,
                    Nombre = actividadNormal.Nombre,
                    Descripcion = actividadNormal.Descripcion,
                    DNI_Monitor = actividadNormal.DNI_Monitor
                };

                listaDTO.Add(aux);
            }

            return listaDTO;
        }

        /// <summary>
        /// Registra una nueva actividad en la base de datos.
        /// </summary>
        /// <param name="nuevaActividad">El DTO que representa la nueva actividad que se desea registrar.</param>
        public void RegistrarActividad(ActividadDTO nuevaActividad)
        {
            // Crear una instancia del repositorio de actividades
            ActividadRepository actividadRepository = new ActividadRepository();

            // Obtener un nuevo ID para la actividad
            int nuevoId = actividadRepository.ObtenerNuevoIdActividad();

            // Crear la entidad Actividad a partir del DTO
            Actividad actividad = new Actividad
            {
                Id_Actividad = nuevoId,
                Nombre = nuevaActividad.Nombre,
                Descripcion = nuevaActividad.Descripcion,
                DNI_Monitor = nuevaActividad.DNI_Monitor
            };

            // Guardar la nueva actividad en la base de datos
            actividadRepository.GuardarActividad(actividad);
        }
    }
}
