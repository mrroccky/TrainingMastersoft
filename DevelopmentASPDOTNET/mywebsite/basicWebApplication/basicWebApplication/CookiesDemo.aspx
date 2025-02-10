<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookiesDemo.aspx.cs" Inherits="basicWebApplication.CookiesDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Cookies Implementation<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Cookies" />
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Retrive Cookies" />
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
