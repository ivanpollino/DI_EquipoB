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
                using (var contexto = new equipobEntitiesBueno())
                {
                    contexto.Usuario.Add(usuario);
                    contexto.SaveChanges();
                    
                }
            return "Usuario añadido con exito";
        }
    }
}
