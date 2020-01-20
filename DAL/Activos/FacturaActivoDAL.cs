using Entidades;
using Entidades.Activos;
using Entidades.Usuarios;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Activos
{
    public class FacturaActivoDAL
    {
        public static ResultadoPorSP AgregarFacturaActivo(FacturaActivo facturaactivo, Usuario usuario)
        {
            try
            {
                var db = BDConn.Connector();

                var resultado = db.SqlList<ResultadoPorSP>(string.Format("EXEC  SPInsertarFacturaActivos " +
                    "@NumeroFactura = '{0}', " +
                    "@FechaFactura = '{1}'," +
                    "@Monto = {2}, " +
                    "@Moneda = '{3}', " +
                    "@Identificacion = '{4}'," +
                    "@Usuario = '{5}'",

                    facturaactivo.NumeroFactura,
                    facturaactivo.FechaFactura,
                    facturaactivo.Monto,
                    facturaactivo.Moneda,
                    facturaactivo.Identificacion,
                    usuario.Nombre)).FirstOrDefault();
                    


                return resultado;

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
                var db = BDConn.Connector();

                FacturaActivo facturaactivoBuscada = db.Select<FacturaActivo>(x => x.IdFacturaActivos == id).FirstOrDefault();

                if (facturaactivoBuscada != null)
                {

                    facturaactivoBuscada.Codigo = 1;
                    facturaactivoBuscada.Mensaje = "Factura del activo cargada correctamente";

                }
                else
                {

                    facturaactivoBuscada.Codigo = 99;
                    facturaactivoBuscada.Mensaje = "Factura del activo no existe";

                }
                return facturaactivoBuscada;
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
                var db = BDConn.Connector();
                db.Update(facturaactivo);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Factura del activo modificada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar factura del activo"
                    };

                }*/
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
                var db = BDConn.Connector();
                 db.Delete(facturaactivo);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Factura del activo eliminada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar factura del activo"
                    };

                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
