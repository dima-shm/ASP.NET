﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button"
                CssClass="button" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Text"
                CssClass="text"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" 
                CssClass="button" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Text"
                CssClass="text"></asp:Label>
        </div>
    </form>
</body>
</html>
