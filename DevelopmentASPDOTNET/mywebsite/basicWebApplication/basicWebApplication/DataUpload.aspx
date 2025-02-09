<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataUpload.aspx.cs" Inherits="basicWebApplication.DataUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            File Upload Implementation<br />
            Upload Your Photo :<br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Upload Resume" />
            <br />
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;<br />
            <br />
            Dawnload Your Data<br />
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        </div>
    </form>
</body>
</html>
