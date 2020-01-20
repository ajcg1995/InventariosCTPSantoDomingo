using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("Categorias")]
    public class Categoria : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int IdCategoria { get; set; }

        public string NombreCategoria { get; set; }
    }
}
