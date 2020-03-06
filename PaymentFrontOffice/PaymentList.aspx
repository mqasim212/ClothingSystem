<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentList.aspx.cs" Inherits="PaymentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPayment" runat="server" style="z-index: 1; left: 81px; top: 57px; position: absolute; height: 247px; width: 286px"></asp:ListBox>
        <asp:Label ID="lblEnterDate" runat="server" style="z-index: 1; left: 82px; top: 331px; position: absolute; width: 283px" Text="Please Enter A Date: "></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 77px; top: 402px; position: absolute; width: 95px;" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 218px; top: 402px; position: absolute" Text="Display All" />
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 83px; top: 359px; position: absolute; width: 268px"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 78px; top: 462px; position: absolute; width: 82px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 268px; top: 462px; position: absolute; width: 82px" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 183px; top: 458px; position: absolute; width: 67px; height: 33px" Text="Edit" />
    </form>
</body>
</html>
