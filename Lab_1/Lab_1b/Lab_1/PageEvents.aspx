<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageEvents.aspx.cs" Inherits="Lab_1.PageEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lable1" runat="server" EnableViewState="false"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true"/>
        </div>
    </form>
</body>
</html>
