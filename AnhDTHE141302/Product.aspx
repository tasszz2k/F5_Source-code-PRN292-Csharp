<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="AnhDTHE141302.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table {
            border: 1px solid black;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sách văn học dân gian</h1>
            <p>
                <table>
                    <tr>
                        <td> <asp:DataList ID="DataList1" runat="server" Height="145px" Width="194px" OnItemCommand="DataList1_ItemCommand">
                            <ItemTemplate>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Image ID="imgProduct" runat="server" ImageUrl='<%# Eval("pImage")%>' Height="50px" Width="50px"/></td>
                                        <td>
                                            <table>
                                                <tr><td>
                                                    <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("pTitle") %>' Height="16px" Width="92px"></asp:Label>
                                                </td></tr>
                                                <tr><td>
                                                    <asp:Label ID="lblPrice" runat="server" Text='<%# Eval("pPrice") %>'></asp:Label>
                                                </td></tr>
                                                <tr>
                                                    <td>
                                                        <asp:Button ID="btnBuy" runat="server" Text="Chọn mua" OnClick="btnBuy_OnClick" CommandName="Add"/>

                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>


                            </ItemTemplate>
                        </asp:DataList></td>
                        <td>
                            <asp:Label ID="lblTotal" runat="server" Text="500"></asp:Label>
                            <br />
                            <asp:Button ID="btnCheckout" runat="server" Text="Giỏ hàng của bạn" />
                          
                        </td>
                    </tr>
                </table>
               
               
            </p>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
