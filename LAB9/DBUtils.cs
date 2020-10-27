using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9

{
    class DBUtils
    {
        protected SqlConnection connection;

        public DBUtils()
        {
            connection = GetDBConnection();
            connection.Open();
        }

        public static SqlConnection GetDBConnection()
        {
            string datasource = @"TASS\TASSSQL";
            string database = "CSharpDemo";
            string username = "sa";
            string password = "1";

            return GetDBConnection(datasource, database, username, password);
        }

        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                                + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }


    }
}

