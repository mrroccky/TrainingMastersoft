<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageConatint.aspx.cs" Inherits="basicWebApplication.PageConatint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Containt management implementation<br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="C Programming" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Java Programming" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Dot Net Framework" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Python Programming" />
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                C Programming
            </asp:View>
            <asp:View ID="View2" runat="server">
                Java Programming
            </asp:View>
            <asp:View ID="View3" runat="server">
                Dot Net programming
            </asp:View>
            <asp:View ID="View4" runat="server">
                Python Programming
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
