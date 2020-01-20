using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Resultado
    {

        /*
        1 - Bien
        99 - Error
             
        */

        [Ignore]
        public int Codigo { get; set; }

        [Ignore]
        public string Mensaje { get; set; }
    }
}
