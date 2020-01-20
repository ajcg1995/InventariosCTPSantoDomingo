using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    public class ListadoUsuarioCompleto : ResultadoPorSP
    {
        public List<UsuarioCompleto> ListaUsuarios{ get; set; }
    }
}
