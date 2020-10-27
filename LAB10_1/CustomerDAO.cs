using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB10_1
{
    class CustomerDAO : DBUtils
    {

        public DataTable GetAll()
        {
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM dbo.CUSTOMER_LAB9";
                SqlCommand sqlCmd = new SqlCommand(sql,connection);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                return dtbl;
            }

        }



        public void Insert(DataGridViewRow dgvRow)
        {
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();

                string sql = "INSERT INTO dbo.CUSTOMER_LAB9\r\n(CUSTOMERNAME,DOB,GENDER,ADDRESS)\r\nVALUES\r\n(@name,@dob,@gender,@address)";

                SqlCommand sqlCmd = new SqlCommand(sql, connection);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

                //set param
                sqlCmd.Parameters.AddWithValue("@name", dgvRow.Cells[1].Value == DBNull.Value ? "" : dgvRow.Cells[1].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@dob", dgvRow.Cells[2].Value == DBNull.Value ? DateTime.Now.ToString("yyyy/MM/dd") : dgvRow.Cells[2].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@gender", dgvRow.Cells[3].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@address", dgvRow.Cells[4].Value == DBNull.Value ? "" : dgvRow.Cells[4].Value.ToString());

                sqlCmd.ExecuteNonQuery();
            }
        }

        public void Update(DataGridViewRow dgvRow)
        {
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();

                string sql = "UPDATE [dbo].[CUSTOMER_LAB9]\r\nSET CUSTOMERNAME = @name, DOB=@dob, GENDER=@gender,ADDRESS=@address\r\nWHERE CUSTOMERID = @id";

                SqlCommand sqlCmd = new SqlCommand(sql, connection);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

                //set param
                sqlCmd.Parameters.AddWithValue("@name", dgvRow.Cells[1].Value == DBNull.Value ? "" : dgvRow.Cells[1].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@dob", dgvRow.Cells[2].Value == DBNull.Value ? DateTime.Now.ToString("yyyy/MM/dd") : dgvRow.Cells[2].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@gender", dgvRow.Cells[3].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@address", dgvRow.Cells[4].Value == DBNull.Value ? "" : dgvRow.Cells[4].Value.ToString());
                sqlCmd.Parameters.AddWithValue("@id", dgvRow.Cells[0].Value.ToString());

                sqlCmd.ExecuteNonQuery();
            }
        }

        public void Delete(DataGridViewRow dgvRow)
        {
            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();

                string sql = "\r\nDELETE FROM dbo.CUSTOMER_LAB9 WHERE CUSTOMERID=@id";

                SqlCommand sqlCmd = new SqlCommand(sql, connection);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);

                //set param
             
                sqlCmd.Parameters.AddWithValue("@id", dgvRow.Cells[0].Value.ToString());

                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
