<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetailView.aspx.cs" Inherits="DetailView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvwCategory" runat="server" AutoGenerateSelectButton="True" Caption="DANH MUC LOAI SAN PHAM"
            DataKeyNames="CategoryId" OnSelectedIndexChanging="gvwCategory_SelectedIndexChanging"
            Width="542px">
            
        </asp:GridView>
    
    </div>
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        &nbsp;<br />
        <br />
        <asp:DetailsView ID="dvwProduct" runat="server" AllowPaging="True" AutoGenerateDeleteButton="True"
            AutoGenerateEditButton="True" AutoGenerateInsertButton="True" AutoGenerateRows="False"
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" Caption="SAM PHAM"
            CellPadding="3" CellSpacing="1" DataKeyNames="ProductId" GridLines="None" Height="124px"
            OnDataBound="dvwProduct_DataBound" OnModeChanging="dvwProduct_ModeChanging" OnPageIndexChanging="dvwProduct_PageIndexChanging"
            Width="537px" OnItemCommand="dvwProduct_ItemCommand" OnItemUpdating="dvwProduct_ItemUpdating" OnItemCreated="dvwProduct_ItemCreated" OnItemInserting="dvwProduct_ItemInserting" OnItemUpdated="dvwProduct_ItemUpdated" OnModeChanged="dvwProduct_ModeChanged">
            <PagerSettings Mode="NextPreviousFirstLast" />
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <EditRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <Fields>
                <asp:BoundField DataField="ProductId" HeaderText="Product Id" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="Color" HeaderText="Color" />
                <asp:BoundField DataField="Suplier" HeaderText="Suplier" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:TemplateField HeaderText="Category">
                    <ItemTemplate>
                        <asp:DropDownList ID="dllCategory" runat="server" Width="167px">
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Picture">
                    <ItemTemplate>
                        &nbsp;&nbsp;
                        <asp:Label ID="lblPic" runat="server" Text='<%#Eval("Images")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        &nbsp;<asp:FileUpload ID="fupPic" runat="server" Width="219px" /><asp:Button ID="btnUpload"
                            runat="server" Text="Upload" OnClick="btnUpload_Click" />
                        <br />
                        <asp:Label ID="lblPicture" runat="server" Text='<%# Eval("Images") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
            </Fields>
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        </asp:DetailsView>
        <asp:Image ID="imgPic" runat="server" Height="223px" Style="z-index: 100; left: 578px;
            position: absolute; top: 275px" Width="207px" />
        <br />
        <asp:Label ID="lblStatus" runat="server"></asp:Label>&nbsp;<br />
        <br />
        <br />
    </form>
</body>
</html>