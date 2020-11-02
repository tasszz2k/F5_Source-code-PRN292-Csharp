<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrintOrder.aspx.cs" Inherits="Demo_WebForm2.PrintOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table, th, td {
            border: 1px solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Order</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Customer:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbxCustomer" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Address:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbxAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Tax Code:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbxTaxCode" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
            </table>
           <h1>Order bread list:</h1>
           <br/>
            <asp:Table ID="orderList" runat="server" Width="30%"> 
                <asp:TableRow>
                    <asp:TableCell>Name</asp:TableCell>
                    <asp:TableCell>Quantity</asp:TableCell>
                </asp:TableRow>
            </asp:Table>  
        </div>
    </form>
</body>
</html>
