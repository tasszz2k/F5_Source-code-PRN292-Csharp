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
    class DVDLibraryDAO:DBUtils
    {
        public List<DVDLibrary> getAll()
        {
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();
                List<DVDLibrary> results = new List<DVDLibrary>();
                DVDLibrary model = new DVDLibrary();
                string sql = "SELECT * FROM dbo.DVDLibrary";

                // create SQLCommand.
                SqlCommand cmd = new SqlCommand(sql, connection);

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.Code = reader.GetInt32(0);
                            model.Title = reader.GetString(1);
                            model.Language = reader.GetString(2);
                            model.Subtitles = reader.GetBoolean(3);
                            model.Price = (float) reader.GetDouble(4);

                            results.Add(model); 
                        }
                    }
                }

                return results;
            }
        }



        public DVDLibrary findById(int code)
        {
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();
                
                DVDLibrary model = new DVDLibrary();
                string sql = "SELECT * FROM dbo.DVDLibrary WHERE DVDCodeNo = @code";

                // create SQLCommand.
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@code", code);

                SqlDataAdapter sqlDa = new SqlDataAdapter();
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            model.Code = reader.GetInt32(0);
                            model.Title = reader.GetString(1);
                            model.Language = reader.GetString(2);
                            model.Subtitles = reader.GetBoolean(3);
                            model.Price = (float)reader.GetDouble(4);


                            return model;
                        }
                    }
                }

                return null;
            }
        }



        public void Insert(DVDLibrary dvd)
        {
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();

                string sql = "INSERT INTO dbo.DVDLibrary VALUES(@title,@language,@subtitles,@price)";

                SqlCommand sqlCmd = new SqlCommand(sql, connection);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

                //set param
                sqlCmd.Parameters.AddWithValue("@title", dvd.Title);
                sqlCmd.Parameters.AddWithValue("@language", dvd.Language);
                sqlCmd.Parameters.AddWithValue("@subtitles", dvd.Subtitles);
                sqlCmd.Parameters.AddWithValue("@price",dvd.Price);

                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
