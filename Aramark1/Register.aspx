<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Aramark1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your name:
            <asp:TextBox ID="NameBox" runat="server" OnTextChanged="NameBox_TextChanged"></asp:TextBox>
            <br />
            Enter your second name: <asp:TextBox ID="SecondNameBox" runat="server"></asp:TextBox>
            <br />
            Enter email:<asp:TextBox ID="EmailBox" runat="server"></asp:TextBox>
            <br />
            Enter password:<asp:TextBox ID="PasswordBox" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            Confirm password<asp:TextBox ID="ConfirmBox" runat="server" OnTextChanged="ConfirmBox_TextChanged" style="height: 22px" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="ErrorsLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
