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
    public class EstadoDAL
    {
        public static void AgregarEstado(Estado estado)
        {
            try
            {
                var db = BDConn.Connector();
                db.Insert(estado);
                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Estado insertado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al insertar estado"
                    };

                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static Estado BuscarEstado(int id)
        {

            try
            {
                var db = BDConn.Connector();

                Estado estadoBuscada = db.Select<Estado>(x => x.IdEstado == id).FirstOrDefault();

                if (estadoBuscada != null)
                {

                    estadoBuscada.Codigo = 1;
                    estadoBuscada.Mensaje = "Estado cargado correctamente";

                }
                else
                {

                    estadoBuscada.Codigo = 99;
                    estadoBuscada.Mensaje = "Estado no existe";

                }
                return estadoBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(Estado estado)
        {
            try
            {
                var db = BDConn.Connector();
                
                    db.Update(estado);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Estado modificado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar estado"
                    };

                }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void EliminarEstado(Estado estado)
        {
            try
            {
                var db = BDConn.Connector();
                db.Delete(estado);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Estado eliminado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar estado"
                    };
                    
                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Estado> listadoEstados()
        {
            try
            {
                var db = BDConn.Connector();


                List<Estado> listado = db.Select<Estado>();

                return listado;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}