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
            Usuario_Normal usuarioNormal = new Usuario_Normal();
            usuarioNormal.DNI = usuario.DNI;
            using (var contexto = new equipobEntities())
            {
                contexto.Usuario.Add(usuario);
                contexto.Usuario_Normal.Add(usuarioNormal);
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
                using (var contexto = new equipobEntities())
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

        /// <summary>
        /// Obtiene la lista de todos los administradores registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Administrador"/> con la información de cada administrador.</returns>
        public List<Administrador> obtenerAdministradores()
        {
            List<Administrador> usuarios = new List<Administrador>();
            try
            {
                using (var contexto = new equipobEntities())
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

        /// <summary>
        /// Obtiene la lista de todos los usuarios normales registrados en la base de datos.
        /// </summary>
        /// <returns>Lista de objetos <see cref="Usuario_Normal"/> con la información de cada usuario normal.</returns>
        public List<Usuario_Normal> obtenerUsuariosNormal()
        {
            List<Usuario_Normal> usuarios = new List<Usuario_Normal>();
            try
            {
                using (var contexto = new equipobEntities())
                {
                    usuarios = contexto.Usuario_Normal.ToList();
                }
                return usuarios;
            }
            catch (Exception)
            {
                return usuarios;
            }
        }

        /// <summary>
        /// Obtiene el nombre completo de un usuario a partir de su DNI.
        /// </summary>
        /// <param name="dni">DNI del usuario.</param>
        /// <returns>El nombre completo del usuario o un mensaje indicando que no fue encontrado.</returns>
        public String sacarNombrePorDNI(String dni)
        {
            using (var contexto = new equipobEntities())
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

        /// <summary>
        /// Modifica la información de un usuario existente en la base de datos.
        /// </summary>
        /// <param name="dni">DNI del usuario a modificar.</param>
        /// <param name="nuevosDatos">Objeto <see cref="Usuario"/> con los nuevos datos del usuario.</param>
        /// <returns>Mensaje indicando si la modificación fue exitosa o si el usuario no fue encontrado.</returns>
        public String modificarUsuario(String dni, Usuario nuevosDatos)
        {
            using (var contexto = new equipobEntities())
            {
                var usuarioExistente = contexto.Usuario.FirstOrDefault(u => u.DNI == dni);

                if (usuarioExistente == null)
                {
                    return "Usuario no encontrado";
                }

                usuarioExistente.Nombre = nuevosDatos.Nombre;
                usuarioExistente.Apellidos = nuevosDatos.Apellidos;
                usuarioExistente.Email = nuevosDatos.Email;
                usuarioExistente.Telefono = nuevosDatos.Telefono;
                usuarioExistente.Cuenta_Corriente = nuevosDatos.Cuenta_Corriente;
                usuarioExistente.Direccion = nuevosDatos.Direccion;

                contexto.SaveChanges();
            }

            return "Usuario modificado con éxito";
        }
    }
}
