using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("Leyes")]
    public class Ley : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int IdLeyAdquirida { get; set; }

        public string LeyAdquirida { get; set; }
    }
}
