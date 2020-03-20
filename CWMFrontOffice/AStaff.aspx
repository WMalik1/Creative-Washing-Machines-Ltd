<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStaff.aspx.cs" Inherits="AStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <asp:Label ID="lblStaffID" runat="server" AssociatedControlID="txtStaffID" Text="Staff ID"></asp:Label>
            <br />
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
             <asp:Button ID ="btnFind" runat="server" text="Find" OnClick="btnFind_Click"/>
            <br />
            <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" Text="Full Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server" Width="132px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="Email Address"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" runat="server" Width="133px"></asp:TextBox>
            <br />
            <asp:Label ID="lblSalary" runat="server" AssociatedControlID="txtSalary" Text="Salary"></asp:Label>
            <br />
            <asp:TextBox ID="txtSalary" runat="server" Width="132px" ></asp:TextBox>
            <br />
            <asp:CheckBox ID="checkActive" runat="server" Text="Active?" />
            <br />
            <asp:Label ID="lblHireDate" runat="server" AssociatedControlID="txtHireDate" Text="Hire Date"></asp:Label>
            <br />
            <asp:TextBox ID="txtHireDate" runat="server" TextMode="Date" Width="133px"></asp:TextBox>
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </form>
    </body>
</html>