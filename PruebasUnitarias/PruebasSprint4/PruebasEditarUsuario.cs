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
    public class PruebasEditarUsuario
    {
        UsuarioDTO usuario = new UsuarioDTO("18079239L", "Gabriel", "Luezas", 0, "", "ES3822222222222222222222", "prueba@gmail.com", "Root2/root");
        [TestMethod]
        public void comprobarEditarUsuarioCorrecto()
        {
            UsuarioDTO usuarioModificado = new UsuarioDTO("18079239L", "MODFICACION", "MODFICACION", 0, "", "ES3822222222222222222222", "prueba@gmail.com", "Root2/root");
            new Negocio.Managment.UsuarioManagment().altaUsuario(usuario);
            String resultado = new Negocio.Managment.UsuarioManagment().modificarUsuario(usuarioModificado.DNI, usuarioModificado);
            Assert.AreEqual(resultado, "Usuario modificado con éxito");
        }

        [TestMethod]
        public void comprobarEditarUsuarioIncorrectoUsuarioNoExiste()
        {
            UsuarioDTO usuarioModificado = new UsuarioDTO("18079239H", "MODFICACION", "MODFICACION", 0, "", "ES3822222222222222222222", "prueba@gmail.com", "Root2/root");
            String resultado = new Negocio.Managment.UsuarioManagment().modificarUsuario(usuarioModificado.DNI, usuarioModificado);
            Assert.AreEqual(resultado, "No existe el usuario");
        }
    }
}