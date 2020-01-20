using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("Aulas")]
    public class Aula : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int IdAula{ get; set; }

        public string NombreAula { get; set; }

        public int IdTipoAula { get; set; }

        public int IdControllUsuario { get; set; }
    }
}
