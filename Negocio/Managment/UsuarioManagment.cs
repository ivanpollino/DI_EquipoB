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
    public class UsuarioManagment
    {
        public string mensaje;

        public String altaUsuario(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario();
            Datos.Repositorys.UsuarioRepository datos = new Datos.Repositorys.UsuarioRepository();
            List<Usuario> usuarios = datos.ObtenerUsuarios();

            if (comprobarEmail(usuarios,usuarioDTO))
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
                else{
                    return "Ya hay un usuario registrado con ese DNI";
                }

            }
            else
            {
                return "Ya hay un usuario registrado con ese email";
            }

        }

        private bool comprobarDNI(List<Usuario> usuarios, UsuarioDTO usuario)
        {
            List<String> dnis = usuarios.Select(x=> x.DNI).ToList();
            if (dnis.Contains(usuario.DNI))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool comprobarEmail(List<Usuario> usuarios,UsuarioDTO usuario)
        {
           List<String> emails = usuarios.Select(x => x.Email).ToList();

            if (emails.Contains(usuario.Email))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        /// <summary>
        /// Cifrars the specified contrasena.
        /// </summary>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns></returns>
        public string cifrar(string contrasena)
        {
            // Utilizamos SHA256 para el hash
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertimos la contraseña a un array de bytes
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasena));

                // Convertimos los bytes a una representación hexadecimal
                StringBuilder hashString = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    hashString.Append(bytes[i].ToString("X2"));
                }

                // Limitamos la longitud a 30 caracteres
                string resultado = hashString.ToString();
                if (resultado.Length > 30)
                {
                    resultado = resultado.Substring(0, 30);
                }

                return resultado;
            }
        }

            public UsuarioDTO comprobarLogin(String email, String pass)
        {
            pass = cifrar(pass);
            Datos.Repositorys.UsuarioRepository datos = new Datos.Repositorys.UsuarioRepository();
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            Usuario usuario = datos.ObtenerUsuarios().Where(x => x.Email == email && x.Passwd == pass).FirstOrDefault();
            if (usuario != null) {
                usuarioDTO.Nombre = usuario.Nombre;
                usuarioDTO.Apellidos = usuario.Apellidos;
                usuarioDTO.Telefono = usuario.Telefono;
                usuarioDTO.DNI = usuario.DNI;
                usuarioDTO.Direccion = usuario.Direccion;
                usuarioDTO.Cuenta_Corriente = usuario.Cuenta_Corriente;
                usuarioDTO.Email = usuario.Email;
                usuarioDTO.Passwd = cifrar(usuario.Passwd);
                return usuarioDTO;
            }

            return null;

        }


    }

   
}
