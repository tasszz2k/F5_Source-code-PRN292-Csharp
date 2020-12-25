<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LAB_WEB_5555555555.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table, th, td {
            border: 1px solid black;
        }
        th,
        td {
           
            width: 200px;
            height: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Rainbow Apparels Infortion System</h1>
            <br/>
            <table>
                <tr>
                    <td>
                        <asp:Menu ID="Menu1" runat="server">
                            <Items>
                                <asp:MenuItem Text="Suppliers" Value="Suppliers">
                                    <asp:MenuItem Text="View/Update" Value="ViewUpdate"></asp:MenuItem>
                                    <asp:MenuItem Text="Insert" Value="Insert"></asp:MenuItem>
                                </asp:MenuItem>
                            </Items>
                        </asp:Menu>
                    </td>

                    <td>
                        <asp:Menu ID="Menu2" runat="server">
                            <Items>
                                <asp:MenuItem Text="Products" Value="Products">
                                    <asp:MenuItem Text="View/Update" Value="ViewUpdate"></asp:MenuItem>
                                    <asp:MenuItem Text="Insert" Value="Insert"></asp:MenuItem>
                                </asp:MenuItem>
                            </Items>
                        </asp:Menu>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
