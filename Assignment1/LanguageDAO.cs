using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB10_1;

namespace Assignment1
{
    class LanguageDAO:DBUtils
    {
        public List<string> GetAll()
        {
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();
                List<string> results = new List<string>();

                string sql = "SELECT * FROM dbo.Language";

                // create SQLCommand.
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
}
