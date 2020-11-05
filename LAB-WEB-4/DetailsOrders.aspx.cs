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
    public partial class DetailsOrders : System.Web.UI.Page
    {
        private string connString = WebConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private DataSet dsOrderDetails;
        private string orderID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                orderID = Request["orderID"];
                if (orderID != null)
                {
                    dsOrderDetails = FindOrderDetailsByOrderID(orderID);
                    if (dsOrderDetails != null)
                    {
                        gvOrderDetails.DataSource = dsOrderDetails;

                        gvOrderDetails.DataBind();


                    }
                }
            }
        }

        private DataSet FindOrderDetailsByOrderID(string orderID)
        {
            using (var cnn = new SqlConnection(connString))
            {

                //(1): SqlConnection
                //SqlConnection cnn  = new SqlConnection(connString);

                //(2): SqlCommand
                string sqlSelect = "SELECT * FROM dbo.OrderDetails WHERE OrderID = @orderID";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                //setvalue
                cmd.Parameters.AddWithValue("@orderID", orderID);

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

        protected void gvOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvOrderDetails.SelectedRow;
            string pizzaCode = (string)row.Cells[2].Text;

            Response.Redirect("DetailsPizza.aspx?pizzaCode=" + pizzaCode);
        }
    }
}