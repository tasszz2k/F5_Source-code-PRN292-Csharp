<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormViewExample.aspx.cs" Inherits="FormViewExample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" Caption="CATEGORY" CellPadding="4" GridLines="Both" Width="410px" OnModeChanging="FormView1_ModeChanging" OnPageIndexChanging="FormView1_PageIndexChanging" OnItemCommand="FormView1_ItemCommand" DataKeyNames="CategoryId" OnItemUpdating="FormView1_ItemUpdating" OnDataBound="FormView1_DataBound">
            <ItemTemplate>
                Category Id:
                <asp:Label ID="lblId" runat="server" Text='<%#Eval("CategoryId")%>'></asp:Label><br />
                Category Name:
                <asp:Label ID="lblName" runat="server" Text='<%#Eval("CategoryName")%>'></asp:Label>
                <br />
                Image Picture:
                <asp:Label ID="lblImage" runat="server" Text='<%#Eval("Images")%>'></asp:Label><br />
                <br />
                <asp:LinkButton ID="btnEdit" runat="server" CommandName="edit" Width="42px">Edit</asp:LinkButton>
                <asp:LinkButton ID="btnNew" runat="server" CommandName="new" Width="44px">New</asp:LinkButton>
            </ItemTemplate>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <EditRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerSettings Mode="NextPreviousFirstLast" />
            <EditItemTemplate>
                Category Id: &nbsp; &nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtId" runat="server" Width="86px" Text='<%#Eval("CategoryId")%>'></asp:TextBox><br />
                Category Name:
                <asp:TextBox ID="txtName" runat="server" Text='<%#Eval("CategoryName")%>'></asp:TextBox>
                <br />
                Image Picture: &nbsp;
                <asp:FileUpload ID="fupPic" runat="server" /><br />
                <br />
                <asp:LinkButton ID="btnUpdate" runat="server" CommandName="update">Update</asp:LinkButton>
                <asp:LinkButton ID="btnCancel" runat="server" CommandName="cancel">Cancel</asp:LinkButton>
            </EditItemTemplate>
            <InsertItemTemplate>
                Category ID: &nbsp; &nbsp; &nbsp;<asp:TextBox ID="txtCategoryId" runat="server" Width="88px"></asp:TextBox><br />
                Category Name:
                <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
                <br />
                Image Picture: &nbsp;&nbsp;
                <asp:FileUpload ID="fupPic" runat="server" /><br />
                <br />
                <asp:LinkButton ID="btnInsert" runat="server" CommandName="insert" Width="47px">Insert</asp:LinkButton>&nbsp;
                <asp:LinkButton ID="btnCancel" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
            </InsertItemTemplate>
        </asp:FormView>
        &nbsp;</div>
    </form>
</body>
</html>
