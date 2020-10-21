using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDBC_Demo
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"TASS\TASSSQL";

            string database = "CSharpDemo";
            string username = "sa";
            string password = "1";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }

    }
}
