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
    public class LeyDAL
    {
        public static ResultadoPorSP AgregarLey(Ley ley)
        {
            try
            {
                var db = BDConn.Connector();
                ResultadoPorSP resultado = db.SqlList<ResultadoPorSP>(string.Format("EXEC SPInsertarLeyes " +
                    "@LeyAdquirida = '{0}'," +
                    "@Usuario = '{1}' ",

                    ley.LeyAdquirida,
                    "ajcg1995@hotmail.com"
                    )).FirstOrDefault();

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Ley> ListadoLeyes()
        {
            try
            {
                var db = BDConn.Connector();

                List<Ley> listado = db.Select<Ley>();

                return listado;
            }
            catch (Exception)
            {

                throw;
            }
        }



        public static Ley BuscarLey(int id)
        {

            try
            {
                var db = BDConn.Connector();

                Ley leyBuscada = db.Select<Ley>(x => x.IdLeyAdquirida == id).FirstOrDefault();

                if (leyBuscada != null)
                {

                    leyBuscada.Codigo = 1;
                    leyBuscada.Mensaje = "Ley cargada correctamente";

                }
                else
                {

                    leyBuscada.Codigo = 99;
                    leyBuscada.Mensaje = "Ley no existe";

                }
                return leyBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(Ley ley)
        {
            try
            {
                var db = BDConn.Connector();
                db.Update(ley);
                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Ley modificada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar ley"
                    };

                }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void EliminarLey(Ley ley)
        {
            try
            {
                var db = BDConn.Connector();

                db.Delete(ley);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Ley eliminada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar ley"
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
