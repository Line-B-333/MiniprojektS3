using Microsoft.Data.SqlClient; // sqlconnection works with this package
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAO.Library.sqlserver
{
    //Create a connection string
    //Den er abstrakt fordi den ikke skal instantieres direkte


    public abstract class BaseDAO
    {
        public string ConnectionString { get; private set; }
        protected BaseDAO(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            //Microsoft.Data.SqlClient;
            return new SqlConnection(ConnectionString);
        }
    }
}
