<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationSummaryDemo.aspx.cs" Inherits="basicWebApplication.ValidationSummaryDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Validation Summary Implementation<br />
            <br />
            Enter your name :
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Name Required">*</asp:RequiredFieldValidator>
            <br />
            Enter city&nbsp; :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="City Required">*</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
        </div>
    </form>
</body>
</html>
