using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorys
{
    /// <summary>
    /// Clase que proporciona métodos para gestionar los usuarios en la base de datos.
    /// </summary>
    public class UsuarioRepository
    {

        /// <summary>
        /// Registra un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="usuario">Objeto <see cref="Usuario"/> que contiene la información del usuario a añadir.</param>
        /// <returns>Mensaje de confirmación de que el usuario fue añadido con éxito.</returns>
        public String altaUsuario(Usuario usuario)
        {
            using (var contexto = new equipobIvanClase())
                {
                    contexto.Usuario.Add(usuario);
                    contexto.SaveChanges();
                    
                }
            return "Usuario añadido con exito";
        }
        /// <summary>
        /// Obtiene la lista de todos los usuarios registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Usuario"/> con la información de cada usuario.</returns>
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                //Abrir la BD
                using (var contexto = new equipobIvanClase())
                {
                    usuarios = contexto.Usuario.ToList();
                }
                return usuarios;
            }
            catch (Exception)
            {
                return usuarios;
            }
        }

        public List<Administrador> obtenerAdministradores()
        {
            List<Administrador> usuarios = new List<Administrador>();
            try
            {
                //Abrir la BD
                using (var contexto = new equipobIvanClase())
                {
                    usuarios = contexto.Administrador.ToList();
                }
                return usuarios;
            }
            catch (Exception)
            {
                return usuarios;
            }
        }

        public String sacarNombrePorDNI(String dni)
        {
            using (var contexto = new equipobIvanClase())
            {
                var usuario = contexto.Usuario
                                      .FirstOrDefault(u => u.DNI == dni);

                if (usuario != null)
                {
                    return usuario.Nombre + " " + usuario.Apellidos;
                }
                else
                {
                    return "Usuario no encontrado";
                }
            }
        }
    }
}
