<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="WebApplication3.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Forget Password</title>
</head>
<body>
<form id="form1" runat="server">
<div style="margin: 0px auto; padding-left: 370px; padding-right: 30px;overflow: auto;">  
<div>  
</div>  
</div>  
<table width="50%">  
<tr>  
<td colspan="2" style="background-color: red; height: 30px;color: White;" align="center">  
                        User Restset Password  
</td>  
</tr>  
<tr>  
<td> EmailID </td>  
<td>  
<asp:TextBox ID="txtEmailid" Width="150px" runat="server"></asp:TextBox>  
</td>  
</tr>  

    <tr>  
<td> New Password </td>  
<td>  
<asp:TextBox ID="txtNewPass" Width="150px" runat="server"></asp:TextBox>  
</td>  
</tr> 
     <tr>  
<td> Confirm Password </td>  
<td>  
<asp:TextBox ID="txtConfirmPassword" Width="150px" runat="server"></asp:TextBox>  
</td>  
</tr> 
<tr>  
<td align="center" colspan="2">  
<asp:Button ID="BtnSave" runat="server" Width="100px" Text="Save" CommandName="Submit" OnClick="BtnSave_Click" />  
</td>  
</tr>  
</table>  
</form>
</body>
</html>