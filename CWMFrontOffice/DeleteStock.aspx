<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStock.aspx.cs" Inherits="DeleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this stock item record?"></asp:Label>
        </div>
        <br />
        <asp:Button ID="YesButton" runat="server" OnClick="Yes_Click" Text="Yes" Width="70px" />
        <asp:Button ID="NoButton" runat="server" OnClick="No_Click" Text="No" Width="70px" />
    </form>
</body>
</html>
