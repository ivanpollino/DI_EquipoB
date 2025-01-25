using Datos.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias.PruebasSprint4
{
    [TestClass]
    public class PruebasDesapuntarteActividad
    {

       
        [TestMethod]
        public void comprobarDesapuntarteActividadCorrecto()
        {
            ActividadDTO actividad = new ActividadDTO(6, "Prueba", "Prueba", "99994444C");
            new Negocio.Managment.ActividadManagment().RegistrarActividad(actividad);
            UsuarioDTO monitor = new UsuarioDTO("99994444C", "Test", "Monitor", 0, "", "", "testMonitor@gmail.com", "Root2/root");
            new Negocio.Managment.MonitorManagment().altaMonitor(monitor);


            UsuarioActividadDTO usuarioActividadDTO = new UsuarioActividadDTO("99994444C", 6);

            new Negocio.Managment.UsuarioActividadManagment().RegistrarUsuarioActividad(usuarioActividadDTO);

            bool resultado = new Negocio.Managment.UsuarioActividadManagment().EliminarActividadUsuario(usuarioActividadDTO);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void comprobarDesapuntarteActividadIncorrectoUsuarioNoExiste()
        {
            UsuarioActividadDTO usuarioActividadDTO = new UsuarioActividadDTO("99994444B", 10);

            bool resultado = new Negocio.Managment.UsuarioActividadManagment().EliminarActividadUsuario(usuarioActividadDTO);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void comprobarDesapuntarteActividadIncorrectoActividadNoExiste()
        {
            UsuarioActividadDTO usuarioActividadDTO = new UsuarioActividadDTO("99994444C", 100);
            bool resultado = new Negocio.Managment.UsuarioActividadManagment().EliminarActividadUsuario(usuarioActividadDTO);
            Assert.IsFalse(resultado);
        }
    }
}
