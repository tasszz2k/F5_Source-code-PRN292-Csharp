using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_WebForm
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string id = tbxId.Text;
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string designation = tbxDesignation.Text;
            string city = tbxCity.Text;

            Response.Redirect(String.Format("PlayslipDetails.aspx?id={0}&firstName={1}&lastName={2}&designation={3}&city={4}", id,firstName,lastName,designation,city));
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            tbxId.Text = "";
            tbxFirstName.Text = "";
            tbxLastName.Text = "";
            tbxDesignation.Text = "";
            tbxCity.Text = "";
        }
    }
}