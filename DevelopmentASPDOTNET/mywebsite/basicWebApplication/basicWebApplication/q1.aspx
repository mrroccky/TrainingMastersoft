<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q1.aspx.cs" Inherits="basicWebApplication.q1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Query Stream Implementation<br />
            Enter your email id :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter mobile number :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
            <br />
        </div>
    </form>
</body>
</html>
