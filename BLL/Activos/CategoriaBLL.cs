using DAL.Activos;
using Entidades;
using Entidades.Activos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Activos
{
    public class CategoriaBLL
    {
        public static void AgregarCategoria(Categoria categoria)
        {
            try
            {
                 CategoriaDAL.AgregarCategoria(categoria);
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
                return CategoriaDAL.BuscarCategoria(id);
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
                CategoriaDAL.Modificar(categoria);
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
                CategoriaDAL.EliminarCategoria(categoria);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static List<Categoria> ListaCategorias()
        {

            try
            {
                return CategoriaDAL.ListaCategorias();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
