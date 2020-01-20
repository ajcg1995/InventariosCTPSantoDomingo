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
    public class ReparacionDAL
    {
        public static void AgregarReparacion(Reparacion reparacion,Usuario usuario)
        {
            try
            {
                var db = BDConn.Connector();
                var resultado = db.SqlList<ResultadoPorSP>(string.Format("EXEC  SPInsertarDetalleReporte " +
                    "@DetalleReporte = '{0}', " +
                    "@FechaReporte = '{1}' ," +
                    "@Identificacion = '{2}' , " +
                    "@Usuario = '{3}' ",

                    reparacion.DetalleReporte,
                    reparacion.FechaReporte,
                    reparacion.Identificacion.Trim(),
                    usuario.Correo)).FirstOrDefault();

                                               

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static Reparacion BuscarReparacion(int id)
        {

            try
            {
                var db = BDConn.Connector();

                Reparacion reparacionBuscada = db.First<Reparacion>(x => x.IdReparacion == id);

                if (reparacionBuscada != null)
                {

                    reparacionBuscada.Codigo = 1;
                    reparacionBuscada.Mensaje = "Reparacion cargada correctamente";

                }
                else
                {

                    reparacionBuscada.Codigo = 99;
                    reparacionBuscada.Mensaje = "Reparacion no existe";

                }
                return reparacionBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(Reparacion reparacion, Usuario usuario)
        {
            try
            {
                var db = BDConn.Connector();
                var resultado = db.SqlList<ResultadoPorSP>(string.Format("EXEC  SPModificarDetalleReporte " +
                    "@IdReparacion = {0}, " +
                    "@Identificacion = '{1}' ," +
                    "@DetalleReporte = '{2}' , " +
                    "@FechaReporte = '{3}' , " +
                    "@Usuario = '{4}' ",

                    reparacion.IdReparacion,
                    reparacion.Identificacion.Trim(),
                    reparacion.DetalleReparacion,
                    reparacion.FechaReparacion,
                    usuario.Correo)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static void EliminarReparacion(Reparacion reparacion)
        {
            try
            {
                var db = BDConn.Connector();
                db.Delete(reparacion);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Reparacion eliminada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar reparacion"
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
