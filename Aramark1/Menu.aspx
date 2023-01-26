<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Aramark1.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">  
                    <Columns>  
                        <asp:BoundField DataField="OrderID" HeaderText="OrderID" Visible="False" />  
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" Visible="False" />  
                        <asp:BoundField DataField="Pizza" HeaderText="Pizza" />  
                        <asp:BoundField DataField="Price" HeaderText="Price" />  
                        <asp:BoundField DataField="Date" HeaderText="Date" />
                        <asp:CommandField ShowDeleteButton="true" /> </Columns>  
                </asp:GridView>
        Price:
        <asp:Label ID="Price" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
