using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorys
{
    public class UsuarioActividad
    {
        public List<Usuario_Actividad> listadoActividadesUsuario()
        {
            List<Usuario_Actividad> actividades = new List<Usuario_Actividad>();

            using (var contexto = new equipobFinalFinalEntities())
            {
                actividades = contexto.Usuario_Actividad.ToList();
            }

            return actividades;
        }
    }
}
