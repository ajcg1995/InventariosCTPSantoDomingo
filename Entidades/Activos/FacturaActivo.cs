using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("FacturasActivos")]
    public class FacturaActivo : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int IdFacturaActivos{ get; set; }

        public string NumeroFactura{ get; set; }

        public DateTime FechaFactura { get; set; }

        public double Monto { get; set; }

        public string Moneda { get; set; }

        public string Identificacion{ get; set; }


    }
}
