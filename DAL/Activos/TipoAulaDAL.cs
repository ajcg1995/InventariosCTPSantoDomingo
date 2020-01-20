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
    public class TipoAulaDAL
    {
        public static void AgregarTipoAula(TipoAula tipoaula)
        {
            try
            {
                var db = BDConn.Connector();
                 db.Insert(tipoaula);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Tipo de aula insertado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al insertar tipo de aula"
                    };

                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static TipoAula BuscarTipoAula(int id)
        {

            try
            {
                var db = BDConn.Connector();

                TipoAula tipoaulaBuscada = db.Select<TipoAula>(x => x.IdTipoAula == id).FirstOrDefault();

                if (tipoaulaBuscada != null)
                {

                    tipoaulaBuscada.Codigo = 1;
                    tipoaulaBuscada.Mensaje = "Tipo de aula cargado correctamente";

                }
                else
                {

                    tipoaulaBuscada.Codigo = 99;
                    tipoaulaBuscada.Mensaje = "Tipo de aula no existe";

                }
                return tipoaulaBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(TipoAula tipoaula)
        {
            try
            {
                var db = BDConn.Connector();
                db.Update(tipoaula);

                /*if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Tipo de aula modificado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar tipo de aula"
                    };

                }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void EliminarTipoAula(TipoAula tipoaula)
        {
            try
            {
                var db = BDConn.Connector();
               db.Delete(tipoaula);
                
                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Tipo de aula eliminado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar tipo de aula"
                    };
                    */

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static ListaTipoAula ListadoTipoAulas()
        {

            try
            {
                var db = BDConn.Connector();

                ListaTipoAula lista = new ListaTipoAula();

                lista.ListadoTipoAula = db.SqlList<TipoAula>(string.Format("Exec SPListarAulas "));



                if (lista.ListadoTipoAula != null && lista.ListadoTipoAula.Count() > 0)
                {
                    lista.Codigo = 1;
                    lista.Mensaje = "Lista Correcta";

                }
                else
                {
                    lista.Codigo = 99;
                    lista.Mensaje = "Problemas ";
                }




                return lista;

            }
            catch (Exception)
            {

                throw;
            }




        }
    }
}
