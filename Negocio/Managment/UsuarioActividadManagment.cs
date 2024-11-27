using Datos.Repositorys;
using Datos.Infrastructure;
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
        public List<UsuarioActiviadDTO> ObtenerActividadesApuntado()
        {
            List<Usuario_Actividad> usuario_actividades = new UsuarioActividadRepository().listadoActividadesUsuario();
            List<UsuarioActiviadDTO> listaDTO = new List<UsuarioActiviadDTO>();
            foreach (Usuario_Actividad usuario_Actividad in usuario_actividades)
            {
                UsuarioActiviadDTO aux = new UsuarioActiviadDTO();
                aux.Id_Actividad = usuario_Actividad.Id_Actividad;
                aux.DNI = usuario_Actividad.DNI;
                aux.Valoracion = usuario_Actividad.Valoracion;

                listaDTO.Add(aux);
            }
            return listaDTO;
        }
    }
}
