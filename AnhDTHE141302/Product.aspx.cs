using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnhDTHE141302
{

    public partial class Product : System.Web.UI.Page
    {
        //Web
        private string connString = WebConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private DataSet dsProduct;
        Dictionary<string, int> cart = new Dictionary<string, int>();
        private int total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dsProduct = GetALlProduct();
                DataList1.DataSource = dsProduct;
                DataList1.DataKeyField = "pId";
                DataList1.DataBind();
            }
        }
        private DataSet GetALlProduct()
        {
            using (var cnn = new SqlConnection(connString))
            {

                //(1): SqlConnection
                //SqlConnection cnn  = new SqlConnection(connString);

                //(2): SqlCommand
                string sqlSelect = "SELECT * FROM dbo.tblBooks";
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

        protected void btnBuy_OnClick(object sender, EventArgs e)
        {
            //int id = 
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            
            int id = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex].ToString());
            Response.Write(id +"");
            AddToCart(id);
            total += id;
            lblTotal.Text = total+"";
        }

        public void AddToCart(int id)
        {
            foreach (var item in cart)
            {
                if (item.Key.Equals(id+""))
                {
                    cart[id + ""] += 1;
                }
                else
                {
                    cart.Add(id+"", 1);
                }
            }
        }
    }
}