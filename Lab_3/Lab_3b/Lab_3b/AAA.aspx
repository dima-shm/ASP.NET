<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AAA.aspx.cs" Inherits="Lab_3b.AAA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>1. RequiredFiledValidator</h3>
            <asp:TextBox ID="TextBox1" runat="server" 
                ValidationGroup="g1"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                ValidationGroup="g1"></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="g1" 
                ValidationGroup="g1" />
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" ErrorMessage="Не введено значение TextBox1"
                ValidationGroup="g1"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="DropDownList1" ErrorMessage="Не введено значение DropDownList1"
                ValidationGroup="g1"></asp:RequiredFieldValidator>
            <br />
            <hr />

            <h3>2. RangeValidator</h3>
            <asp:TextBox ID="TextBox2" runat="server"
                ValidationGroup="g2"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server"
                ValidationGroup="g2"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="g2" 
                ValidationGroup="g2" />
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ControlToValidate="TextBox2" ErrorMessage="Ошибка диапазона в TextBox2 (значение должно быть от 100 до 200)"
                Type="Integer" MinimumValue="100" MaximumValue="200"
                ValidationGroup="g2"></asp:RangeValidator>
            <br />
            <asp:RangeValidator ID="RangeValidator3" runat="server" 
                ControlToValidate="TextBox3" ErrorMessage="Ошибка диапазона в TextBox3 (значение даты должно быть от 01.01.2011 до 31.12.2011)"
                Type="Date" MinimumValue="01.01.2011" MaximumValue="31.12.2011"
                ValidationGroup="g2"></asp:RangeValidator>
            <br />
            <hr />

            <h3>3. CompareValidator</h3>
            <asp:TextBox ID="TextBox4" runat="server"
                ValidationGroup="g3"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server"
                ValidationGroup="g3"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="g3" 
                ValidationGroup="g3" />
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ErrorMessage="Ошибка сравнения TextBox4 и TextBox5 (значение даты в TextBox4 должно быть меньше чем в TextBox5)"
                ControlToValidate="TextBox4" ControlToCompare="TextBox5" Operator="LessThan" Type="Date"
                ValidationGroup="g3"></asp:CompareValidator>
            <br />
            <hr />

            <h3>4. RegularExpressionValidator</h3>
            <asp:TextBox ID="TextBox6" runat="server"
                ValidationGroup="g4"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="g4" 
                ValidationGroup="g4" />
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="TextBox6" ErrorMessage="Ошибка выражения в TextBox6 (некорректный e-mail)"
                ValidationExpression="\S+@\S+\.\S+"
                ValidationGroup="g4"></asp:RegularExpressionValidator>
            <br />
            <hr />

            <h3>5. CustomValidator</h3>
            <asp:TextBox ID="TextBox7" runat="server"
                ValidationGroup="g5"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" Text="g5" 
                ValidationGroup="g5" />
            <br />
            <asp:CustomValidator ID="CustomValidator1" runat="server"
                ClientValidationFunction="ClientValidate" OnServerValidate="ServerValidate"
                ControlToValidate="TextBox7" ErrorMessage="Значение TextBox7 должно быть простым"
                ValidationGroup="g5"
                EnableClientScript="true" ></asp:CustomValidator>
            <script type="text/javascript">
                function ClientValidate(ctl, args) {
                    args.IsValid = (args.Value % 2 != 0);
                }
            </script>
            <br />
            <hr />

            <h3>6. ValidationSummary</h3>
            <asp:Label ID="Label1" runat="server" Text="Смотри aspx-форму BBB"></asp:Label>
            <br />
            <hr />
        </div>
    </form>
</body>
</html>
