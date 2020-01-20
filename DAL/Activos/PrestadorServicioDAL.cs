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
    public class PrestadorServicioDAL
    {
        public static void AgregarPrestadorServicio(PrestadorServicio prestadorservicio)
        {
            try
            {
                var db = BDConn.Connector();
                db.Insert(prestadorservicio);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Prestador de servicio insertado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al insertar prestador de servicio"
                    };

                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static PrestadorServicio BuscarPrestadorServicio(int id)
        {

            try
            {
                var db = BDConn.Connector();

                PrestadorServicio prestadorservicioBuscada = db.Select<PrestadorServicio>(x => x.IdPrestadorServicio == id).FirstOrDefault();

                if (prestadorservicioBuscada != null)
                {

                    prestadorservicioBuscada.Codigo = 1;
                    prestadorservicioBuscada.Mensaje = "Prestador de servicio cargado correctamente";

                }
                else
                {

                    prestadorservicioBuscada.Codigo = 99;
                    prestadorservicioBuscada.Mensaje = "Prestador de servicio no existe";

                }
                return prestadorservicioBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(PrestadorServicio prestadorservicio)
        {
            try
            {
                var db = BDConn.Connector();

                db.Update(prestadorservicio);
                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Prestador de servicio modificado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar prestador de servicio"
                    };

                }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void EliminarPrestadorServicio(PrestadorServicio prestadorservicio)
        {
            try
            {
                var db = BDConn.Connector();

                db.Delete(prestadorservicio);
                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Prestador de servicio eliminado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar prestador de servicio"
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