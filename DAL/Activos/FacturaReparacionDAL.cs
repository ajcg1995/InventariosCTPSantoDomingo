using Entidades;
using Entidades.Activos;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Activos
{
    public class FacturaReparacionDAL
    {
        public static void AgregarFacturaReparacion(FacturaReparacion FacturaReparacion)
        {
            try
            {
                var db = BDConn.Connector();
                db.Insert(FacturaReparacion);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Factura de reparacion insertada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al insertar factura de reparacion"
                    };

                }*/

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
                var db = BDConn.Connector();

                FacturaReparacion FacturaReparacionBuscada = db.Select<FacturaReparacion>(x => x.IdFacturaReparacion == id).FirstOrDefault();

                if (FacturaReparacionBuscada != null)
                {

                    FacturaReparacionBuscada.Codigo = 1;
                    FacturaReparacionBuscada.Mensaje = "Factura de reparacion cargada correctamente";

                }
                else
                {

                    FacturaReparacionBuscada.Codigo = 99;
                    FacturaReparacionBuscada.Mensaje = "Factura de reparacion no existe";

                }
                return FacturaReparacionBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(FacturaReparacion FacturaReparacion)
        {
            try
            {
                var db = BDConn.Connector();
               db.Update(FacturaReparacion);
                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Factura de reparacion modificada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar factura de reparacion"
                    };

                }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void EliminarFacturaReparacion(FacturaReparacion FacturaReparacion)
        {
            try
            {
                var db = BDConn.Connector();
                db.Delete(FacturaReparacion);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Factura de reparacion eliminada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar factura de reparacion"
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