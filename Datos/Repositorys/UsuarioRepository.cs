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
    public class UsuarioRepository
    {

        public String altaUsuario(Usuario usuario)
        {
                using (var contexto = new equipobEntities())
                {
                    contexto.Usuario.Add(usuario);
                    contexto.SaveChanges();
                    
                }
            return "Usuario añadido con exito";
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                //Abrir la BD
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
    }
}
