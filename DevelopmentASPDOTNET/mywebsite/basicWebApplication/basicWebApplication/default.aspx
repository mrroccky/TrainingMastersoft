<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="basicWebApplication._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            welcome to my first web application
            <br />
        </div>
        <p>
            addition of two number</p>
        <p>
            Enter First Number</p>
        <p>
            <asp:TextBox ID="txtNum1" runat="server" OnTextChanged="txtNum1_TextChanged"></asp:TextBox>
        </p>
        <p>
            Enter Second Number</p>
        <p>
            <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
        </p>
        <p>
            Result is :</p>
        <p>
            <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="Button1_Click" Text="Submit" Width="169px" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Multiplication" />
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </p>
        <ol>
            <li>Generate student grade system</li>
            <li>enter roll number</li>
        </ol>
<!-- notionvc: 3c6d42f3-fed3-4455-9cfa-561224f36beb -->
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server">enxer </asp:TextBox>
    </form>
</body>
</html>
