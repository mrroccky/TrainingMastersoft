<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonRadio.aspx.cs" Inherits="basicWebApplication.ButtonRadio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Redio Button List Implementation<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" style="margin-right: 5px" Width="365px">
                <asp:ListItem>Nagpur</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Enter new City<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
        </div>
    </form>
</body>
</html>
