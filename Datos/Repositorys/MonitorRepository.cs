using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorys
{
    public class MonitorRepository
    {
        // <summary>
        /// Recupera una lista de monitores registrados en la base de datos, 
        /// devolviendo las entidades Usuario correspondientes a los monitores.
        /// </summary>
        /// <returns>
        /// Una lista de objetos <see cref="Usuario"/> que representan a los monitores.
        /// </returns>
        public List<Usuario> ObtenerMonitores()
        {
            using (var contexto = new equipobEntities())
            {
                // Realizar el join entre la tabla Usuario y Monitor por el campo DNI
                var monitores = (from u in contexto.Usuario
                                 join m in contexto.Monitor on u.DNI equals m.DNI
                                 select u).ToList(); // Ejecutamos la consulta y obtenemos los resultados en una lista de Usuario

                return monitores;
            }
        }
        /// <summary>
        /// Registra un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="usuario">Objeto <see cref="Usuario"/> que contiene la información del usuario a añadir.</param>
        /// <returns>Mensaje de confirmación de que el usuario fue añadido con éxito.</returns>
        public String altaMonitor(Monitor monitor)
        {
            using (var contexto = new equipobEntities())
            {
                contexto.Monitor.Add(monitor);
                contexto.SaveChanges();

            }
            return "Monitor añadido con exito";
        }

    }
}
