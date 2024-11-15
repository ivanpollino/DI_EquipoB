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
        /// Registra una nueva actividad junto con su monitor asociado.
        /// </summary>
        /// <param name="actividadDTO">Datos de la actividad a registrar.</param>
        /// <param name="dniMonitor">DNI del monitor asociado a la actividad.</param>
        public void RegistrarActividad(ActividadDTO actividadDTO, string dniMonitor)
        {
            ActividadRepository actividadRepository = new ActividadRepository();
            int nuevoId = actividadRepository.ObtenerProximoIdActividad();
            Actividad nuevaActividad = new Actividad
            {
                Id_Actividad = nuevoId,
                Nombre = actividadDTO.Nombre,
                Descripcion = actividadDTO.Descripcion
            };
            actividadRepository.RegistrarActividad(nuevaActividad);
            //actividadRepository.RegistrarMonitorActividad(nuevoId, dniMonitor);
        }
    }
}
