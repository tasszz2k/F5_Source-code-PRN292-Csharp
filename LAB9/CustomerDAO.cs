using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB9
{
    class CustomerDAO:DBUtils
    {
        public List<CustomerModel> GetAll()
        {
            List<CustomerModel> results = new List<CustomerModel>();

            string sql = "SELECT * FROM dbo.CUSTOMER_LAB9";

            // create SQLCommand.
            SqlCommand cmd = new SqlCommand(sql, connection);

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CustomerModel customer = new CustomerModel();
                        customer.Id = reader.GetInt32(0);
                        customer.Name = reader.GetString(1);
                        customer.Dob = reader.GetDateTime(2);
                        customer.Gender = reader.GetBoolean(3);
                        customer.Address = reader.GetString(4);
                        results.Add(customer);
                    }
                }
            }
            return results;
        }

        public void insert(CustomerModel customer)
        {
            try
            {
                // Insert Query
                string sql = "INSERT INTO dbo.CUSTOMER_LAB9\r\n(CUSTOMERNAME,DOB,GENDER,ADDRESS)\r\nVALUES\r\n(@name, @dob, @gender,@address)";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = customer.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = customer.Address;
                cmd.Parameters.Add("@dob", SqlDbType.DateTime).Value = customer.Dob;
                cmd.Parameters.Add("@gender", SqlDbType.Bit).Value = customer.Gender;

                // Execute Command ( delete, insert, update).
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}
