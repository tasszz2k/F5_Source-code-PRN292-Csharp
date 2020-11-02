using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_WebForm
{
    public partial class PlayslipDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int salary = 65000;
            int HRA = (int) (salary * 0.4);
            int TA = (int) (salary * 0.1);
            int basic = salary - (HRA + TA);

            tbxId.Text = Request.QueryString["id"];
            tbxFirstName.Text = Request.QueryString["firstName"];
            tbxLastName.Text = Request.QueryString["lastName"];
            tbxCity.Text = Request.QueryString["city"];
            tbxDesignation.Text = Request.QueryString["designation"];
            tbxBasic.Text = basic.ToString();
            tbxHRA.Text = HRA.ToString();
            tbxTA.Text = TA.ToString();
            tbxGross.Text = salary.ToString();
      
            
        }
    }
}