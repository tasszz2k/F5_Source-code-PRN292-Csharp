using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LAB_WEB_4
{


    public partial class Master : System.Web.UI.Page

    {
        private string connString = WebConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private DataSet dsCustomer;
        private DataSet dsOrder;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 dsCustomer = getAllCustomer();
                 dsOrder = FindOrderByCustomterID("C01");
                if (dsCustomer != null)
                {
                    ddListCustomer.DataSource = dsCustomer;
                    ddListCustomer.DataTextField = "CustomerName";
                    ddListCustomer.DataValueField = "CustomerID";
                    ddListCustomer.DataBind();


                }
                if (dsOrder != null)
                {
                    gvOrder.DataSource = dsOrder;

                    gvOrder.DataBind();


                }
            }
        }


        private DataSet getAllCustomer()
        {
            using (var cnn = new SqlConnection(connString))
            {

                //(1): SqlConnection
                //SqlConnection cnn  = new SqlConnection(connString);

                //(2): SqlCommand
                string sqlSelect = "SELECT * FROM dbo.CUSTOMERs";
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


        private DataSet FindOrderByCustomterID(string customerID)
        {
            using (var cnn = new SqlConnection(connString))
            {

                //(1): SqlConnection
                //SqlConnection cnn  = new SqlConnection(connString);

                //(2): SqlCommand
                string sqlSelect = "SELECT * FROM dbo.[Order] WHERE CustomerID = @customerID";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                //setvalue
                cmd.Parameters.AddWithValue("@customerID", customerID);

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

        protected void ddListCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList list = (DropDownList)sender;
            string customerID = (string)list.SelectedValue;

            dsOrder = FindOrderByCustomterID(customerID);

            gvOrder.DataSource = dsOrder;
            gvOrder.DataBind();

        }

        protected void ddListCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        protected void gvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvOrder.SelectedRow;
            string orderID = (string)row.Cells[1].Text;

            Response.Redirect("DetailsOrders.aspx?OrderID="+orderID);
        }
    }
}