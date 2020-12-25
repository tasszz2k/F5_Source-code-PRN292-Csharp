using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page 
{
    SqlConnection conn;
    DataSet ds;
    SqlDataAdapter da;
    SqlCommand cmd;
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
        da.Fill(ds,"tblCategory");
        
        if (!IsPostBack)
        {
            binData();
        }

    }
    private void binData()
    {

        string strSelect = "Select * From tblCategory";
        SqlDataAdapter daCategory = new SqlDataAdapter(strSelect,conn);
        DataSet dsCategory = new DataSet();
        daCategory.Fill(dsCategory,"tblCategory");
        lstCategory.DataSource = dsCategory.Tables[0].DefaultView;
        lstCategory.DataBind();
    }
    protected void lstCategory_EditCommand(object source, DataListCommandEventArgs e)
    {
        lstCategory.EditItemIndex = e.Item.ItemIndex;
        binData();
    }
   
    protected void lstCategory_ItemCommand(object source, DataListCommandEventArgs e)
    {
        string button = e.CommandName.ToUpper();
        switch (button)
        {
            case "CANCEL" :
                lstCategory.EditItemIndex = -1;
                binData();
                break;
        }
    }
    protected void lstCategory_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        int index = e.Item.ItemIndex;
        string CategoryId = lstCategory.DataKeys[index].ToString();
        TextBox txtId =(TextBox) e.Item.FindControl("txtId");
        TextBox txtName = (TextBox)e.Item.FindControl("txtName");
        Int32 id = Convert.ToInt32(txtId.Text);
        string name = txtName.Text;
        
        string strSQL = "Update tblCategory Set CategoryId=" + id + ", CategoryName='" + name + "' Where CategoryId=" + CategoryId;
        cmd = new SqlCommand(strSQL, conn);
        cmd.ExecuteNonQuery();        
        da.Update(ds.Tables[0]);
       
        lstCategory.EditItemIndex = -1; 
        binData();
    }
    protected void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        binData();
    }
    protected void lstCategory_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        Int32 index = e.Item.ItemIndex;
        string CatId = lstCategory.DataKeys[index].ToString();
        string strSQL = "Delete From tblCategory Where CategoryId=" + CatId;
        cmd = new SqlCommand(strSQL, conn);
        cmd.ExecuteNonQuery();
        da.Update(ds.Tables[0]);
        lstCategory.EditItemIndex = -1;
        binData();
    }
    protected void lstCategory_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        try
        {
            string strQuestion = "javascript:return confirm('Are you sure delete this record?')";
            LinkButton lbnDelete = (LinkButton)e.Item.FindControl("btnDelete");
            lbnDelete.Attributes["onclick"] = strQuestion;
        }
        catch
        {
        }
    }
}
