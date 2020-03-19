<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerList" runat="server" AssociatedControlID="lstCustomers" Text="Customer List"></asp:Label>
            <br />
            <asp:ListBox ID="lstCustomers" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
