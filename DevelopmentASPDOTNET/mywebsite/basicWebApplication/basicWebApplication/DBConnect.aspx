<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBConnect.aspx.cs" Inherits="basicWebApplication.DBConnect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Database connectivity Implementation<br />
            <br />
            Enter roll number:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Enter city:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </div>
    </form>
</body>
</html>
