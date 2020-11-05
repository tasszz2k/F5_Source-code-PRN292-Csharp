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
    public partial class DetailsPizza : System.Web.UI.Page
    {
        private string connString = WebConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private DataSet dsPizza;
        private string pizzaCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pizzaCode = Request["pizzaCode"];
                if (pizzaCode != null)
                {
                    dsPizza = FindPizzaByCode(pizzaCode);
                    if (dsPizza != null)
                    {
                        lblCode.Text = dsPizza.Tables[0].Rows[0][0].ToString();
                        lblName.Text = dsPizza.Tables[0].Rows[0][1].ToString();
                        lblPrice.Text = dsPizza.Tables[0].Rows[0][2].ToString();
                        lblPic.Text = dsPizza.Tables[0].Rows[0][3].ToString();

                    }
                }
            }
        }
        private DataSet FindPizzaByCode(string code)
        {
            using (var cnn = new SqlConnection(connString))
            {

                //(1): SqlConnection
                //SqlConnection cnn  = new SqlConnection(connString);

                //(2): SqlCommand
                string sqlSelect = "SELECT * FROM dbo.Pizzas WHERE  PizzaCode=@code";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                //setvalue
                cmd.Parameters.AddWithValue("@code", code);

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