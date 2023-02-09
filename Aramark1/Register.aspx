<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Aramark1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            Username:
            <asp:TextBox ID="Uname" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:
            <asp:TextBox ID="Pass" runat="server"></asp:TextBox>
        </p>
        <p>
            Confirm Password:
            <asp:TextBox ID="Confirmpass" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Button ID="Register1" runat="server" OnClick="Register1_Click" Text="Register" />
        <asp:Button ID="LogRed" runat="server" OnClick="LogRed_Click" Text="Login" />
    </form>
    </body>
</html>
