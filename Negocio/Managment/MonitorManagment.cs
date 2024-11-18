using Datos.Infrastructure;
using Datos.Repositorys;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Negocio.Managment
{
    /// <summary>
    /// Clase que gestiona las operaciones relacionadas con los monitores en el sistema.
    /// </summary>
    public class MonitorManagment
    {
        /// <summary>
        /// Obtiene la lista de usuarios que son monitores en el sistema y los convierte en DTOs.
        /// </summary>
        /// <returns>Lista de DTOs de usuarios que son monitores.</returns>
        public List<UsuarioDTO> ObtenerUsuariosMonitores()
        {
            // Obtener los monitores de la capa de datos
            var monitorRepository = new MonitorRepository();
            var monitores = monitorRepository.ObtenerMonitores();

            // Convertir la lista de monitores a una lista de DTOs
            var monitoresDTO = monitores.Select(u => new UsuarioDTO
            {
                DNI = u.DNI,
                Nombre = u.Nombre,
                Apellidos = u.Apellidos
            }).ToList();

            return monitoresDTO;
        }

        /// <summary>
        /// Registra un nuevo monitor en el sistema utilizando un DTO de usuario.
        /// </summary>
        /// <param name="usuarioDTO">DTO que representa los datos del usuario que se desea registrar como monitor.</param>
        /// <returns>Mensaje indicando el resultado de la operación.</returns>
        public String altaMonitor(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario();
            UsuarioRepository datos = new UsuarioRepository();
            List<Usuario> usuarios = datos.ObtenerUsuarios();
            Monitor monitor = new Monitor();
            MonitorRepository dMonitores = new MonitorRepository();

            // Comprobar si el email ya está registrado
            if (comprobarEmail(usuarios, usuarioDTO))
            {
                // Comprobar si el DNI ya está registrado
                if (comprobarDNI(usuarios, usuarioDTO))
                {
                    // Asignar los datos del DTO al nuevo objeto Usuario
                    usuario.Nombre = usuarioDTO.Nombre;
                    usuario.Apellidos = usuarioDTO.Apellidos;
                    usuario.Telefono = usuarioDTO.Telefono;
                    usuario.DNI = usuarioDTO.DNI;
                    usuario.Direccion = usuarioDTO.Direccion;
                    usuario.Cuenta_Corriente = usuarioDTO.Cuenta_Corriente;
                    usuario.Email = usuarioDTO.Email;
                    usuario.Passwd = cifrar(usuarioDTO.Passwd);

                    // Registrar el usuario en la base de datos
                    datos.altaUsuario(usuario);

                    // Asignar el DNI del usuario al nuevo monitor
                    monitor.DNI = usuario.DNI;

                    // Registrar el monitor en la base de datos
                    return dMonitores.AltaMonitor(monitor);
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

        /// <summary>
        /// Cifra una contraseña utilizando el algoritmo SHA256.
        /// </summary>
        /// <param name="contrasena">Contraseña a cifrar.</param>
        /// <returns>La contraseña cifrada en formato SHA256.</returns>
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
