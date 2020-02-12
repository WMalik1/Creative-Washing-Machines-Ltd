<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" AssociatedControlID="nameText" Text="Name"></asp:Label>
        <br />
        <asp:TextBox ID="nameText" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" AssociatedControlID="addressText" Text="Address (Each address line on a new line)"></asp:Label>
        <br />
        <asp:TextBox ID="addressText" runat="server" TextMode="MultiLine" Width="245px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" AssociatedControlID="emailText" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="emailText" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" AssociatedControlID="passwordText" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="passwordText" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:CheckBox ID="marketingEmailsCheck" runat="server" Text="Marketing Emails?" />
        
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        
    </form>
</body>
</html>