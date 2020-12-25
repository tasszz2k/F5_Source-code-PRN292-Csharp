using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                        
                        //------------------- Detail View
                        dvPizza.DataSource = dsPizza;

                        dvPizza.DataBind();


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

        protected void dvPizza_ModeChanging(object sender, DetailsViewModeEventArgs e)
        {
            // Disable the paging feature in edit mode.
            if (e.NewMode == DetailsViewMode.Edit)
            {
                dvPizza.AllowPaging = false;
            }
            else
            {
                dvPizza.AllowPaging = true;
            }
        }

        protected void dvPizza_ModeChanging1(object sender, DetailsViewModeEventArgs e)
        {
            dvPizza.ChangeMode(e.NewMode);
            {
                dvPizza.BackColor = Color.Aquamarine;
            }
        }
    }
}