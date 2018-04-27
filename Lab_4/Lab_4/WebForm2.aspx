<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Lab_4.WebForm2" 
    Theme="Skin"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" 
                EnableTheming="false" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Text"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Text" 
                SkinID="GreenLabel"></asp:Label>
        </div>
    </form>
</body>
</html>
