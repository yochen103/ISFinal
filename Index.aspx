﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnD" runat="server" Text="有防禦頁面" OnClick="btnD_Click"></asp:Button>
            <br />
            <asp:Button ID="btnNoD" runat="server" Text="無防禦頁面" OnClick="btnNoD_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
