<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_3a.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Элемент HTMLInputReset       <input type="reset"  id="reset1" value="reset" runat="server" /> <br />
            Элемент HTMLInputButton      <input type="button" id="button1" value="button" runat="server" onserverclick="Button_Click" /> <br />
            Элемент HTMLInputSubmit      <input type="submit" id="submit1" value="submit" runat="server" onserverclick="Submit_Click" /> <br />
            Элемент HTMLInputFile        <input type="file" id="file1" runat="server" /> <br />
            Элемент HTMLInputText        <input type="text" id="text1" runat="server" onserverchange="Text_Change" /> <br />
            Элемент HTMLInputPassword    <input type="password" id="password1" runat="server" оnserverclick="Password_Click" onserverchange="Password_Change" /> <br />
            Элемент HTMLInputCheckbox    <input type="checkbox" id="checkbox1" runat="server" onserverchange="CheckBox_Change" /> <br />
            Элемент HTMLInputRadioButton <input type="radio" name="radioname" id="radio1" runat="server" onserverchange="Radio1_Change" />
                                         <input type="radio" name="radioname" id="radio2" runat="server" onserverchange="Radio2_Change" /> <br />
            Элемент HTMLTextArea         <textarea runat="server" id="textarea1" onserverchange="TextArea_Change" ></textarea> <br />
            Элемент HTMLSelect           <select runat="server" id="select1" onserverchange="Select_Change" > </select> <br />
        </div>
    </form>
</body>
</html>