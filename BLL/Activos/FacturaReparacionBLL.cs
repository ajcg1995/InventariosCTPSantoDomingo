using DAL.Activos;
using Entidades;
using Entidades.Activos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Activos
{
    public class FacturaReparacionBLL
    {
        public static void AgregarFacturaReparacion(FacturaReparacion facturareparacion)
        {
            try
            {
                FacturaReparacionDAL.AgregarFacturaReparacion(facturareparacion);
            }
            catch (Exception)
            {

                throw;
            }



        }

        public static FacturaReparacion BuscarFacturaReparacion(int id)
        {
            try
            {
                return FacturaReparacionDAL.BuscarFacturaReparacion(id);
            }
            catch (Exception)
            {

                throw;
            }


        }


        public static void Modificar(FacturaReparacion facturareparacion)
        {

            try
            {
                FacturaReparacionDAL.Modificar(facturareparacion);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarFacturaReparacion(FacturaReparacion facturareparacion)
        {

            try
            {
                FacturaReparacionDAL.EliminarFacturaReparacion(facturareparacion);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
