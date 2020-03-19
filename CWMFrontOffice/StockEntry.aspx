<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockEntry.aspx.cs" Inherits="StockEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 341px;
            width: 358px;
        }
    </style>
</head>
<body style="height: 337px; width: 359px">
    <form id="form1" runat="server">
        
        <asp:Label ID="lblProductCode" runat="server" Text="Product Code:"></asp:Label>
        <br />
        <asp:TextBox ID="txtProductCode" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        <br />
        <asp:Label ID="lblDescription" runat="server" AssociatedControlID="txtDescription" Text="Item Description: "></asp:Label>
        <br />
        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="325px" Height="34px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" AssociatedControlID="txtPrice" Text="Price: "></asp:Label>
        <br />
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNext_IntakeText" runat="server" AssociatedControlID="txtNext_Intake" Text="Next Intake: "></asp:Label>
        <br />
        <asp:TextBox ID="txtNext_Intake" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPristine" runat="server" AssociatedControlID="txtPristine" Text="Pristine: "></asp:Label>
        <br />
        <asp:TextBox ID="txtPristine" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNon_Pristine" runat="server" AssociatedControlID="txtNon_Pristine" Text="Non-Pristine: "></asp:Label>
        <br />
        <asp:TextBox ID="txtNon_Pristine" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="checkClearence" runat="server" Text="Clearence?" />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
        <asp:Label ID="lblError" runat="server" ></asp:Label>

    </form>
</body>
</html>
