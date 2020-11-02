using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_WebForm2
{
    public partial class PrintOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbxCustomer.Text = Request.QueryString["customer"];
            tbxAddress.Text = Request.QueryString["address"];
            tbxTaxCode.Text = Request.QueryString["taxCode"];


            Dictionary<string, int> list = Home.List;

            foreach (KeyValuePair<string, int> entry in list)
            {
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                cell1.Text = entry.Key;
                cell2.Text = entry.Value.ToString();
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                orderList.Rows.Add(row);
            }

        }
    }
}