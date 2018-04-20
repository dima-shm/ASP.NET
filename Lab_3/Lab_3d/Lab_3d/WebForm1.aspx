<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab_3d.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager" runat="server" />

            <h3>1. UpdatePanel</h3>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Button 1" OnClick="Button1_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <br />

            <h3>2. UpdatePanel (TextBox, CheckBox, RadioButton)</h3>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="TextBox1" AutoPostBack="true" runat="server" />
                    <br />
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    <br />
                    <asp:RadioButton ID="RadioButton1" AutoPostBack="true" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <hr />
            <br />

            <h3>3. UpdatePanel (обработка ошибки)</h3>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
                    <asp:Button ID="Button2" runat="server" Text="Generate error" OnClick="Button2_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <script>
                function pageLoad() {
                    var pageManager = Sys.WebForms.PageRequestManager.getInstance();
                    pageManager.add_endRequest(endRequest);
                }

                function endRequest(sender, args) {
                    // Обработка ошибки
                    if (args.get_error() != null) {
                        alert(args.get_error().message);
                        // Подавить вывод ошибки в консоль
                        args.set_errorHandled(true);
                    }
                }
            </script>
            <hr />
            <br />

            <h3>4. UpdatePanel (триггер)</h3>
            <asp:Button ID="Button3" runat="server" Text="AsyncPostBack" OnClick="AsyncPostBackButton_Click" />
            <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label ID="Label2" runat="server" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button3" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
            <hr />
            <br />

            <h3>5. Timer</h3>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick" />
            <asp:Timer ID="Timer2" runat="server" Interval="3000" OnTick="Timer2_Tick" />
            <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    Counter 1:
                    <asp:Label ID="Counter1Label" runat="server" Text="0" />
                    <br />
                    Counter 2:
                    <asp:Label ID="Counter2Label" runat="server" Text="0" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                    <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>

            <hr />
            <br />

            <h3>7. UpdatePanel (UpdateProgress)</h3>
            <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label ID="TimeLabel" runat="server" Text="Click to refresh" />
                    <br />
                    <asp:Button ID="RefreshTime" runat="server" Text="Refresh time" OnClick="RefreshTime_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel6">
                <ProgressTemplate>
                    <br />
                    <br />
                    <img src="loading.gif" width="50px" height="50px" alt="Loading" />
                    <input type="button" id="CancelLoading" value="Cancel" onclick="AbortPostBack()" /> 
                </ProgressTemplate>
            </asp:UpdateProgress>
            <script>
                var prm = Sys.WebForms.PageRequestManager.getInstance();
                prm.add_initializeRequest(InitializeRequest);

                function InitializeRequest(sender, args) {
                    if (prm.get_isInAsyncPostBack()) {
                        args.set_cancel(true);
                    }
                }

                function AbortPostBack() {
                    if (prm.get_isInAsyncPostBack()) {
                        prm.abortPostBack();
                    }
                }
            </script>
        </div>
    </form>
</body>
</html>
