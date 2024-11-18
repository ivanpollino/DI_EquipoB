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
            Usuario usuario = new Usuario(); // Se crea un objeto Usuario.
            UsuarioRepository datos = new UsuarioRepository(); // Se crea el repositorio para interactuar con la base de datos.
            List<Usuario> usuarios = datos.ObtenerUsuarios(); // Se obtiene la lista de usuarios existentes en la base de datos.

            /*if (usuarios.Count == 0)
            {
                return "La conexión a la base de datos ha fallado";
            }*/

            // Se comprueba que el email del usuario no esté ya registrado en la base de datos.
            if (comprobarEmail(usuarios, usuarioDTO))
            {
                // Se comprueba que el DNI del usuario no esté ya registrado en la base de datos.
                if (comprobarDNI(usuarios, usuarioDTO))
                {
                    // Se asignan los datos del DTO al objeto Usuario.
                    usuario.Nombre = usuarioDTO.Nombre;
                    usuario.Apellidos = usuarioDTO.Apellidos;
                    usuario.Telefono = usuarioDTO.Telefono;
                    usuario.DNI = usuarioDTO.DNI;
                    usuario.Direccion = usuarioDTO.Direccion;
                    usuario.Cuenta_Corriente = usuarioDTO.Cuenta_Corriente;
                    usuario.Email = usuarioDTO.Email;
                    usuario.Passwd = cifrar(usuarioDTO.Passwd); // Se cifra la contraseña del usuario.

                    // Se llama al repositorio para guardar el nuevo usuario en la base de datos.
                    return datos.altaUsuario(usuario);
                }
                else
                {
                    return "Ya hay un usuario registrado con ese DNI"; // Mensaje si el DNI ya está registrado.
                }
            }
            else
            {
                return "Ya hay un usuario registrado con ese email"; // Mensaje si el email ya está registrado.
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
            List<String> dnis = usuarios.Select(x => x.DNI).ToList(); // Obtiene todos los DNIs de los usuarios registrados.
            return !dnis.Contains(usuario.DNI); // Verifica si el DNI del usuario no está en la lista.
        }

        /// <summary>
        /// Comprueba si un email ya está registrado en la lista de usuarios.
        /// </summary>
        /// <param name="usuarios">Lista de usuarios existentes.</param>
        /// <param name="usuario">DTO del usuario a verificar.</param>
        /// <returns>Verdadero si el email no existe en la lista; falso en caso contrario.</returns>
        private bool comprobarEmail(List<Usuario> usuarios, UsuarioDTO usuario)
        {
            List<String> emails = usuarios.Select(x => x.Email).ToList(); // Obtiene todos los emails de los usuarios registrados.
            return !emails.Contains(usuario.Email); // Verifica si el email del usuario no está en la lista.
        }

        /// <summary>
        /// Cifra una contraseña usando el algoritmo SHA-256.
        /// </summary>
        /// <param name="contrasena">Contraseña en texto plano a cifrar.</param>
        /// <returns>Contraseña cifrada en formato hexadecimal.</returns>
        public string cifrar(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create()) // Crea una instancia del algoritmo SHA-256.
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasena)); // Cifra la contraseña.
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in bytes)
                {
                    hashString.Append(b.ToString("X2")); // Convierte el valor cifrado a formato hexadecimal.
                }

                return hashString.ToString(); // Devuelve la contraseña cifrada.
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
            pass = cifrar(pass); // Se cifra la contraseña ingresada.
            UsuarioRepository datos = new UsuarioRepository(); // Repositorio para interactuar con la base de datos.
            // Se busca el usuario que coincida con el email y la contraseña cifrada.
            Usuario usuario = datos.ObtenerUsuarios().FirstOrDefault(x => x.Email == email && x.Passwd == pass);

            if (usuario != null) // Si se encuentra el usuario con las credenciales correctas.
            {
                // Se crea un DTO del usuario con los datos encontrados.
                UsuarioDTO usuarioDTO = new UsuarioDTO
                {
                    Nombre = usuario.Nombre,
                    Apellidos = usuario.Apellidos,
                    Telefono = usuario.Telefono,
                    DNI = usuario.DNI,
                    Direccion = usuario.Direccion,
                    Cuenta_Corriente = usuario.Cuenta_Corriente,
                    Email = usuario.Email,
                    Passwd = cifrar(usuario.Passwd) // Cifrado de nuevo por seguridad.
                };
                return usuarioDTO; // Se retorna el DTO del usuario.
            }

            return null; // Si no se encuentran las credenciales, retorna null.
        }

        /// <summary>
        /// Verifica si un usuario con un DNI específico es un administrador y retorna su información.
        /// </summary>
        /// <param name="dni">DNI del usuario a verificar.</param>
        /// <returns>Un objeto UsuarioDTO con la información del administrador si el DNI coincide, de lo contrario un objeto UsuarioDTO vacío.</returns>
        public UsuarioDTO comprobarAdministrador(String dni)
        {
            UsuarioDTO usuario = new UsuarioDTO();

            
            List<Administrador> administradores = new Datos.Repositorys.UsuarioRepository().obtenerAdministradores();

           
            foreach (Administrador admin in administradores)
            {
                
                if (dni == admin.DNI)
                {
                    usuario.DNI = admin.DNI;
                }
            }

            
            return usuario;
        }

        /// <summary>
        /// Obtiene el nombre completo de un usuario a partir de su DNI.
        /// </summary>
        /// <param name="dni">DNI del usuario del cual se desea obtener el nombre completo.</param>
        /// <returns>El nombre completo del usuario como una cadena de texto.</returns>
        public String sacarNombreApellidosDeUsuario(String dni)
        {
            
            return new Datos.Repositorys.UsuarioRepository().sacarNombrePorDNI(dni);
        }

    }
}
