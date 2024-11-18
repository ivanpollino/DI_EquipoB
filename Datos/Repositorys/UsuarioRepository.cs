using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

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
            using (var contexto = new equipobEntities())
            {
                // Añadir el usuario a la base de datos
                contexto.Usuario.Add(usuario);
                contexto.SaveChanges();
            }
            return "Usuario añadido con éxito";
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
                // Abrir la conexión a la base de datos y obtener todos los usuarios
                using (var contexto = new equipobEntities())
                {
                    usuarios = contexto.Usuario.ToList();
                }
                return usuarios;
            }
            catch (Exception)
            {
                // Si ocurre un error, devolver la lista vacía
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
                // Abrir la conexión a la base de datos y obtener todos los administradores
                using (var contexto = new equipobEntities())
                {
                    usuarios = contexto.Administrador.ToList();
                }
                return usuarios;
            }
            catch (Exception)
            {
                // Si ocurre un error, devolver la lista vacía
                return usuarios;
            }
        }

        /// <summary>
        /// Obtiene el nombre y apellidos de un usuario por su DNI.
        /// </summary>
        /// <param name="dni">DNI del usuario.</param>
        /// <returns>Nombre completo del usuario o un mensaje si no se encuentra.</returns>
        public String sacarNombrePorDNI(String dni)
        {
            using (var contexto = new equipobEntities())
            {
                // Buscar al usuario por su DNI
                var usuario = contexto.Usuario.FirstOrDefault(u => u.DNI == dni);

                // Si se encuentra, devolver el nombre completo, si no, un mensaje de error
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
