<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Demo_WebForm.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<style type="text/css">
		#form1 {
			height: 763px;
		}
		.auto-style1 {
			width: 110px;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<h1>Employee Details</h1>
		<table>
			<tr>
				<td class="auto-style1"><label>Employee ID:</label></td>
				<td>
					<asp:TextBox ID="tbxId" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">First Name:</td>
				<td>
					<asp:TextBox ID="tbxFirstName" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">Last Name:</td>
				<td>
					<asp:TextBox ID="tbxLastName" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style1" aria-busy="False">Designation:</td>
				<td>
					<asp:TextBox ID="tbxDesignation" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style1">City:</td>
				<td>
					<asp:TextBox ID="tbxCity" runat="server"></asp:TextBox>
				</td>
			</tr>
	

		</table>
		<asp:Button ID="btnSubmit" runat="server" OnClick="btnOK_Click" Text="Submit" />
		<asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
	</form>


</body>
</html>
