﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication3.SignUp" %>

<!DOCTYPE html>

 

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>PersonDetails</title>
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
                        User Registration  
</td>  
</tr>  
<tr>  
<td> First Name </td>  
<td>  
<asp:TextBox ID="txtFirstName" Width="150px" runat="server"></asp:TextBox>  
</td>  
</tr>  
<tr>  
<td> Last Name </td>  
<td>  
<asp:TextBox ID="txtLastName" Width="150px" runat="server"></asp:TextBox>  
</td>  
</tr>  
<tr>  
<td> EmailID </td>  
<td>  
<asp:TextBox ID="txtEmailid" Width="150px" runat="server"></asp:TextBox>  
</td>  
</tr>  
<tr>  
<td> UserID  </td>  
<td>  
<asp:TextBox ID="txtUserId" Width="150px" runat="server"></asp:TextBox>  
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
<asp:Button ID="BtnSave" runat="server" Width="100px" Text="Save" CommandName="Submit" OnClick="BtnSave_Click" />  
</td>  
</tr>  
</table>  
</form>
</body>
</html>