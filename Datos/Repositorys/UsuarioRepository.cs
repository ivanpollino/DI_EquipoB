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
                //Ususario_Normal ususarioNormal = new Ususario_Normal();
                //ususarioNormal.DNI = usuario.DNI;
                //ususarioNormal.Id_Actividad = 0;
            using (var contexto = new equipobEntities1())
                {
                    contexto.Usuario.Add(usuario);
                    //contexto.Ususario_Normal.Add(ususarioNormal);
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
                using (var contexto = new equipobEntities1())
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
