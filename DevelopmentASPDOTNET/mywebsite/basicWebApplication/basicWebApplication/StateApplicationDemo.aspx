﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateApplicationDemo.aspx.cs" Inherits="basicWebApplication.StateApplicationDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Application Satate Implementation<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Number of Visitors" />
        </div>
    </form>
</body>
</html>
