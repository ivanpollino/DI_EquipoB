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
            using (var contexto = new equipobFINAL1Entities())
            {
                // Realizar el join entre la tabla Usuario y Monitor por el campo DNI
                var monitores = (from u in contexto.Usuario
                                 join m in contexto.Monitor on u.DNI equals m.DNI
                                 select u).ToList();

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
            using (var contexto = new equipobFINAL1Entities())
            {
                // Buscamos el monitor por su DNI
                return contexto.Monitor.SingleOrDefault(m => m.DNI == dni);
            }
        }

        public string AltaMonitor(Monitor monitor)
        {
            using (var context = new equipobFINAL1Entities())
            {
                // Verificar si el monitor ya existe en la base de datos
                var monitorExistente = context.Monitor.FirstOrDefault(m => m.DNI == monitor.DNI);
                if (monitorExistente != null)
                {
                    return "El monitor ya existe.";
                }

                // Si no existe, insertar el nuevo monitor
                context.Monitor.Add(monitor);
                context.SaveChanges();
                return "Monitor insertado correctamente.";
            }
        }
    }
}
