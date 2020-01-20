using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BDConn
    {

        public static IDbConnection Connector() {

            try
            {
                string cadena = "Server=tcp:kawas.database.windows.net,1433;Initial Catalog=Infinity;Persist Security Info=False;User ID=ffonseca;Password=Fidelitas2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=60";

                OrmLiteConnectionFactory con = new OrmLiteConnectionFactory(cadena, SqlServerDialect.Provider);
                IDbConnection db = con.OpenDbConnection();
                return db;
            }
            catch (Exception)
            {

                throw;
            }
        }







    }       
}