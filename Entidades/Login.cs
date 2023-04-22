using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public string CodigoUsuario { get; set; }
        public string Constraseña { get; set; }
        public string Rol { get; set; }
    
        public Login()
        {
        }

        public Login(string codigoUsuario, string constraseña, string rol)
        {
            CodigoUsuario = codigoUsuario;
            Constraseña = constraseña;
            Rol = rol;
        }
    }
}
