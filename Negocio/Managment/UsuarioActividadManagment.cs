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

        public List<UsuarioActividadDTO> ObtenerActividadesApuntado(String DNI)
        {
            List<Usuario_Actividad> usuario_actividades = new UsuarioActividadRepository().listadoActividadesUsuario(DNI);
            List<UsuarioActividadDTO> listaDTO = new List<UsuarioActividadDTO>();
            foreach (Usuario_Actividad usuario_Actividad in usuario_actividades)
            {
                UsuarioActividadDTO aux = new UsuarioActividadDTO();
                aux.Id_Actividad = usuario_Actividad.Id_Actividad;
                aux.DNI = usuario_Actividad.DNI;
                aux.Valoracion = usuario_Actividad.Valoracion;

                listaDTO.Add(aux);
            }
            return listaDTO;
        }


    }
}
