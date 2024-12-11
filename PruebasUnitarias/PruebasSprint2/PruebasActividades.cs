using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias.PruebasSprint2
{
    [TestClass]
    public class TestsRegistroMonitor
    {
        [TestMethod]
        public void comprobarRegistroMonitorCorrecto()
        {
            UsuarioDTO monitor = new UsuarioDTO("18079231C", "Test", "Monitor", 0, "", "", "testMonitor@gmail.com", "Root2/root");
            string mensaje = new Negocio.Managment.MonitorManagment().altaMonitor(monitor);
            Assert.AreEqual(mensaje, "Monitor insertado correctamente.");
            System.Threading.Thread.Sleep(5000);
        }

        [TestMethod]
        public void comprobarRegistroIncorrectoMonitorEmailRepetido()
        {
            UsuarioDTO monitor = new UsuarioDTO("18079231B", "Test", "Monitor", 0, "", "", "testMonitor@gmail.com", "Root2/root");
            string mensaje = new Negocio.Managment.MonitorManagment().altaMonitor(monitor);
            Assert.AreEqual(mensaje, "Ya hay un monitor registrado con ese email");
        }

        [TestMethod]
        public void comprobarRegistroIncorrectoMonitorDNIRepetido()
        {
            UsuarioDTO monitor = new UsuarioDTO("18079231C", "Test", "Monitor", 0, "", "", "testMonitor2@gmail.com", "Root2/root");
            string mensaje = new Negocio.Managment.MonitorManagment().altaMonitor(monitor);
            Assert.AreEqual(mensaje, "Ya hay un monitor registrado con ese DNI");
        }

    }
}
