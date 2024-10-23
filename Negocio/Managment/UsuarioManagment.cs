using Datos.Infrastructure;
using Datos.Repositorys;
using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private string cifrar(string contrasena)
        {
            const int claveSecreta = 12345;
            StringBuilder cifrado = new StringBuilder();

            for (int i = 0; i < contrasena.Length; i++)
            {
                int asciiValue = (int)contrasena[i];

                int valorCifrado = asciiValue * (i + 1);
                valorCifrado = valorCifrado ^ claveSecreta;
                valorCifrado += (i * 17);

                cifrado.Append(valorCifrado.ToString("X").PadLeft(2, '0').Substring(0, 2));
            }

            string resultado = cifrado.ToString();

            if (resultado.Length > 30)
            {
                resultado = resultado.Substring(0, 30);
            }

            return resultado;
        }


    }

   
}
