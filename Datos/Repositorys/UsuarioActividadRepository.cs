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
                using (var context = new equipobIvanClase())
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

            using (var contexto = new equipobIvanClase())
            {
                actividades = contexto.Usuario_Actividad
                                       .Where(usuarioActividad => usuarioActividad.DNI == DNI)
                                       .ToList();
            }

            return actividades;
        }
    }
}
