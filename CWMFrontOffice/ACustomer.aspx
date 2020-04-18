<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="ACustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <asp:Label ID="lblCustomerID" runat="server" AssociatedControlID="txtCustomerID" Text="Customer ID"></asp:Label>
            <br />
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <asp:Button ID ="btnFind" runat="server" text="Find" OnClick="btnFind_Click"/>
            <br />
            <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" Text="Name (Space between first and last name)"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblAddress" runat="server" AssociatedControlID="txtAddress" Text="Address (Each address line on a new line)"></asp:Label>
            <br />
            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="245px" Height="100px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Email"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" AssociatedControlID="txtPassword" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CheckBox ID="checkMarketingEmails" runat="server" Text="Marketing Emails?" />
            <br />
            <asp:Label ID="lblRegistrationDate" runat="server" AssociatedControlID="txtRegistrationDate" Text="Registration Date"></asp:Label>
            <br />
            <asp:TextBox ID="txtRegistrationDate" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </form>
    </body>
</html>