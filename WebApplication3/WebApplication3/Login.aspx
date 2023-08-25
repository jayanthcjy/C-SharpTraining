<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>User Login</title>
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
                        User Login  
</td>  
</tr>  
  
<tr>  
<td> EmailID </td>  
<td>  
<asp:TextBox ID="txtEmailid" Width="150px" runat="server"></asp:TextBox>  
</td>  
</tr>  

    <tr>  
<td> Password </td>  
<td>  
<asp:TextBox ID="txtPass" Width="150px" runat="server"></asp:TextBox>  
</td>  
</tr>  
<tr>  
<td align="center" colspan="2">  
<asp:Button ID="BtnLogin" runat="server" Width="100px" Text="Login" CommandName="Submit" OnClick="BtnLogin_Click" />  
</td>  
</tr> 
    <tr>  
<td align="center" colspan="2">  
<asp:Button ID="BtSignUp" runat="server" Width="100px" Text="SignUp" CommandName="Submit" OnClick="BtnSignUp_Click" />  
</td>  
</tr> 
    <tr>  
<td align="center" colspan="2">  
<asp:Button ID="BtForgetPassword" runat="server" Width="100px" Text="Forget Password" CommandName="Submit" OnClick="BtnForgetPassword_Click" />  
</td>  
</tr> 
</table>  
</form>
</body>

</html>
