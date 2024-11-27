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
    public class UsuarioActividadManagment
    {

        public bool RegistrarUsuarioActividad(UsuarioActividadDTO nuevaActividad)
        {
            UsuarioActividadRepository actividadRepository = new UsuarioActividadRepository();
            Usuario_Actividad actividad = new Usuario_Actividad
            {
                DNI = nuevaActividad.DNI,
                Id_Actividad = nuevaActividad.Id_Actividad,
                Valoracion = nuevaActividad.Valoracion
            };

            return actividadRepository.GuardarActividad(actividad);

        }

    }
}
