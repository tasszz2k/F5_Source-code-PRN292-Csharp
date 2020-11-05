<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsPizza.aspx.cs" Inherits="LAB_WEB_4.DetailsPizza" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Detail of the Pizza</h1>
            <table>
                <tr>
                    <td class="auto-style1">Pizza Code</td>
                    <td class="auto-style1">
                        <asp:Label ID="lblCode" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Pizza Name</td>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Price</td>
                    <td>
                        <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>PicURL</td>
                    <td>
                        <asp:Label ID="lblPic" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
