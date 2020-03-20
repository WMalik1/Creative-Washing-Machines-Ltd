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
            <asp:ListBox ID="lstCustomers" runat="server" Height="150px" Width="300px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br />
            Marketing Preference Search: &nbsp; <asp:DropDownList ID="lstPreference" runat="server">
                                                    <asp:ListItem Text="True" Value="true"></asp:ListItem>
                                                    <asp:ListItem Text="False" Value="false"></asp:ListItem>
                                                </asp:DropDownList>
            &nbsp;<asp:Button ID="btnMarketingSearch" runat="server" Text="Apply" OnClick="btnMarketingSearch_Click"/>
            &nbsp;<asp:Button ID="btnMarketingSearchClear" runat="server" Text="Clear" OnClick="btnClear_Click"/>
            <br />
            Address Search: &nbsp; <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="btnAddressSearch" runat="server" Text="Apply" OnClick="btnAddressSearch_Click"/>
            &nbsp;<asp:Button ID="btnAddressSearchClear" runat="server" Text="Clear" OnClick="btnClear_Click"/>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
