<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BBB.aspx.cs" Inherits="Lab_3b.BBB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
            <tr>
                <td>Фамилия:</td>
                <td><asp:TextBox ID="TextBox1" runat="server" ValidationGroup="g6" ></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox1"
                        ErrorMessage="Фамилия обязательна для ввода" ValidationGroup="g6" Text="*"/>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox1" 
                        ErrorMessage="Фамилия должна быть на русском" ValidationGroup="g6"
                        ValidationExpression="[а-яА-Я]\S" Text="*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Имя:</td>
                <td><asp:TextBox ID="TextBox2" runat="server" ValidationGroup="g6"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox2" 
                        ErrorMessage="Имя обязательно для ввода" ValidationGroup="g6" Text="*" />
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox2" 
                        ErrorMessage="Имя должно быть на русском" ValidationGroup="g6"
                        ValidationExpression="[а-яА-Я]\S" Text="*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Отчество:</td>
                <td><asp:TextBox ID="TextBox3" runat="server" ValidationGroup="g6"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox3" 
                        ErrorMessage="Отчество обязательно для ввода" ValidationGroup="g6" Text="*" />
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox3" 
                        ErrorMessage="Отчество должно быть на русском" ValidationGroup="g6"
                        ValidationExpression="[а-яА-Я]\S" Text="*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Дата рождения:</td>
                <td><asp:TextBox ID="TextBox4" runat="server" ValidationGroup="g6"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox4" 
                        ErrorMessage="Дата рождения должена быть указана" ValidationGroup="g6" Text="*"/>
                    <asp:CustomValidator runat="server" ControlToValidate="TextBox4"
                        ClientValidationFunction="ClientValidate"
                        ErrorMessage="Дата должна не превышать текущую" ValidationGroup="g6" Text="*"
                        EnableClientScript="true" ></asp:CustomValidator>
                    <script type="text/javascript">
                        function ClientValidate(control, args) {
                            var curent_date = new Date();
                            var input_date = new Date(1 * args.Value.substr(6),
                                                      1 * args.Value.substr(3, 2) - 1,
                                                      1 * args.Value.substr(0, 2), 0, 0, 0, 0);
                            

                            args.IsValid = (input_date.getTime() <= curent_date.getTime());
                        }
                    </script>
                </td>
            </tr>
            <tr>
                <td>Адрес e-mail:</td>
                <td><asp:TextBox ID="TextBox5" runat="server" ValidationGroup="g6"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox5" 
                        ErrorMessage="Адрес должен быть указан" ValidationGroup="g6" Text="*"/>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox5" 
                        ErrorMessage="Некорректный e-mail" ValidationGroup="g6" Text="*"
                        ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Сумма:</td>
                <td><asp:TextBox ID="TextBox6" runat="server" ValidationGroup="g6"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox6" 
                        ErrorMessage="Сумма должна быть указана" ValidationGroup="g6" Text="*"/>
                    <asp:RangeValidator runat="server" ControlToValidate="TextBox6" 
                        ErrorMessage="Значение суммы должно быть от 1000 до 2000" Text="*"
                        Type="Integer" MinimumValue="1000" MaximumValue="2000"
                        ValidationGroup="g6"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>Пароль:</td>
                <td><asp:TextBox ID="TextBox7" runat="server" TextMode="Password" ValidationGroup="g6"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox7" 
                        ErrorMessage="Пароль должена быть указан" ValidationGroup="g6" Text="*"/>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox7" 
                        ErrorMessage="Пароль должен быть не менее 7 символов" ValidationGroup="g6"
                        ValidationExpression="\w{7,}" Text="*"></asp:RegularExpressionValidator>
                    <asp:CustomValidator runat="server" ValidationGroup="g6" Text="*"
                        ControlToValidate="TextBox7" ErrorMessage="Все символы в пароле должны быть уникальны"
                        ClientValidationFunction="isSymbolsUniqueInPassword" />
                    <script type="text/javascript">
                        function isSymbolsUniqueInPassword(control, args) {
                            var str = args.Value;
                            if (str != null) {
                                var obj = {};
                                for (var z = 0; z < str.length; ++z) {
                                    var ch = str[z];
                                    if (obj[ch]) {
                                        args.IsValid = false;
                                        return;
                                    } else
                                        obj[ch] = true;
                                }
                                args.IsValid = true;
                            } else
                                args.IsValid = false;
                        }
                    </script>
                </td>
            </tr>
        </table>
            <asp:Button ID="Button1" runat="server" Text="g6" ValidationGroup="g6" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="g6"
                DisplayMode="BulletList" ShowSummary="true" ShowMessageBox="false"/>
        </div>
    </form>
</body>
</html>
