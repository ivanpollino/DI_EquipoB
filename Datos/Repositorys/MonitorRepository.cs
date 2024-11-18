using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Repositorys
{
    public class MonitorRepository
    {
        /// <summary>
        /// Obtiene una lista de todos los monitores registrados.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Usuario"/> que representan a los monitores.</returns>
        public List<Usuario> ObtenerMonitores()
        {
            using (var contexto = new equipobEntities())
            {
                // Realiza un join entre la tabla Usuario y Monitor utilizando el campo DNI
                var monitores = (from u in contexto.Usuario
                                 join m in contexto.Monitor on u.DNI equals m.DNI
                                 select u).ToList();

                // Devuelve la lista de usuarios que son monitores
                return monitores;
            }
        }

        /// <summary>
        /// Obtiene un monitor por su DNI.
        /// </summary>
        /// <param name="dni">DNI del monitor a buscar.</param>
        /// <returns>El objeto <see cref="Monitor"/> correspondiente o null si no se encuentra.</returns>
        public Monitor ObtenerMonitorPorDni(string dni)
        {
            using (var contexto = new equipobEntities())
            {
                // Busca un monitor en la base de datos que coincida con el DNI proporcionado
                return contexto.Monitor.SingleOrDefault(m => m.DNI == dni);
            }
        }

        /// <summary>
        /// Da de alta un nuevo monitor en la base de datos.
        /// </summary>
        /// <param name="monitor">Objeto <see cref="Monitor"/> con la información del monitor a añadir.</param>
        /// <returns>Mensaje indicando si el monitor fue añadido o si ya existe.</returns>
        public string AltaMonitor(Monitor monitor)
        {
            using (var context = new equipobEntities())
            {
                // Verifica si ya existe un monitor con el mismo DNI
                var monitorExistente = context.Monitor.FirstOrDefault(m => m.DNI == monitor.DNI);
                if (monitorExistente != null)
                {
                    // Si ya existe, se devuelve un mensaje indicando que el monitor ya está registrado
                    return "El monitor ya existe.";
                }

                // Si no existe, se añade el nuevo monitor a la base de datos
                context.Monitor.Add(monitor);
                context.SaveChanges(); // Guarda los cambios en la base de datos

                return "Monitor insertado correctamente.";
            }
        }
    }
}
