<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSateDemo.aspx.cs" Inherits="basicWebApplication.ViewSateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View Sate Implmentation<br />
            <br />
            Enter data :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Clear Value" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Display Value" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
