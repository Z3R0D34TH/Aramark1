<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Aramark1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="UsernameBox" runat="server" MaxLength="20"></asp:TextBox>
            <br />
            Password:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="PasswordBox" runat="server" OnTextChanged="PasswordBox_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
