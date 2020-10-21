using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Test_JDBC
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"TASS\TASSSQL";

            string database = "CSharpDemo";
            string username = "sa";
            string password = "1";

            return GetDBConnection(datasource, database, username, password);
        }

        public static SqlConnection
            GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }


    }
}
