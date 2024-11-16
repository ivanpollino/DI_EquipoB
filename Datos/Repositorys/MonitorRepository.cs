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
        public Monitor ObtenerMonitorPorDni(string dni)
        {
            using (var contexto = new equipobEntities())
            {
                // Buscamos el monitor por su DNI
                return contexto.Monitor.SingleOrDefault(m => m.DNI == dni);
            }
        }

        public String AltaMonitor(Monitor monitor)
        {
            using (var contexto = new equipobEntities())
            {
                var monitorExistente = contexto.Monitor.SingleOrDefault(m => m.DNI == monitor.DNI);
                if (monitorExistente != null)
                {
                    return "El monitor con el DNI " + monitor.DNI + " ya existe en la base de datos.";
                }
                else
                {
                    contexto.Monitor.Add(monitor);
                    contexto.SaveChanges();
                    return "Monitor añadido con éxito";
                }
            }
        }
    }
}
