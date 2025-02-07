<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageNavigation.aspx.cs" Inherits="basicWebApplication.PageNavigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Navigation Implementaion Using Control<br />
            Link Button Control<br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/PageConatint.aspx">Visit My Next Page</asp:LinkButton>
            <br />
            <br />
            Hyper link control: connect url :<br />
&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://linkedin.com/in/rakeshbhure-">Visit my Linked in</asp:HyperLink>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Visit MyPage" />
    </form>
</body>
</html>
