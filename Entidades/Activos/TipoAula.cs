using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("TiposAulas")]
    public class TipoAula : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int IdTipoAula { get; set; }

        public string Tipo { get; set; }
    }
}
