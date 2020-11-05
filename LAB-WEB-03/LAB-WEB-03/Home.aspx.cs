using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_WEB_03
{
    public partial class Home : System.Web.UI.Page
    {
        private string connString = WebConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = getAllDataTblStudent();
                if (ds != null)
                {
                    gvStudent.DataSource = ds;
                    gvStudent.DataBind();
                }
            }
        }


        private DataSet getAllDataTblStudent()
        {
            using (var cnn = new SqlConnection(connString))
            {

                //(1): SqlConnection
                //SqlConnection cnn  = new SqlConnection(connString);

                //(2): SqlCommand
                string sqlSelect = "SELECT * FROM dbo.tblStudent";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlSelect;

                //(3): SqlDataAdapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //(4): Init DataSet
                DataSet ds = new DataSet();
                try
                {
                    //Open connection
                    cnn.Open();
                    //fill data to ds
                    da.Fill(ds);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    //close connection
                    cnn.Close();
                }

                return ds;
            }
        }


    }
}