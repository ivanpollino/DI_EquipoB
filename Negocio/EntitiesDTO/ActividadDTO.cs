using Datos.Infrastructure;
using System;

namespace Negocio.EntitiesDTO
{
    /// <summary>
    /// Clase que representa una actividad en el sistema.
    /// </summary>
    public class ActividadDTO
    {
        /// <summary>
        /// Identificador único de la actividad.
        /// </summary>
        public int Id_Actividad { get; set; }

        /// <summary>
        /// Nombre de la actividad.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción detallada de la actividad.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// DNI del monitor que imparte la actividad.
        /// </summary>
        public string DNI_Monitor { get; set; }
    }
}
