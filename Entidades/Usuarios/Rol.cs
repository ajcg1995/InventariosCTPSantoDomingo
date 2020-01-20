using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    [Alias("Activos")]
    public class Rol : Resultado
    {
        public int IdRol { get; set; }

        public string RolUsuario { get; set; }
    }
}
