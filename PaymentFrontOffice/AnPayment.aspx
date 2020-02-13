<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnPayment.aspx.cs" Inherits="AnPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 63px; top: 116px; position: absolute; height: 23px; bottom: 289px" Text="OrderID"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 146px; top: 114px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 65px; top: 170px; position: absolute; width: 75px" Text="Date"></asp:Label>
        <asp:Label ID="lblTotalCost" runat="server" style="z-index: 1; left: 63px; top: 220px; position: absolute; height: 19px" Text="Total Cost"></asp:Label>
        <asp:Label ID="lblStatusID" runat="server" style="z-index: 1; left: 66px; top: 266px; position: absolute; height: 20px" Text="StatusID"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 38px; top: 357px; position: absolute; height: 26px; width: 53px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 357px; position: absolute; left: 124px; width: 58px" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 65px; top: 313px; position: absolute; height: 21px; width: 57px" Text="[lblError]"></asp:Label>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 148px; top: 166px; position: absolute; height: 17px"></asp:TextBox>
        <asp:TextBox ID="txtTotalCost" runat="server" style="z-index: 1; left: 147px; top: 221px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkStatusID" runat="server" style="z-index: 1; left: 143px; top: 267px; position: absolute" />
    </form>
</body>
</html>
