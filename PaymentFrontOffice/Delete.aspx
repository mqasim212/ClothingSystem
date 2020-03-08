<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 37px; top: 242px; position: absolute; height: 22px" Text="lblError"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 68px; top: 71px; position: absolute" Text="Are you sure you want to delete this Payment?"></asp:Label>
        </p>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 80px; top: 116px; position: absolute; width: 59px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 159px; top: 116px; position: absolute; width: 60px" Text="No" />
    </form>
</body>
</html>
