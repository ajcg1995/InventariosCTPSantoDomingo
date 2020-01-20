using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("Activos")]
    public class Activo : Resultado
    {
        [PrimaryKey]
        public string Identificacion { get; set; }
        public string Descripcion{ get; set; }
        public string Marca{ get; set; }
        public string Ubicacion{ get; set; }
        public string Proveedor { get; set; }
        public string FechaCreacion{ get; set;}
        public string Depreciacion { get; set; }
        public int IdFacturaActivos { get; set; }                         
        public int IdLeyAdquirida   { get; set; }
        public int IdCategoria { get; set; }
        public int IdAula { get; set; }
        public int IdEstado { get; set; }
        public int IdUsuario { get; set; }




    }
}
