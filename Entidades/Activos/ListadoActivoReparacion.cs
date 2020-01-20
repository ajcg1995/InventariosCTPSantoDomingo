using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    public class ListadoActivoReparacion : Resultado
    {
        public List<ActivoReparacion> Listado { get; set; }
    }
}
