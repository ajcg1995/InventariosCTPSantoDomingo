using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Activos
{
    [Alias("PrestadorServicio")]
    public class PrestadorServicio : Resultado
    {
        [AutoIncrement]
        [PrimaryKey]
        public int IdPrestadorServicio  { get; set; }

        public string Empresa { get; set; }

        public string Tecnico { get; set; }

        public string CedulaTecnico{ get; set; }

        public DateTime  FechaVisita{ get; set; }

        public int IdReparacion { get; set; }
    }



}
