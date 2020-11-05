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
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class DetailView : System.Web.UI.Page
{
    SqlConnection conn;
    SqlDataAdapter da;
    DataSet ds;
    public static string CatId = "";
    public static string CatName = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (conn == null)
        {
            conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connect"].ToString());
            conn.Open();
        }
        string strSQL;
        strSQL= "select * From tblCategory";
        da = new SqlDataAdapter(strSQL, conn);
        ds = new DataSet();
        da.Fill(ds,"tblCategory");
        strSQL = "Select * From tblProducts";
        da = new SqlDataAdapter(strSQL, conn);
        da.Fill(ds,"tblProducts");
        if (!IsPostBack)
        {
            binCategory();
            InitDetailView(CatId);
        }
    }
    private void binCategory()
    {
        gvwCategory.DataSource = ds.Tables[0].DefaultView;
        gvwCategory.DataBind();
    }
    private void InitDetailView(string key)
    {
        string strSelect;
        if (key != "")
        {
            strSelect = "Select * From tblProducts Where CategoryId=" + key;
        }
        else
        {
            strSelect = "Select * From tblProducts";
        }
        SqlDataAdapter daProduct = new SqlDataAdapter(strSelect, conn);
        DataSet dsProduct = new DataSet();
        daProduct.Fill(dsProduct,"tblProducts");

        dvwProduct.DataSource = dsProduct.Tables[0].DefaultView;
        dvwProduct.DataBind();
        lblMessage.Text = "There are " + dsProduct.Tables[0].Rows.Count.ToString() + " records ";

    }
    protected void dvwProduct_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
        dvwProduct.PageIndex = e.NewPageIndex;
        InitDetailView(CatId);
        if (dvwProduct.CurrentMode == DetailsViewMode.Edit)
        {
            TextBox txtProductId = (TextBox)dvwProduct.Rows[0].Cells[1].Controls[0];
            txtProductId.Enabled = false;
        }

        if(CatName!="")
            lblMsg.Text = "of " + CatName;
    }


    protected void dvwProduct_DataBound(object sender, EventArgs e)
    {

        string strSQL;
        string CategoryId="";
        strSQL= "Select * From tblCategory";        
        ListItem item;
        DropDownList dllCategory;
    
        dllCategory = (DropDownList)dvwProduct.Rows[5].Cells[1].Controls[1];
        
        
        if (dvwProduct.CurrentMode == DetailsViewMode.ReadOnly)
        {
            Label lblpic = (Label)dvwProduct.Rows[6].FindControl("lblPic");
            string img = "Images/" + lblpic.Text;
            imgPic.ImageUrl = img;
        }
        
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            item = new ListItem(reader.GetString(1), reader.GetInt32(0).ToString());
            dllCategory.Items.Add(item);
        }
        reader.Close();
        string proId="";
       // Response.Write(dvwProduct.DataKey.Value.ToString());
        if(dvwProduct.CurrentMode== DetailsViewMode.ReadOnly) 
        {
            proId = dvwProduct.Rows[0].Cells[1].Text;
        }
        else if (dvwProduct.CurrentMode == DetailsViewMode.Edit)
        {
            proId = ((TextBox)dvwProduct.Rows[0].Cells[1].Controls[0]).Text;
        }
        if (proId != "")
        {
            strSQL = "Select * From tblProducts Where ProductId=" + proId;
            cmd = new SqlCommand(strSQL, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId")).ToString();
            }
            reader.Close();
        }
      
            for (int i = 0; i < dllCategory.Items.Count; i++)
            {
                if (dllCategory.Items[i].Value == CategoryId)
                {
                    dllCategory.Items[i].Selected = true;
                }
            }
        
      
            
    }
    protected void gvwCategory_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        int index = e.NewSelectedIndex;
        CatName = gvwCategory.Rows[index].Cells[2].Text;
        CatId = gvwCategory.DataKeys[index].Value.ToString();
        string strSQL = "Select Count(ProductId) As count From tblProducts Where CategoryId=" + CatId;
        SqlCommand cmd = new SqlCommand(strSQL, conn);
        int count =Convert.ToInt32( cmd.ExecuteScalar());
        if (count > 0)
        {
            InitDetailView(CatId);
            if (CatName != "")
                lblMsg.Text = "of " + CatName;
        }
        else
        {
            lblMessage.Text = "Ther is no record ";
            
        }
        

    }
    protected void dvwProduct_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        dvwProduct.ChangeMode(e.NewMode);
       // if (dvwProduct.CurrentMode == DetailsViewMode.Edit)
        {
            InitDetailView(CatId);
            //TextBox txtProductId = (TextBox)dvwProduct.Rows[0].Cells[1].Controls[0];
            //txtProductId.Enabled = false;
            dvwProduct.Rows[0].Cells[1].Enabled = false;
        }
       
       
        

         
    }
    protected void dvwProduct_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        string button = e.CommandName.ToUpper();
        switch (button)
        {
            case "CANCEL":
                dvwProduct.ChangeMode(DetailsViewMode.ReadOnly);
                InitDetailView(CatId);
                break;
        }
    }
    protected void dvwProduct_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        if (dvwProduct.CurrentMode == DetailsViewMode.Edit)
        {
            string proId = ((TextBox)dvwProduct.Rows[0].Cells[1].Controls[0]).Text;
            string productName = ((TextBox)dvwProduct.Rows[1].Cells[1].Controls[0]).Text;
            string color = ((TextBox)dvwProduct.Rows[2].Cells[1].Controls[0]).Text;
            string suplier = ((TextBox)dvwProduct.Rows[3].Cells[1].Controls[0]).Text;
            float price = float.Parse(((TextBox)dvwProduct.Rows[4].Cells[1].Controls[0]).Text);
            int CategoryId =Convert.ToInt32( ((DropDownList)dvwProduct.Rows[5].Cells[1].Controls[1]).SelectedValue);
            Label lblPic =(Label) dvwProduct.Rows[6].FindControl("lblPicture");
            string img = lblPic.Text;
            string strUpdate = @"Update tblProducts SET ProductName='" + productName + "', Color='" + color + "',suplier='" + suplier + "',price=" + price + ",Images='" + img + "', CategoryId=" + CategoryId + " Where ProductId=" + proId;
           
            SqlCommand cmd=new SqlCommand(strUpdate,conn);
            cmd.ExecuteNonQuery();
            SqlCommandBuilder builder= new SqlCommandBuilder(da);
            builder.GetUpdateCommand();
            da.Update(ds.Tables[1]);
            dvwProduct.ChangeMode(DetailsViewMode.ReadOnly);
            InitDetailView(CatId);              
        }
    }
    protected void dvwProduct_ModeChanged(object sender, EventArgs e)
    {
        
    }
    protected void dvwProduct_ItemCreated(object sender, EventArgs e)
    {
        if (dvwProduct.CurrentMode == DetailsViewMode.Insert)
        {
            dvwProduct.Rows[0].Cells[1].Enabled = false;
        }
    }
    protected void dvwProduct_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        if (dvwProduct.CurrentMode == DetailsViewMode.Insert)
        {
            float price = 0;
            string proId = ((TextBox)dvwProduct.Rows[0].Cells[1].Controls[0]).Text;
            string productName = ((TextBox)dvwProduct.Rows[1].Cells[1].Controls[0]).Text;
            string color = ((TextBox)dvwProduct.Rows[2].Cells[1].Controls[0]).Text;
            string suplier = ((TextBox)dvwProduct.Rows[3].Cells[1].Controls[0]).Text;
            TextBox txtPrice =(TextBox)dvwProduct.Rows[4].Cells[1].Controls[0];
            if(txtPrice.Text!="")
                 price = float.Parse(txtPrice.Text);
            int CategoryId = Convert.ToInt32(((DropDownList)dvwProduct.Rows[5].Cells[1].Controls[1]).SelectedValue);
            string strInsert = "Insert Into tblProducts(ProductName, Color, Suplier, Price,CategoryId) Values('" + productName + "','" + color + "','" + suplier + "'," + price + "," + CategoryId + ")";
            SqlCommand cmd = new SqlCommand(strInsert, conn);
            cmd.ExecuteNonQuery();
            da.Update(ds.Tables[1]);
            dvwProduct.ChangeMode(DetailsViewMode.ReadOnly);
            InitDetailView(CatId);
           
        }

    }
    protected void dvwProduct_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        lblStatus.Text = "Warning....";
        if (e.Exception == null)
        {
            if (e.AffectedRows == 1)
            {
                lblStatus.Text = "New record was inserted successful.";
            }
            else
            {
                lblStatus.Text = "An error was occurred during the inserted";
                e.KeepInEditMode=true;
            }
        }
        else
        {
            lblStatus.Text = e.Exception.Message.ToString();
            e.ExceptionHandled = true;
        }
    }



    protected void btnUpload_Click(object sender, EventArgs e)
    {
        Label lblPic = (Label)dvwProduct.Rows[6].FindControl("lblPicture");
        FileUpload f = (FileUpload)dvwProduct.Rows[6].FindControl("fupPic");
        string path = Server.MapPath("Images");
        string file = path + "\\" + f.FileName;
        if (f.HasFile)
        {
            f.SaveAs(file);
            lblPic.Text = f.FileName;
        }
    }
}
