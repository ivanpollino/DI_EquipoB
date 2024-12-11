using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using System;

namespace PruebasUnitarias
{

    [TestClass]
    public class TestsLogin
    {
        [TestMethod]
        public void comprobarLoginCorrecto()
        {
            UsuarioDTO comprobarLogin = new Negocio.Managment.UsuarioManagment().comprobarLogin("pollino@gmail.com", "Root*root2");
            Console.WriteLine(comprobarLogin != null ? "Inicio de sesion correcto" : "Los datos introducidos no son validos");
            Assert.IsNotNull(comprobarLogin);

        }

        [TestMethod]
        public void comprobarLoginIncorrecto()
        {
            UsuarioDTO comprobarLogin = new Negocio.Managment.UsuarioManagment().comprobarLogin("gabriel@gmail.com", "a");

            Console.WriteLine(comprobarLogin != null ? "Inicio de sesion correcto" : "Los datos introducidos no son validos");
            Assert.IsNull(comprobarLogin);
        }
    }
}
