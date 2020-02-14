<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockEntry.aspx.cs" Inherits="StockEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 277px;
            width: 358px;
        }
    </style>
</head>
<body style="height: 276px; width: 359px">
    <form id="form1" runat="server">

        <asp:Label ID="Description" runat="server" Text="Item Description: "></asp:Label>
        <br />
        <asp:TextBox ID="DescriptionText" runat="server" TextMode="MultiLine" Width="325px" Height="34px"></asp:TextBox>
        <br />
        <asp:Label ID="Price" runat="server" Text="Price: "></asp:Label><asp:TextBox ID="PriceValue" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="IntakeDateText" runat="server" Text="Next Intake Date: "></asp:Label><asp:TextBox ID="IntakeDate" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="Pristine" runat="server" Text="Pristine?" />
        <br />
        <asp:CheckBox ID="NonPristine" runat="server" Text="Non-Pristine?" />
        <br />
        <asp:CheckBox ID="Clearence" runat="server" Text="Clearence?" />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click"/>
        <asp:Button ID="btnClear" runat="server" Text="Clear" />
        <br />
        <asp:Button ID="Cancel" runat="server" Text="Cancel" />


    </form>
</body>
</html>
