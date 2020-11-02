<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayslipDetails.aspx.cs" Inherits="Demo_WebForm.PlayslipDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
	        <h1>Payslip Details</h1>
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
		        
			        <td class="auto-style1">Last Name:</td>
			        <td>
				        <asp:TextBox ID="tbxLastName" runat="server"></asp:TextBox>
			        </td>
			        <td class="auto-style1">City:</td>
			        <td>
				        <asp:TextBox ID="tbxCity" runat="server"></asp:TextBox>
			        </td>
		        </tr>
		        <tr>
			        <td class="auto-style1" aria-busy="False">Designation:</td>
			        <td>
				        <asp:TextBox ID="tbxDesignation" runat="server"></asp:TextBox>
			        </td>
		        </tr>
		        <tr>
			        <td class="auto-style1" aria-busy="False">Salary Details:</td>
		        </tr>
		        <tr>
			        <td class="auto-style1" aria-busy="False">Basic:</td>
					<td>
						<asp:TextBox ID="tbxBasic" runat="server"></asp:TextBox>
					</td>
		        </tr>
		        <tr>
			        <td class="auto-style1" aria-busy="False">HRA:</td>
			        <td>
				        <asp:TextBox ID="tbxHRA" runat="server"></asp:TextBox>
			        </td>
		        </tr>
		        <tr>
			        <td class="auto-style1" aria-busy="False">TA:</td>
			        <td>
				        <asp:TextBox ID="tbxTA" runat="server"></asp:TextBox>
			        </td>
		        </tr>
		        <tr>
			        <td class="auto-style1" aria-busy="False">GrossSalary:</td>
			        <td>
				        <asp:TextBox ID="tbxGross" runat="server"></asp:TextBox>
			        </td>
		        </tr>
	


		</table>
        </div>
    </form>
</body>
</html>
