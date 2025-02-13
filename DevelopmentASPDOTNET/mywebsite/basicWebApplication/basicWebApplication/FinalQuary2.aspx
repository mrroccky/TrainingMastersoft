<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinalQuary2.aspx.cs" Inherits="basicWebApplication.FinalQuary2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            Enter Mobile :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            your Email is :
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
        </div>
    </form>
    <form id="form1" runat="server">
    </form>
</body>
</html>
