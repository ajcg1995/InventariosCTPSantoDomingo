using DAL.Activos;
using Entidades;
using Entidades.Activos;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Activos
{
    public class FacturaActivoBLL
    {
        public static ResultadoPorSP AgregarFacturaActivo(FacturaActivo facturaactivo,Usuario usuario)
        {
            try
            {
                return FacturaActivoDAL.AgregarFacturaActivo(facturaactivo, usuario);
            }
            catch (Exception)
            {

                throw;
            }



        }

        public static FacturaActivo BuscarFacturaActivo(int id)
        {
            try
            {
                return FacturaActivoDAL.BuscarFacturaActivo(id);
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static void Modificar(FacturaActivo facturaactivo)
        {

            try
            {
                FacturaActivoDAL.Modificar(facturaactivo);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarFacturaActivo(FacturaActivo facturaactivo)
        {

            try
            {
                FacturaActivoDAL.EliminarFacturaActivo(facturaactivo);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
