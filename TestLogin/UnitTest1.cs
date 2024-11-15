using Datos.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.EntitiesDTO;
using System;

namespace TestLogin
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

    [TestClass]
    public class TestsRegistro
    {
        [TestMethod]
        public void comprobarRegistroCorrecto()
        {
            UsuarioDTO usuario = new UsuarioDTO("18372831b","Gabriel","Luezas",0,"","ES3822222222222222222222","unai@gmail.com","Root2/root");
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
