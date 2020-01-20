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
    public class AulaDAL
    {
        public static ResultadoPorSP AgregarAula(Aula aula, Usuario usuario)
         {
            try
            {
                var db = BDConn.Connector();
                var resultado = db.SqlList<ResultadoPorSP>(string.Format("EXEC  SPInsertarAula " +
                    "@NombreAula = '{0}', " +
                    "@IdTipoAula = {1} ," +
                    "@IdUsuario = {2} , " +
                    "@Usuario = '{3}' ",

                    aula.NombreAula,
                    aula.IdTipoAula,
                    aula.IdControllUsuario,
                    usuario.Correo)).FirstOrDefault();


                return resultado;

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static Aula BuscarAula(int id)
        {

            try
            {
                var db = BDConn.Connector();

                Aula aulaBuscada = db.Select<Aula>(x => x.IdAula == id).FirstOrDefault();

                if (aulaBuscada != null)
                {

                    aulaBuscada.Codigo = 1;
                    aulaBuscada.Mensaje = "Aula cargada correctamente";

                }
                else
                {

                    aulaBuscada.Codigo = 99;
                    aulaBuscada.Mensaje = "Aula no existe";

                }
                return aulaBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }



        public static void Modificar(Aula aula)
        {
            try
            {
                var db = BDConn.Connector();

                db.Update(aula);

                
                /*              
              if (result > 0)
              {
                  return new Resultado
                  {
                      Codigo = 1,
                      Mensaje = "Aula modificada correctamente"
                  };

              }
              else
              {
                  return new Resultado
                  {
                      Codigo = 99,
                      Mensaje = "Problemas al modificar aula"
                  };

              }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static ResultadoPorSP EliminarAula(int idAulaEliminar)
        {
            try
            {
                var db = BDConn.Connector();
                ResultadoPorSP resultado = db.SqlList<ResultadoPorSP>(string.Format("EXEC SPEliminarAula " +
                    "@IdAula = {0} ",

                    idAulaEliminar
                    )).FirstOrDefault();

                return resultado;

            }
            catch (Exception e)
            {

                throw;
            }
        }


        public static ListadoAulaCompleto ListadoCompletoAula() {

            try
            {
                var db = BDConn.Connector();

                ListadoAulaCompleto lista = new ListadoAulaCompleto();

                lista.ListadoAulas = db.SqlList<AulaCompleto>(string.Format("Exec SPListadoCompletoAulas "));



                if (lista.ListadoAulas != null && lista.ListadoAulas.Count() > 0)
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
