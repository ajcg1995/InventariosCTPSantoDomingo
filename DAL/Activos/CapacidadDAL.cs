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
    public class CapacidadDAL
    {
        public static void AgregarCapacidad(Capacidad capacidad)
        {
            try
            {
                var db = BDConn.Connector();
                db.Insert(capacidad);
                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Capacidad insertada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al insertar capacidad"
                    };
                    
                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static Capacidad BuscarCapacidad(int id)
        {

            try
            {
                var db = BDConn.Connector();

                Capacidad capacidadBuscada = db.Select<Capacidad>(x => x.IdCapacidad == id).FirstOrDefault();

                if (capacidadBuscada != null)
                {

                    capacidadBuscada.Codigo = 1;
                    capacidadBuscada.Mensaje = "Capacidad cargada correctamente";

                }
                else
                {

                    capacidadBuscada.Codigo = 99;
                    capacidadBuscada.Mensaje = "Capacidad no existe";

                }
                return capacidadBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(Capacidad capacidad)
        {
            try
            {
                var db = BDConn.Connector();
                db.Update(capacidad);
                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Capacidad modificada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar capacidad"
                    };

                }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void EliminarCapacidad(Capacidad capacidad)
        {
            try
            {
                var db = BDConn.Connector();
               db.Delete(capacidad);

                /*

                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Capacidad eliminada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar capacidad"
                    };

                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static ListadoCapacidad ListarCapacidadPorId(string identificacion)
        {
            try
            {
                var db = BDConn.Connector();
                ListadoCapacidad listado = new ListadoCapacidad();

                listado.listado = db.SqlList<Capacidad>(string.Format("EXEC SPListarCapacidadPorID " +
                     "@Identificacion = '{0}' ",
                     identificacion));

                return listado;
            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
