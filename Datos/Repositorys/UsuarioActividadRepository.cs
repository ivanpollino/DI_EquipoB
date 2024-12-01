using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorys
{
    public class UsuarioActividadRepository
    {
        public bool GuardarActividad(Usuario_Actividad actividad)
        {
            try
            {
                using (var context = new equipobEntities())
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

        public List<Usuario_Actividad> listadoActividadesUsuario(string DNI)
        {
            List<Usuario_Actividad> actividades;

            using (var contexto = new equipobEntities())
            {
                actividades = contexto.Usuario_Actividad
                                       .Where(usuarioActividad => usuarioActividad.DNI == DNI)
                                       .ToList();
            }

            return actividades;
        }
    }
}
