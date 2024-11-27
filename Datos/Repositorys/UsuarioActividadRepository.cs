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
        public List<Usuario_Actividad> listadoActividadesUsuario()
        {
            List<Usuario_Actividad> actividades = new List<Usuario_Actividad>();

            using (var contexto = new equipobIvanClase())
            {
                actividades = contexto.Usuario_Actividad.ToList();
            }

            return actividades;
        }
    }
}
