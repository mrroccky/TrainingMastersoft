<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageValidation.aspx.cs" Inherits="basicWebApplication.PageValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Validation Control Implementation<br />
            <br />
            1. Recuired validator&nbsp; control<br />
            <br />
            Enter your name :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name Required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <br />
            <br />
            <br />
            Range Validator Implementation<br />
            <br />
            Enter your gae between 18 to 30 :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Invalid age" MaximumValue="30" MinimumValue="18"></asp:RangeValidator>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Regular expression validator</p>
        <p>
            Enter your mobile number :
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Invalid mobile number" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Compare Vaidator Control</p>
        <p>
            Enter Account Number :
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            Re-Type account numbr :
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox4" ErrorMessage="Account Number does not Match"></asp:CompareValidator>
        </p>
    </form>
</body>
</html>
