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
    public class MonitorManagment
    {
        public List<UsuarioDTO> ObtenerUsuariosMonitores()
        {
            // Obtener la lista de todos los usuarios
            List<Usuario> usuarios = new UsuarioRepository().ObtenerUsuarios();

            // Obtener la lista de todos los monitores (solo el DNI)
            List<Monitor> monitores = new MonitorRepository().ObtenerMonitores();

            List<UsuarioDTO> monitoresDTO = usuarios
                .Where(u => monitores.Any(m => m.DNI == u.DNI)) // Filtramos solo los usuarios que son monitores
                .Select(u => new UsuarioDTO
                {
                    DNI = u.DNI,
                    Nombre = u.Nombre
                })
                .ToList();

            return monitoresDTO;
        }
        public String altaMonitor(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario();
            UsuarioRepository datos = new UsuarioRepository();
            List<Usuario> usuarios = datos.ObtenerUsuarios();
            Monitor monitor = new Monitor();
            MonitorRepository dMonitores = new MonitorRepository();

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
                    datos.altaUsuario(usuario);

                    monitor.DNI = usuario.DNI;
                    return dMonitores.altaMonitor(monitor); ;
                }
                else
                {
                    return "Ya hay un monitor registrado con ese DNI";
                }
            }
            else
            {
                return "Ya hay un monitor registrado con ese email";
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
    }

}
