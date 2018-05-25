<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab_6a.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="X:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Y:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="-" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="*" OnClick="Button3_Click" />
            <asp:Label ID="Label3" runat="server" Text="Результат:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <hr />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Session"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="A:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="SetA" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="GetA" OnClick="Button5_Click" />
            <br />
            <br />
            <hr />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Application"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Count:"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:Button ID="Button6" runat="server" Text="IncrementCount" OnClick="Button6_Click" />
            <asp:Button ID="Button7" runat="server" Text="GetCounValue" OnClick="Button7_Click" />
        </div>
    </form>
</body>
</html>
