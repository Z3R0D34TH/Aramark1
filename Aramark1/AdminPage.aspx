<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Aramark1.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Black"></asp:Label>
            <br />
            <asp:Button ID="GoAsCustomer" runat="server" OnClick="GoAsCustomer_Click" Text="Go as a customer" />
            <asp:Button ID="CheckOrders" runat="server" OnClick="CheckOrders_Click" Text="Check all the orders" />
            <asp:Button ID="CheckUsers" runat="server" OnClick="CheckUsers_Click" Text="Check all the users" />
        </div>
    </form>
</body>
</html>
