<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Lab_5.WebForm2" %>
<%@ OutputCache Duration="15" VaryByParam="Param1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> <br />
            <a href="?Param1=1&Param2=1">Param1=1&Param2=1</a> <br />
            <a href="?Param1=1&Param2=2">Param1=1&Param2=2</a> <br />
            <a href="?Param1=3">Param1=3</a> <br />
        </div>
    </form>
</body>
</html>
