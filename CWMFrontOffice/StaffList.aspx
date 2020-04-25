<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 530px">
            Staff List<br />
            <asp:ListBox ID="lstStaff" runat="server" Height="178px" Width="307px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <br />
            <br />
            Active Search: 
            <asp:DropDownList ID="lstActive" runat="server">
                <asp:ListItem Text="True" Value="true"></asp:ListItem>
                <asp:ListItem Text="False" Value="false"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button4" runat="server" Text="Apply" OnClick="btnApply1_Click" />
            <asp:Button ID="Button5" runat="server" Text="Clear"  />
            <br />
            <br />Email Search:<asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            <asp:Button ID="btnApply2" runat="server" OnClick="btnApply2_Click" Text="Apply" />
            <asp:Button ID="btnClear2" runat="server" OnClick="btnClear2_Click" Text="Clear" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
