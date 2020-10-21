using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDBC_Demo
{
    class CountryDAO:DBUtils
    {
        public List<string> getAll()
        {
            List<string> results = new List<string>();
            string sql = "SELECT * FROM dbo.COUNTRY";

            // Tạo một đối tượng Command.
            SqlCommand cmd = new SqlCommand(sql, connection);

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        results.Add(reader.GetString(1));
                    }
                }
            }

            return results;
        }
    }
}
