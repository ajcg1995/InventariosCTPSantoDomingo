using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    public class ActivosPorAulas : ResultadoPorSP
    {
        public string Identificacion { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Ubicacion { get; set; }
        public string Proveedor { get; set; }
        public string FechaCreacion { get; set; }
        public string Depreciacion { get; set; }
        public string LeyAdquirida { get; set; }
        public string NombreCategoria { get; set; }
        public string NombreAula { get; set; }
        public string Estados { get; set; }
        public string Nombre { get; set; }   

    }
}
