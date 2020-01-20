using Entidades.Activos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ListaTipoAula : ResultadoPorSP
    {
        public List<TipoAula> ListadoTipoAula { get; set; }
    }
}
