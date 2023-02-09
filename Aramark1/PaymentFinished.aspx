<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentFinished.aspx.cs" Inherits="Aramark1.PaymentFinished" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Your order has been placed. Thank you for ordering at Aramark.</p>
        <p>
            <asp:Button ID="Menu" runat="server" OnClick="Menu_Click" Text="Go back to the menu" />
        </p>
    </form>
</body>
</html>
