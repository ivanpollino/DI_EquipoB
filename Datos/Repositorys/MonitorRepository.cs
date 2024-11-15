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
        public List<Monitor> ObtenerMonitores()
        {
            List<Monitor> monitores = new List<Monitor>();
            try
            {
                using (var contexto = new equipobEntities())
                {
                    monitores = contexto.Monitor.ToList();
                }
                return monitores;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los monitores: {ex.Message}");
                return monitores;
            }
        }
    }
}
