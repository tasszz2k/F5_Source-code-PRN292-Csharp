<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        THONG TIN LOAI SAN PHAM<br />
        <br />
        <asp:DataList ID="lstCategory" runat="server" Width="311px" GridLines="Both" OnEditCommand="lstCategory_EditCommand" DataKeyField="CategoryId" OnItemCommand="lstCategory_ItemCommand" OnUpdateCommand="lstCategory_UpdateCommand" OnSelectedIndexChanged="lstCategory_SelectedIndexChanged" OnDeleteCommand="lstCategory_DeleteCommand" OnItemDataBound="lstCategory_ItemDataBound" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <ItemStyle BackColor="White" ForeColor="#003399" />
            <ItemTemplate>
                <asp:LinkButton ID="btnShow" runat="server" CommandName="select">Show Details</asp:LinkButton>
                <asp:Label ID="lblId" runat="server" Text='<%#Eval("CategoryID")%>'></asp:Label>&nbsp;
                <asp:LinkButton ID="btnEdit" runat="server" CommandName="Edit">Edit</asp:LinkButton>
                <asp:LinkButton ID="btnDelete" runat="server" CommandName="delete">Delete</asp:LinkButton>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# "Image/" + Eval("Images") %>' />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectedItemTemplate>
                Category Id:  
                <asp:Label ID="lblCategoryId" runat="server" Text='<%#Eval("CategoryID")%>'></asp:Label><br />
                Category Name:&nbsp;
                <asp:Label ID="lblCatName" runat="server" Text='<%#Eval("CategoryName")%>'></asp:Label>
            </SelectedItemTemplate>
            <EditItemTemplate>
                Category Id: &nbsp; &nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtId" runat="server" Text='<%#Eval("CategoryId") %>'></asp:TextBox><br />
                Category Name:
                <asp:TextBox ID="txtName" runat="server" Text='<%#Eval("CategoryName") %>'></asp:TextBox>
                <br />
                <asp:LinkButton ID="btnUpdate" runat="server" CommandName="Update">Update</asp:LinkButton>
                <asp:LinkButton ID="btnCancel" runat="server" CommandName="Cancel">Cancel</asp:LinkButton>
            </EditItemTemplate>
        </asp:DataList></div>
    </form>
</body>
</html>
