using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("Capacidades")]
    public class Capacidad : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int IdCapacidad { get; set; }

        public string Detalle{ get; set; }

        public string Identificacion { get; set; }

    }
}
