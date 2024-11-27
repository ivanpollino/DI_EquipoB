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
    }
}
