<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment2.aspx.cs" Inherits="basicWebApplication.Assignment2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Implementation dropdawn list<br />
            <br />
            Q1.
            <br />
            Select your degree :
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>UG</asp:ListItem>
                <asp:ListItem>PG</asp:ListItem>
            </asp:DropDownList>
            <br />
            Select you branch :
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>UG</asp:ListItem>
                <asp:ListItem>PG</asp:ListItem>
            </asp:DropDownList>
&nbsp; if(ug) then show ug&nbsp;&nbsp; then display all ug braches branches&nbsp; if user select pg then display all pg branches (in dropdown list 2) dependent on degree picklist&nbsp;&nbsp;
            <br />
            <br />
            <br />
            Q2.<br />
            Upload student photo
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Upload Button" />
            <br />
            Select your photo :&nbsp;
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
&nbsp;(whatever pic is uploaded add them in list whatever he select on picklist then show that perticular image in image box)<br />
            <asp:Image ID="Image1" runat="server" Height="223px" Width="233px" />
            &nbsp;<br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Display Next" />
&nbsp; using session and query steram
        </div>
    </form>
</body>
</html>
