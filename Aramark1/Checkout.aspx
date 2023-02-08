﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Aramark1.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your payment method:<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Cash</asp:ListItem>
                <asp:ListItem>Creditcard</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Please write you card number:"></asp:Label>
            <asp:TextBox ID="CardNumbers" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Please write your card expiring date:"></asp:Label>
            <asp:TextBox ID="CardExpire" runat="server" TextMode="Month"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Please write the card CVC"></asp:Label>
            <asp:TextBox ID="CardCVC" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Please write the card holder's name:"></asp:Label>
            <asp:TextBox ID="CardHolder" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Refresh" runat="server" OnClick="Refresh_Click" Text="Refresh payment method" />
            <br />
            Your cart:<br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="OrderID" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateDeleteButton="True" AutoGenerateSelectButton="True">  
                    <Columns>  
                        <asp:BoundField DataField="OrderID" HeaderText="OrderID" SortExpression="OrderID" Visible="False" />
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" Visible="False" ReadOnly="True" />  
                        <asp:BoundField DataField="Pizza" HeaderText="Pizza" SortExpression="Pizza" />  
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                    </Columns>  
                </asp:GridView>
            The amount to pay:<asp:Label ID="PriceLabel" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Endcheckout" runat="server" OnClick="Endcheckout_Click" Text="End checkout" />
        </div>
    </form>
</body>
</html>
