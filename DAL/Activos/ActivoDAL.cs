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
    public class ActivoDAL
    {
        public static Resultado AgregarActivo(Activo activo, Usuario usuario)
        {
            try
            {
                var db = BDConn.Connector();

                Resultado resultado = db.SqlList<Resultado>(string.Format("EXEC SPInsertarActivos " +
                    "@Identificacion = '{0}', " +
                    "@Descripcion = '{1}', " +
                    "@Marca = '{2}', " +
                    "@Ubicacion = '{3}', " +
                    "@Proveedor = '{4}', " +
                    "@FechaCreacion = '{5}', " +
                    "@Depreciacion = {6}, " +
                    "@IdFacturaActivos = {7}, " +
                    "@IdLeyAdquirida = {8}, " +
                    "@IdCategoria = {9}, " +
                    "@IdAula = {10}, " +
                    "@IdEstado = {11}, " +
                    "@IdUsuario = {12}," +
                    "@Usuario = '{13}' ",

                    activo.Identificacion,
                    activo.Descripcion,
                    activo.Marca,
                    activo.Ubicacion,
                    activo.Proveedor,
                    activo.FechaCreacion,
                    activo.Depreciacion,
                    activo.IdFacturaActivos,
                    activo.IdLeyAdquirida,
                    activo.IdCategoria,
                    activo.IdAula,
                    activo.IdEstado,
                    activo.IdUsuario,
                    usuario.Nombre
                    
                    )).FirstOrDefault();

                return resultado;



            }
            catch (Exception ex)
            {

                throw;
            }
        }



        /*public static Activo BuscarActivo(string id)
        {

            try
            {
                var db = BDConn.Connector();

               // return activoBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }*/


        public static void Modificar(Activo activo, Usuario usuario)
        {

            try
            {
                var db = BDConn.Connector();

                Resultado resultado = db.SqlList<Resultado>(string.Format("EXEC SPActualizarActivos " +
                    "@Identificacion = '{0}', " +
                    "@Descripcion = '{1}', " +
                    "@Marca = '{2}', " +
                    "@Ubicacion = '{3}', " +
                    "@Proveedor = '{4}', " +
                    "@FechaCreacion = '{5}', " +
                    "@Depreciacion = {6}, " +
                    "@IdFacturaActivos = {7}, " +
                    "@IdLeyAdquirida = {8}, " +
                    "@IdCategoria = {9}, " +
                    "@IdAula = {10}, " +
                    "@IdEstado = {11}, " +
                    "@IdUsuario = {12}," +
                    "@Usuario = '{13}' ",

                    activo.Identificacion,
                    activo.Descripcion,
                    activo.Marca,
                    activo.Ubicacion,
                    activo.Proveedor,
                    activo.FechaCreacion,
                    activo.Depreciacion,
                    activo.IdFacturaActivos,
                    activo.IdLeyAdquirida,
                    activo.IdCategoria,
                    activo.IdAula,
                    activo.IdEstado,
                    activo.IdUsuario,
                    usuario.Nombre

                    )).FirstOrDefault();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        /*
        try
        {
            var db = BDConn.Connector();
            db.Update(activo);


            if (result > 0)
            {
                return new Resultado
                {
                    Codigo = 1,
                    Mensaje = "Activo modificado correctamente"
                };

            }
            else
            {
                return new Resultado
                {
                    Codigo = 99,
                    Mensaje = "Problemas al modificar activo"
                };

            }*/




        public static void EliminarActivo(Activo activo)
        {
            try
            {
                var db = BDConn.Connector();
                db.Delete(activo);

                

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Activo eliminado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar activo"
                    };

                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static ListaActivosPorAulas ListadoActivosPorAulas(int idAula) {

            var db = BDConn.Connector();
            ListaActivosPorAulas listado = new ListaActivosPorAulas();

            listado.Listado = db.SqlList<ActivosPorAulas>(string.Format("EXEC SPListarActivosPorAulas "+
                 "@IdAula = {0} ",
                 idAula));



            if (listado.Listado != null && listado.Listado.Count() > 0)
            {
                listado.Codigo = 1;
                listado.Mensaje = "Lista Correcta";

            }
            else
            {
                listado.Codigo = 99;
                listado.Mensaje = "Problemas ";
            }



            return listado;



        }

        public static ActivosPorAulas BuscarActivosPorAulas(int idActivo)
        {

            var db = BDConn.Connector();


            ActivosPorAulas activo = db.SqlList<ActivosPorAulas>(string.Format("EXEC SPBuscarActivosPorAulas " +
                 "@IdActivo = {0} ",
                 idActivo)).FirstOrDefault();



            if (activo != null)
            {
                activo.Codigo = 1;
                activo.Mensaje = "Lista Correcta";

            }
            else
            {
                activo.Codigo = 99;
                activo.Mensaje = "Problemas ";
            }
            return activo;
        }



        public static Activo BuscarUnActivo(string identificacion)
        {
            try
            {
                var db = BDConn.Connector();

                //Activo activo = db.Select<Activo>(x => x.Identificacion == identificacion).FirstOrDefault();
               
                Activo activo = db.SqlList<Activo>(string.Format("EXEC SPBuscarunActivo " +
                     "@Identificacion = '{0}' ",
                     identificacion)).FirstOrDefault();


                if (activo != null)
                {
                    activo.Codigo = 1;
                    activo.Mensaje = "Lista Correcta";

                    return activo;
                }
                else
                {
                    Activo a = new Activo();
                    a.Codigo = 99;
                    a.Mensaje = "Problemas ";

                    return a;
                }

                
            }
            catch (Exception e)
            {

                throw;
            }        


        }

        public static ListaActivosPorAulas ListadoActivosTecnolgicosPorAulas(int idAula)
        {

            var db = BDConn.Connector();
            ListaActivosPorAulas listado = new ListaActivosPorAulas();

            listado.Listado = db.SqlList<ActivosPorAulas>(string.Format("EXEC SPListarActivosTecnologicos " +
                 "@IdAula = {0} ",
                 idAula));



            if (listado.Listado != null && listado.Listado.Count() > 0)
            {
                listado.Codigo = 1;
                listado.Mensaje = "Lista Correcta";

            }
            else
            {
                listado.Codigo = 99;
                listado.Mensaje = "Problemas ";
            }



            return listado;

        }


        public static ListadoActivoReparacion ListadoActivosReparacion()
        {

            var db = BDConn.Connector();
            ListadoActivoReparacion listado = new ListadoActivoReparacion();

            listado.Listado = db.SqlList<ActivoReparacion>(string.Format("EXEC SPListarActivosEnReparacion " ));

                 



            if (listado.Listado != null && listado.Listado.Count() > 0)
            {
                listado.Codigo = 1;
                listado.Mensaje = "Lista Correcta";

            }
            else
            {
                listado.Codigo = 99;
                listado.Mensaje = "Problemas ";
            }



            return listado;



        }



    }
}
