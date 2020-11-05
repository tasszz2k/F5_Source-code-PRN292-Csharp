using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class FormViewExample : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataSet ds;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (conn == null)
        {
            conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connect"].ToString());
            conn.Open();
        }
        string strSQL = "Select * From tblCategory";
        da = new SqlDataAdapter(strSQL, conn);
        ds = new DataSet();
        da.Fill(ds, "tblCategory");
        if (!IsPostBack)
        {
            binData();
             
        }
    }
    private void binData()
    {

        string strSQL = "Select * From tblCategory";
        da = new SqlDataAdapter(strSQL, conn);
        ds = new DataSet();
        da.Fill(ds, "tblCategory");
        FormView1.DataSource = ds.Tables[0].DefaultView;
        FormView1.DataBind();
    }
    protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
    {
        FormView1.PageIndex = e.NewPageIndex;
       
        binData();
    }
    protected void FormView1_ModeChanging(object sender, FormViewModeEventArgs e)
    {
        
       
        FormView1.ChangeMode(e.NewMode);
        binData();
    }
    protected void FormView1_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        string button = e.CommandName.ToUpper();
        switch (button)
        {
            case "CANCEL":
                FormView1.ChangeMode(FormViewMode.ReadOnly);
                binData();
                break;
        }
    }
    protected void FormView1_ItemUpdating(object sender, FormViewUpdateEventArgs e)
    {
       // string id;
        string name;
        
        string key = FormView1.DataKey.Value.ToString();
        
        if (FormView1.CurrentMode == FormViewMode.Edit)
        {
            TextBox txtId = (TextBox)FormView1.FindControl("txtId");
            TextBox txtName = (TextBox)FormView1.FindControl("txtName");
            txtId.Enabled = false;
            name = txtName.Text;
            string strSql = "Update tblCategory SET CategoryName='" + name + "' Where CategoryId=" + key;
            SqlCommand cmd = new SqlCommand(strSql, conn);
            cmd.ExecuteNonQuery();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            builder.GetUpdateCommand();
            da.Update(ds.Tables[0]);
            FormView1.ChangeMode(FormViewMode.ReadOnly);
            binData();



        }
    }
    protected void FormView1_DataBound(object sender, EventArgs e)
    {
        
    }
}
