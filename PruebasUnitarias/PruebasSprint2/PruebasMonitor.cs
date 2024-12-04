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
    public class TestsRegistroActividad
    {
        [TestMethod]
        public void comprobarRegistroActividadCorrecto()
        {
            ActividadDTO actividad = new ActividadDTO(10, "Prueba", "Prueba", "18079231C");
            string mensaje = new Negocio.Managment.ActividadManagment().RegistrarActividad(actividad);
            Assert.AreEqual(mensaje, "Actividad insertada con éxito.");
            System.Threading.Thread.Sleep(5000);
        }

        [TestMethod]
        public void comprobarRegistroActividadIncorrectoIdRepetido()
        {
            ActividadDTO actividad = new ActividadDTO(10, "Prueba", "Prueba", "18079231C");
            string mensaje = new Negocio.Managment.ActividadManagment().RegistrarActividad(actividad);
            Assert.AreEqual(mensaje, "Error al guardar la actividad: An error occurred while updating the entries. See the inner exception for details.");
        }
    }
}
