<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Demo_WebForm2.Home" %>

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
				<tr>
					<td>
						<h3>Pick type Bread</h3>
						<asp:DropDownList ID="ddlBread" runat="server" Width="165px">
								<asp:ListItem Value="1">Bread</asp:ListItem>
								<asp:ListItem Value="2">Chung Cake</asp:ListItem>
								<asp:ListItem Value="3">Dumplings</asp:ListItem>
							</asp:DropDownList>
						<br/>
						<asp:Label ID="Label4" runat="server" Text="Quantity:"></asp:Label>
							<asp:TextBox ID="tbxQuantity" runat="server" Width="86px">1</asp:TextBox>
						<br/>
						<asp:Button ID="btnSelect" runat="server" Text="&gt;&gt;" OnClick="btnSelect_Click" />
					</td>
					<td>
						<h3>Selected Bread List </h3>
						<asp:ListBox ID="ListBoxSelected" runat="server" Height="95px" OnSelectedIndexChanged="ListBoxSelected_SelectedIndexChanged" Width="196px"></asp:ListBox>
						<br/>
						
						<asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
					</td>
				</tr>
				</table>
	        <asp:Button ID="btnPrint" runat="server" Text="Print Order" OnClick="btnPrint_Click" />
        </div>
    	
    </form>
</body>
</html>
