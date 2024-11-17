using Datos.Infrastructure;
using System;
using System.Collections.Generic;
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
            using (var contexto = new equipobPortatilIvan())
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
                // Abrir la BD
                using (var contexto = new equipobPortatilIvan())
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
        /// Obtiene un usuario de la base de datos por su DNI.
        /// </summary>
        /// <param name="dni">El DNI del usuario que se busca.</param>
        /// <returns>El objeto <see cref="Usuario"/> que corresponde al DNI, o null si no se encuentra.</returns>
        public Usuario ObtenerUsuarioPorDni(string dni)
        {
            using (var contexto = new equipobPortatilIvan())
            {
                // Buscar usuario por DNI
                return contexto.Usuario.SingleOrDefault(u => u.DNI == dni);
            }
        }
    }
}
