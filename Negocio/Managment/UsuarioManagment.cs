using Datos.Infrastructure;
using Datos.Repositorys;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Managment
{
    /// <summary>
    /// Clase que gestiona la lógica de negocio para la entidad Usuario,
    /// incluyendo operaciones de alta, verificación de login y cifrado de contraseñas.
    /// </summary>
    public class UsuarioManagment
    {
        /// <summary>
        /// Mensaje de estado para operaciones realizadas en la clase.
        /// </summary>
        public string mensaje;

        /// <summary>
        /// Registra un nuevo usuario en la base de datos, comprobando la existencia previa de email y DNI.
        /// </summary>
        /// <param name="usuarioDTO">DTO del usuario a registrar.</param>
        /// <returns>Mensaje indicando el estado de la operación.</returns>
        public String altaUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario();
            UsuarioRepository datos = new UsuarioRepository();
            List<Usuario> usuarios = datos.ObtenerUsuarios();

            /*if (usuarios.Count == 0)
            {
                return "La conexión a la base de datos ha fallado";
            }*/

            if (comprobarEmail(usuarios, usuarioDTO))
            {
                if (comprobarDNI(usuarios, usuarioDTO))
                {
                    usuario.Nombre = usuarioDTO.Nombre;
                    usuario.Apellidos = usuarioDTO.Apellidos;
                    usuario.Telefono = usuarioDTO.Telefono;
                    usuario.DNI = usuarioDTO.DNI;
                    usuario.Direccion = usuarioDTO.Direccion;
                    usuario.Cuenta_Corriente = usuarioDTO.Cuenta_Corriente;
                    usuario.Email = usuarioDTO.Email;
                    usuario.Passwd = cifrar(usuarioDTO.Passwd);

                    return datos.altaUsuario(usuario);
                }
                else
                {
                    return "Ya hay un usuario registrado con ese DNI";
                }
            }
            else
            {
                return "Ya hay un usuario registrado con ese email";
            }
        }

        /// <summary>
        /// Comprueba si un DNI ya está registrado en la lista de usuarios.
        /// </summary>
        /// <param name="usuarios">Lista de usuarios existentes.</param>
        /// <param name="usuario">DTO del usuario a verificar.</param>
        /// <returns>Verdadero si el DNI no existe en la lista; falso en caso contrario.</returns>
        private bool comprobarDNI(List<Usuario> usuarios, UsuarioDTO usuario)
        {
            List<String> dnis = usuarios.Select(x => x.DNI).ToList();
            return !dnis.Contains(usuario.DNI);
        }

        /// <summary>
        /// Comprueba si un email ya está registrado en la lista de usuarios.
        /// </summary>
        /// <param name="usuarios">Lista de usuarios existentes.</param>
        /// <param name="usuario">DTO del usuario a verificar.</param>
        /// <returns>Verdadero si el email no existe en la lista; falso en caso contrario.</returns>
        private bool comprobarEmail(List<Usuario> usuarios, UsuarioDTO usuario)
        {
            List<String> emails = usuarios.Select(x => x.Email).ToList();
            return !emails.Contains(usuario.Email);
        }

        /// <summary>
        /// Cifra una contraseña usando el algoritmo SHA-256.
        /// </summary>
        /// <param name="contrasena">Contraseña en texto plano a cifrar.</param>
        /// <returns>Contraseña cifrada en formato hexadecimal.</returns>
        public string cifrar(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in bytes)
                {
                    hashString.Append(b.ToString("X2"));
                }

                return hashString.ToString();
            }
        }

        /// <summary>
        /// Verifica las credenciales de login del usuario.
        /// </summary>
        /// <param name="email">Email del usuario.</param>
        /// <param name="pass">Contraseña en texto plano del usuario.</param>
        /// <returns>Un objeto UsuarioDTO si las credenciales son correctas; null en caso contrario.</returns>
        public UsuarioDTO comprobarLogin(String email, String pass)
        {
            pass = cifrar(pass);
            UsuarioRepository datos = new UsuarioRepository();
            Usuario usuario = datos.ObtenerUsuarios().FirstOrDefault(x => x.Email == email && x.Passwd == pass);

            if (usuario != null)
            {
                UsuarioDTO usuarioDTO = new UsuarioDTO
                {
                    Nombre = usuario.Nombre,
                    Apellidos = usuario.Apellidos,
                    Telefono = usuario.Telefono,
                    DNI = usuario.DNI,
                    Direccion = usuario.Direccion,
                    Cuenta_Corriente = usuario.Cuenta_Corriente,
                    Email = usuario.Email,
                    Passwd = cifrar(usuario.Passwd) // Cifrado de nuevo por seguridad
                };
                return usuarioDTO;
            }

            return null;
        }
        public UsuarioDTO comprobarAdministrador(String dni)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            List<Administrador> administradores = new Datos.Repositorys.UsuarioRepository().obtenerAdministradores();

            foreach (Administrador admin in administradores)
            {
                if(dni == admin.DNI)
                {
                    usuario.DNI = admin.DNI;
                }
            }

            return usuario;

        }

        public String sacarNombreApellidosDeUsuario(String dni)
        {
            return new Datos.Repositorys.UsuarioRepository().sacarNombrePorDNI(dni);
        }

        public UsuarioDTO comporobarUsuarioNormal(String dni)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            List<Usuario_Normal> usuariosNormales = new UsuarioRepository().obtenerUsuariosNormal();
            foreach (Usuario_Normal usuario_Normal in usuariosNormales)
            {
                if (dni == usuario_Normal.DNI)
                {
                    usuario.DNI = usuario_Normal.DNI;
                }
            }
            return usuario;

        }

        /// <summary>
        /// Modifica los datos de un usuario existente en la base de datos.
        /// </summary>
        /// <param name="dni">DNI del usuario a modificar.</param>
        /// <param name="nuevosDatosDTO">DTO con los nuevos datos del usuario.</param>
        /// <returns>Mensaje indicando el estado de la operación.</returns>
        public String modificarUsuario(String dni, UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario();
            UsuarioRepository datos = new UsuarioRepository();
            List<Usuario> usuarios = datos.ObtenerUsuarios();
            if (!comprobarDNI(usuarios, usuarioDTO))
            {
                usuario.DNI = usuarioDTO.DNI;
                usuario.Nombre = usuarioDTO.Nombre;
                usuario.Apellidos = usuarioDTO.Apellidos;
                usuario.Telefono = usuarioDTO.Telefono;
                usuario.Direccion = usuarioDTO.Direccion;
                usuario.Cuenta_Corriente = usuarioDTO.Cuenta_Corriente;
                usuario.Email = usuarioDTO.Email;

                return datos.modificarUsuario(dni, usuario);
            }
            else
            {
                return "No existe el usuario";
            }
        }
    }
}
