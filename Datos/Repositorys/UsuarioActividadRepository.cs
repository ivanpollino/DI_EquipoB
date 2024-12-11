using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorys
{
    /// <summary>
    /// Repositorio para gestionar las actividades asociadas a los usuarios en la base de datos.
    /// </summary>
    public class UsuarioActividadRepository
    {
        /// <summary>
        /// Guarda una nueva actividad asociada a un usuario en la base de datos.
        /// </summary>
        /// <param name="actividad">Un objeto <c>Usuario_Actividad</c> que representa la actividad del usuario.</param>
        /// <returns>Devuelve <c>true</c> si la actividad fue guardada correctamente, de lo contrario <c>false</c>.</returns>
        public bool GuardarActividad(Usuario_Actividad actividad)
        {
            try
            {
                using (var context = new equipobFinalFinalEntities())
                {
                    context.Usuario_Actividad.Add(actividad);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Obtiene la lista de actividades asociadas a un usuario mediante su DNI.
        /// </summary>
        /// <param name="DNI">El DNI del usuario para obtener las actividades asociadas.</param>
        /// <returns>Una lista de objetos <c>Usuario_Actividad</c> que representa las actividades del usuario.</returns>
        public List<Usuario_Actividad> listadoActividadesUsuario(string DNI)
        {
            List<Usuario_Actividad> actividades;

            using (var contexto = new equipobFinalFinalEntities())
            {
                actividades = contexto.Usuario_Actividad
                                       .Where(usuarioActividad => usuarioActividad.DNI == DNI)
                                       .ToList();
            }

            return actividades;
        }
        ////Creo que esto es lo que no funciona
        /// <summary>
        /// Guarda o actualiza la valoración de una actividad asociada a un usuario en la base de datos.
        /// </summary>
        /// <param name="idActividad">ID de la actividad.</param>
        /// <param name="dniUsuario">DNI del usuario.</param>
        /// <param name="valoracion">La valoración que el usuario asigna a la actividad.</param>
        /// <returns>Devuelve <c>true</c> si la valoración fue guardada correctamente, de lo contrario <c>false</c>.</returns>
        public bool GuardarOActualizarValoracion(int idActividad, string dniUsuario, byte valoracion)
        {
            try
            {
                using (var context = new equipobFinalFinalEntities())
                {
                    var usuarioActividad = context.Usuario_Actividad
                        .FirstOrDefault(ua => ua.Id_Actividad == idActividad && ua.DNI == dniUsuario);

                    if (usuarioActividad != null)
                    {
                        usuarioActividad.Valoracion = valoracion;
                    }
                    else
                    {
                        usuarioActividad = new Usuario_Actividad
                        {
                            Id_Actividad = idActividad,
                            DNI = dniUsuario,
                            Valoracion = valoracion
                        };
                        context.Usuario_Actividad.Add(usuarioActividad);
                    }

                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// Obtiene la valoración de un usuario para una actividad específica.
        /// </summary>
        /// <param name="idActividad">ID de la actividad.</param>
        /// <param name="dniUsuario">DNI del usuario.</param>
        /// <returns>Devuelve la valoración del usuario para la actividad, o 0 si no tiene valoración.</returns>
        public byte ObtenerValoracion(int idActividad, string dniUsuario)
        {
            try
            {
                using (var context = new equipobFinalFinalEntities())
                {
                    var usuarioActividad = context.Usuario_Actividad
                        .FirstOrDefault(ua => ua.Id_Actividad == idActividad && ua.DNI == dniUsuario);
                    return usuarioActividad?.Valoracion ?? (byte)0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
