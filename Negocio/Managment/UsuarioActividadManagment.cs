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
    /// <summary>
    /// Clase encargada de gestionar las actividades de los usuarios, como registrar nuevas actividades
    /// y obtener las actividades en las que un usuario está apuntado.
    /// </summary>
    public class UsuarioActividadManagment
    {
        /// <summary>
        /// Registra una nueva actividad para un usuario en la base de datos.
        /// </summary>
        /// <param name="nuevaActividad">Un objeto <c>UsuarioActividadDTO</c> que contiene la información de la actividad y el usuario.</param>
        /// <returns>Devuelve <c>true</c> si la actividad fue registrada correctamente, de lo contrario <c>false</c>.</returns>
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

        /// <summary>
        /// Obtiene las actividades en las que un usuario está apuntado.
        /// </summary>
        /// <param name="DNI">El DNI del usuario para el cual se desean obtener las actividades apuntadas.</param>
        /// <returns>Una lista de objetos <c>UsuarioActividadDTO</c> con la información de las actividades en las que el usuario está apuntado.</returns
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

        public bool EliminarActividadUsuario(UsuarioActividadDTO usuarioActividad)
        {
            UsuarioActividadRepository actividadRepository = new UsuarioActividadRepository();
            Usuario_Actividad actividad = new Usuario_Actividad
            {
                DNI = usuarioActividad.DNI,
                Id_Actividad = usuarioActividad.Id_Actividad,
                Valoracion = usuarioActividad.Valoracion
            };

            return actividadRepository.EliminarActividadUsuario(actividad);
        }



        public void ActualizarMediaValoracion(int idActividad)
        {
            UsuarioActividadRepository actividadRepository = new UsuarioActividadRepository();
            actividadRepository.ActualizarMediaValoracion(idActividad);
        }

        // <summary>
        /// Obtiene la valoración de un usuario para una actividad.
        /// </summary>
        /// <param name="idActividad">ID de la actividad.</param>
        /// <param name="dniUsuario">DNI del usuario.</param>
        /// <returns>Valoración del usuario para la actividad (0 si no existe).</returns>
        public byte ObtenerValoracion(int idActividad, string dniUsuario)
        {
            try
            {
                var usuarioActividadRepository = new UsuarioActividadRepository();
                return usuarioActividadRepository.ObtenerValoracion(idActividad, dniUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la valoración", ex);
            }
        }

        /// <summary>
        /// Actualiza la valoración de un usuario para una actividad específica.
        /// </summary>
        /// <param name="idActividad">ID de la actividad.</param>
        /// <param name="dniUsuario">DNI del usuario.</param>
        /// <param name="nuevaValoracion">Nueva valoración a establecer.</param>
        /// <returns><c>true</c> si la valoración fue actualizada correctamente, de lo contrario <c>false</c>.</returns>
        public bool ActualizarValoracion(int idActividad, string dniUsuario, byte nuevaValoracion)
        {
            try
            {
                var usuarioActividadRepository = new UsuarioActividadRepository();
                return usuarioActividadRepository.GuardarOActualizarValoracion(idActividad, dniUsuario, nuevaValoracion);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la valoración", ex);
            }
        }

    }
}
