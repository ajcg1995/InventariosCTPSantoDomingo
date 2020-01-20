using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    [Alias("Usuarios")]
    public class Usuario : Resultado
    {
        [PrimaryKey]
        public int IdUsuario { get; set; }

        public string Nombre{ get; set; }

        public string Apellido{ get; set; }

        public string  Correo{ get; set; }

        public string password { get; set; }

        public int IdRol { get; set; }

    }
}
