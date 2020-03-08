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
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 36px; top: 465px; position: absolute; width: 82px; height: 32px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 259px; top: 466px; position: absolute; width: 90px; height: 33px;" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 143px; top: 467px; position: absolute; width: 85px; height: 30px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 37px; top: 517px; position: absolute"></asp:Label>
    </form>
</body>
</html>
