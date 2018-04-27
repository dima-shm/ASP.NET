<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_2a.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        function run() {

            var request = new XMLHttpRequest();
            var txt1 = document.getElementById("TextBox1");
            var txt2 = document.getElementById("TextBox2");
            var lbl1 = document.getElementById("Label1");

            request.open("POST", "http://172.16.193.174:40751/Lab_2/Lab_2a/sum.sum?X=" +
                txt1.value + "&Y=" + txt2.value, true);
            request.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded; charset=UTF-8');

            request.onreadystatechange = function () {
                if (request.readyState == 4) {
                    var status = request.status;                 
                    if (status == 200) {
                        lbl1.textContent = request.responseText;
                    } else if (status == 404) {
                        document.write("Ресурс не найден")
                    }
                    else {
                        lbl1.textContent = request.statusText;
                    }
                }
            };

            request.send(null);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Get" OnClick="ButtonGet_Click" />
            <asp:Button ID="Button2" runat="server" Text="Post" OnClick="ButtonPost_Click" />
            <asp:Button ID="Button3" runat="server" Text="Put" OnClick="ButtonPut_Click" />
            <asp:Button ID="Button4" runat="server" Text="GetDeny" OnClick="ButtonGetDeny_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <input type="button" id="Button5" onclick="run()" value="GetSumPost"/>
        </div>
    </form>
</body>
</html>
