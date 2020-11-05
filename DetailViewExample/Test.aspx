<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2"
            DataTextField="CategoryName" DataValueField="CategoryID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
            Width="197px">
        </asp:DropDownList><br />
        <br />
        <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                <asp:RadioButton ID="RadioButton1" runat="server" Text='<%#Eval("ProductName")%>' /><br />
            </ItemTemplate>
        </asp:DataList>&nbsp;</div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>"
            SelectCommand="SELECT * FROM [tblProducts] WHERE ([CategoryID] = @CategoryID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="CategoryID" PropertyName="SelectedValue"
                    Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>"
            SelectCommand="SELECT * FROM [tblCategory]"></asp:SqlDataSource>
    </form>
</body>
</html>
