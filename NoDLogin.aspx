<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NoDLogin.aspx.cs" Inherits="NoDLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            無防禦<br />
            Account：&nbsp; 
            <asp:TextBox ID="txtAccount" runat="server"></asp:TextBox>
            <br />
            Password：<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
