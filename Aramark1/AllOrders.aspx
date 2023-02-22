<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllOrders.aspx.cs" Inherits="Aramark1.AllOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Height="291px" Width="598px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <asp:Button ID="Back" runat="server" Text="Go back" OnClick="Back_Click" />
            <br />
        </div>
    </form>
</body>
</html>
