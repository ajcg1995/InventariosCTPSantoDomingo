using Entidades;
using Entidades.Usuarios;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Usuarios
{
    public class RolDAL
    {
        public static void AgregarRol(Rol rol)
        {
            try
            {
                var db = BDConn.Connector();
                db.Insert(rol);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Rol insertado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al insertar rol"
                    };

                }
                */
            }
            catch (Exception)
            {

                throw;
            }
        }



        public static Rol BuscarRol(int id)
        {

            try
            {
                var db = BDConn.Connector();

                Rol rolBuscada = db.Select<Rol>(x => x.IdRol == id).FirstOrDefault();

                if (rolBuscada != null)
                {

                    rolBuscada.Codigo = 1;
                    rolBuscada.Mensaje = "Rol cargado correctamente";

                }
                else
                {

                    rolBuscada.Codigo = 99;
                    rolBuscada.Mensaje = "Rol no existe";

                }
                return rolBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(Rol rol)
        {
            try
            {
                var db = BDConn.Connector();

                db.Update(rol);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Rol modificado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar rol"
                    };

                }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void EliminarRol(Rol rol)
        {
            try
            {
                var db = BDConn.Connector();
                db.Delete(rol);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Rol eliminado correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar rol"
                    };

                }
                */
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static List<Rol> ListadoRoles()
        {
            try
            {
                var db = BDConn.Connector();

                List<Rol> resultado = db.SqlList<Rol>(string.Format("EXEC  SPListarRoles"));


                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }





    }
}
