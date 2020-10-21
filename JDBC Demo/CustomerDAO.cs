using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDBC_Demo
{
    class CustomerDAO : DBUtils
    {
        public List<CustomerModel> GetAll()
        {
            List<CustomerModel> results = new List<CustomerModel>();

            //SqlConnection connection= DBUtils.GetDBConnection();
            //connection.Open();
            string sql = "SELECT * FROM dbo.CUSTOMER";

            // Tạo một đối tượng Command.
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
                        customer.Address = reader.GetString(2);
                        customer.City = reader.GetString(3);
                        customer.Country = reader.GetString(4);
                        customer.Phone = reader.GetString(5);
                        customer.ZipCode = reader.GetString(6);
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
                // Câu lệnh Insert.
                string sql = "INSERT INTO dbo.CUSTOMER\n" +
                             "(CUSTOMERNAME,ADDRESS,CITY,COUNTRY, PHONE, ZIPCODE)\n" +
                             "VALUES\n" +
                             "(@customerName, @address,@city,@country,@phone,@zipCode)";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@customerName", SqlDbType.NVarChar).Value = customer.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = customer.Address;
                cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = customer.City;
                cmd.Parameters.Add("@country", SqlDbType.NVarChar).Value = customer.Country;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = customer.Phone;
                cmd.Parameters.Add("@zipCode", SqlDbType.NVarChar).Value = customer.ZipCode;

                // Thực thi Command (Dùng cho delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
        }

        public CustomerModel findById(int id)
        {
            try
            {
                // Câu lệnh Insert.
                string sql = "SELECT* FROM dbo.CUSTOMER WHERE CUSTOMERID = @id";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            CustomerModel customer = new CustomerModel();
                            customer.Id = reader.GetInt32(0);
                            customer.Name = reader.GetString(1);
                            customer.Address = reader.GetString(2);
                            customer.City = reader.GetString(3);
                            customer.Country = reader.GetString(4);
                            customer.Phone = reader.GetString(5);
                            customer.ZipCode = reader.GetString(6);
                            return customer;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }

            return null;
        }

        public void deleteById(int id)
        {
            try
            {
                // Câu lệnh Insert.
                string sql = "DELETE dbo.CUSTOMER WHERE CUSTOMERID = @id ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;


                // Thực thi Command (Dùng cho delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
        }

        public void update(CustomerModel customer)
        {
            try
            {
                // Câu lệnh Insert.
                string sql = "UPDATE dbo.CUSTOMER SET CUSTOMERNAME = @customerName, ADDRESS=@address, CITY=@city,COUNTRY=@country,ZIPCODE=@zipCode, PHONE=@phone WHERE CUSTOMERID = @id";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                cmd.Parameters.Add("@customerName", SqlDbType.NVarChar).Value = customer.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = customer.Address;
                cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = customer.City;
                cmd.Parameters.Add("@country", SqlDbType.NVarChar).Value = customer.Country;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = customer.Phone;
                cmd.Parameters.Add("@zipCode", SqlDbType.NVarChar).Value = customer.ZipCode;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = customer.Id;

                // Thực thi Command (Dùng cho delete, insert, update).
                int rowCount = cmd.ExecuteNonQuery();

                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
