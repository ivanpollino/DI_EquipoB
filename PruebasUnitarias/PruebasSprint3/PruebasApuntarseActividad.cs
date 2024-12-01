using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias.PruebasSprint3
{
    [TestClass]
    public class PruebasApuntarseActividad
    {
        [TestMethod]
        public void comprobarApuntarseActividadCorrecto()
        {
            UsuarioActividadDTO usuarioActividadDTO = new UsuarioActividadDTO("98939393C",2);
            bool resultado = new Negocio.Managment.UsuarioActividadManagment().RegistrarUsuarioActividad(usuarioActividadDTO);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void comprobarApuntarseActividadIncorrecto()
        {
            UsuarioActividadDTO usuarioActividadDTO = new UsuarioActividadDTO("98939393C", 2);
            bool resultado = new Negocio.Managment.UsuarioActividadManagment().RegistrarUsuarioActividad(usuarioActividadDTO);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void comprobarApuntarseActividadIncorrectoActividadNoExiste()
        {
            UsuarioActividadDTO usuarioActividadDTO = new UsuarioActividadDTO("98939393C", 100);
            bool resultado = new Negocio.Managment.UsuarioActividadManagment().RegistrarUsuarioActividad(usuarioActividadDTO);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void comprobarApuntarseActividadIncorrectoUsuarioNoExiste()
        {
            UsuarioActividadDTO usuarioActividadDTO = new UsuarioActividadDTO("98939393V", 2);
            bool resultado = new Negocio.Managment.UsuarioActividadManagment().RegistrarUsuarioActividad(usuarioActividadDTO);
            Assert.IsFalse(resultado);
        }
    }
}
