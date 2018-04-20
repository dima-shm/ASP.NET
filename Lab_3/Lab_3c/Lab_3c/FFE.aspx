<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FFE.aspx.cs" Inherits="Lab_3c.FFE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>1. MultiView</h3>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Button1" OnClick="Button1_Click" style="height: 25px" />
                    <asp:Wizard ID="Wizard1" runat="server" BackColor="#E6E2D8" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
                        ActiveStepIndex="0" OnFinishButtonClick="Wizard1_FinishButtonClick" OnNextButtonClick="Wizard1_NextButtonClick" OnCancelButtonClick="Wizard1_CancelButtonClick" DisplayCancelButton="true">
                        <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                        <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
                        <SideBarButtonStyle ForeColor="White" />
                        <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
                        <StepStyle BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" />
                        <WizardSteps>
                            <asp:WizardStep ID="WizardStep1" runat="server" Title="Шаг 1">
                                <table style="border: 0px solid black;">
                                    <tr>
                                        <td>Фамилия</td>
                                        <td>
                                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Имя</td>
                                        <td>
                                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                        </td>
                                    </tr> 
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep ID="WizardStep2" runat="server" Title="Шаг 2">
                                <table style="border: 0px solid black;">
                                    <tr>
                                        <td>Язык программирования</td>
                                        <td>
                                            <asp:ListBox ID="ListBox1" runat="server">
                                                <asp:ListItem>C#</asp:ListItem>
                                                <asp:ListItem>VB</asp:ListItem>
                                                <asp:ListItem>J#</asp:ListItem>
                                                <asp:ListItem>Java</asp:ListItem>
                                                <asp:ListItem>C++</asp:ListItem>
                                                <asp:ListItem>C</asp:ListItem>
                                            </asp:ListBox>
                                        </td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep ID="WizardStep3" runat="server" Title="Шаг 3">
                                Программы:
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                    <asp:ListItem>Visual Studio 2017</asp:ListItem>
                                    <asp:ListItem>Office 2016</asp:ListItem>
                                    <asp:ListItem>Windows Server 2008</asp:ListItem>
                                    <asp:ListItem>SQL Server 2012</asp:ListItem>
                                </asp:CheckBoxList>
                            </asp:WizardStep>
                            <asp:WizardStep ID="WizardStep4" runat="server" Title="Шаг 4">
                                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                            </asp:WizardStep>
                            <asp:WizardStep ID="Complete" runat="server" Title="Итог " StepType="Finish">
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </asp:WizardStep>
                        </WizardSteps>
                    </asp:Wizard>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="Button2" OnClick="Button2_Click" style="height: 25px" />
                    <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
                        <Nodes>
                            <asp:TreeNode Value="1" ToolTip="Chapter 1">
                                <asp:TreeNode Value="1.1" />
                                <asp:TreeNode Value="1.2">
                                    <asp:TreeNode Value="1.2.1" ShowCheckBox="true" Checked="true" />
                                    <asp:TreeNode Value="1.2.2" ShowCheckBox="true" />
                                    <asp:TreeNode Value="1.2.3" ShowCheckBox="true" />
                                </asp:TreeNode>
                                <asp:TreeNode Value="1.3" />
                            </asp:TreeNode>
                            <asp:TreeNode Value="2" ImageUrl="~/icons8-book-26.png">
                                <asp:TreeNode Value="2.1" />
                                <asp:TreeNode Value="2.2" />
                                <asp:TreeNode Value="2.3" />
                            </asp:TreeNode>
                            <asp:TreeNode Value="1">
                                <asp:TreeNode Value="3.1" />
                                <asp:TreeNode Value="3.2" />
                                <asp:TreeNode Value="3.3" />
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" Text="Button3" OnClick="Button3_Click" />
                     <asp:Menu ID="Menu1" runat="server" OnMenuItemClick="Menu1_MenuItemClick" Orientation="Vertical" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" StaticSubMenuIndent="10px">
                        <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
                        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <DynamicMenuStyle BackColor="#E3EAEB" />
                        <DynamicSelectedStyle BackColor="#1C5E55" />
                        <StaticHoverStyle BackColor="#666666" ForeColor="White" />
                        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                        <StaticSelectedStyle BackColor="#1C5E55" />

                        <Items>
                            <asp:MenuItem Value="A">
                                <asp:MenuItem Value="AA1" ToolTip="Item AA1" />
                                <asp:MenuItem Value="AA2">
                                    <asp:MenuItem Value="AAA1" />
                                    <asp:MenuItem Value="AAA2" />
                                    <asp:MenuItem Value="AAA3" />
                                </asp:MenuItem>
                                <asp:MenuItem Value="AA3" />
                            </asp:MenuItem>
                            <asp:MenuItem Value="B" />
                            <asp:MenuItem Value="C" />
                        </Items>
                    </asp:Menu>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </asp:View>
            </asp:MultiView>
            <br />
            <asp:Button ID="Button4" runat="server" Text="Button4" OnClick="Button4_Click" />
            <br />
            <hr />

            <h3>2. AdRotator</h3>
            <asp:AdRotator ID="AdRotator1" runat="server" 
                 AdvertisementFile="~/App_Data/AdRotator.xml" Target="_blank"/>
            <br />
            <asp:Button ID="Button5" runat="server" Text="" OnClick="Button5_Click" />
        </div>
    </form>
</body>
</html>
