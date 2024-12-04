using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestsRegistro
    {
        [TestMethod]
        public void comprobarRegistroCorrecto()
        {
            UsuarioDTO usuario = new UsuarioDTO("18372831b", "Gabriel", "Luezas", 0, "", "ES3822222222222222222222", "unai@gmail.com", "Root2/root");
            string mensaje = new Negocio.Managment.UsuarioManagment().altaUsuario(usuario);
            Console.WriteLine(mensaje == "Usuario añadido con exito" ? "Registro correcto" : "Registro fallido");
            Assert.AreEqual(mensaje, "Usuario añadido con exito");

        }
        [TestMethod]
        public void comprobarRegistroIncorrectoEmail()
        {
            UsuarioDTO usuario = new UsuarioDTO("18372432b", "Gabriel", "Luezas", 0, "", "ES3822222222222222222222", "unai@gmail.com", "Root2/root");
            string mensaje = new Negocio.Managment.UsuarioManagment().altaUsuario(usuario);
            Console.WriteLine(mensaje);
            Assert.AreEqual(mensaje, "Ya hay un usuario registrado con ese email");
        }
        [TestMethod]
        public void comprobarRegistroIncorrectoDNI()
        {
            UsuarioDTO usuario = new UsuarioDTO("18372831b", "Gabriel", "Luezas", 0, "", "ES3822222222222222222222", "unaipastor@gmail.com", "Root2/root");
            string mensaje = new Negocio.Managment.UsuarioManagment().altaUsuario(usuario);
            Console.WriteLine(mensaje);
            Assert.AreEqual(mensaje, "Ya hay un usuario registrado con ese DNI");
        }
    }
}
