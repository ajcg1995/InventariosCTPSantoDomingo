using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("Reparaciones")]
    public class Reparacion : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int  IdReparacion { get; set; }

        public string DetalleReporte { get; set; }

        public string FechaReporte{ get; set; }

        public string FechaReparacion { get; set; }


        public string DetalleReparacion { get; set; }

        public int  IdFacturaReparacion{ get; set; }

        public int IdPrestadorServicio { get; set; }

        public string Identificacion { get; set; }


    }
}
