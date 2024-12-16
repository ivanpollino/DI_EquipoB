using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using System;

namespace PruebasUnitarias.PruebasSprint4
{
    [TestClass]
    public class PruebasValorarActividad
    {
        [TestMethod]
        public void comprobarValorarActividadCorrecto()
        {

            UsuarioActividadDTO usuarioActividadDTO = new UsuarioActividadDTO("99994444C", 6);
            new Negocio.Managment.UsuarioActividadManagment().RegistrarUsuarioActividad(usuarioActividadDTO);

            bool resultado = new Negocio.Managment.UsuarioActividadManagment().ActualizarValoracion(6,"99994444C",5);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void comprobarValorarActividadIncorrectoUsuarioNoExiste()
        {
            bool resultado = new Negocio.Managment.UsuarioActividadManagment().ActualizarValoracion(6, "99991444C", 5);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void comprobarValorarActividadIncorrectoActividadNoExiste()
        {
            bool resultado = new Negocio.Managment.UsuarioActividadManagment().ActualizarValoracion(30, "99994444C", 5);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void comprobarValorarActividadIncorrectoValoracionInvalida()
        {
            bool resultado = new Negocio.Managment.UsuarioActividadManagment().ActualizarValoracion(6, "99994444C", 30);

            Assert.IsFalse(resultado);
        }
    }
}