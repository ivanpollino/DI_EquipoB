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
    public class ActividadManagment
    {
        public String bajaActividad(ActividadDTO actividadDTO)
        {
            Actividad actividad = new Actividad();
            ActividadRepository datos = new ActividadRepository();
            actividad.Nombre = actividadDTO.Nombre;
            Actividad actividadBase = datos.sacarActividad(actividad);

            actividad.Id_Actividad = actividadBase.Id_Actividad;
            actividad.Nombre = actividadBase.Nombre;
            actividad.Descripcion = actividadBase.Descripcion;

            return datos.bajaActividad(actividad);

        }
        public List<ActividadDTO> ObtenerActividades()
        {
            List<Actividad> actividades = new Datos.Repositorys.ActividadRepository().listadoActividades();
            List<ActividadDTO> listaDTO = new List<ActividadDTO>();
            foreach (Actividad actividadNormal in actividades)
            {
                ActividadDTO aux = new ActividadDTO();
                aux.Id_Actividad = actividadNormal.Id_Actividad;
                aux.Nombre = actividadNormal.Nombre;
                aux.Descripcion = actividadNormal.Descripcion;

                listaDTO.Add(aux);
            }
            return listaDTO;
        }
    }
}
