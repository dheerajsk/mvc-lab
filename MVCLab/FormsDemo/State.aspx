<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="State.aspx.cs" Inherits="FormsDemo.State" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCounter" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Increase Counter" />
        </div>
    </form>
</body>
</html>
