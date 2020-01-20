using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("Estados")]
    public class Estado : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int IdEstado { get; set; }

        public string Estados { get; set; }
    }
}
