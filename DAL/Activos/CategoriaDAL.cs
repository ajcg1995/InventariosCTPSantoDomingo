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
    public class CategoriaDAL
    {
        public static void AgregarCategoria(Categoria categoria)
        {
            try
            {
                var db = BDConn.Connector();
                db.Insert(categoria);

                /*if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Categoria insertada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al insertar categoria"
                    };

                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }



        public static Categoria BuscarCategoria(int id)
        {

            try
            {
                var db = BDConn.Connector();

                Categoria categoriaBuscada = db.Select<Categoria>(x => x.IdCategoria == id).FirstOrDefault();

                if (categoriaBuscada != null)
                {

                    categoriaBuscada.Codigo = 1;
                    categoriaBuscada.Mensaje = "Categoria cargada correctamente";

                }
                else
                {

                    categoriaBuscada.Codigo = 99;
                    categoriaBuscada.Mensaje = "Categoria no existe";

                }
                return categoriaBuscada;
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void Modificar(Categoria categoria)
        {
            try
            {
                var db = BDConn.Connector();

                db.Update(categoria);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Categoria modificada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al modificar categoría"
                    };

                }*/
            }
            catch (Exception)
            {
                throw;
            }

        }


        public static void EliminarCategoria(Categoria categoria)
        {
            try
            {
                var db = BDConn.Connector();
                db.Delete(categoria);

                /*
                if (result > 0)
                {
                    return new Resultado
                    {
                        Codigo = 1,
                        Mensaje = "Categoria eliminada correctamente"
                    };

                }
                else
                {
                    return new Resultado
                    {
                        Codigo = 99,
                        Mensaje = "Problemas al eliminar categoria"
                    };

                }*/

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Categoria> ListaCategorias() {

            try
            {
                var db = BDConn.Connector();
                List<Categoria> listado = db.Select<Categoria>();

                return listado;
            }
            catch (Exception)
            {

                throw;
            }

        }




    }
}
