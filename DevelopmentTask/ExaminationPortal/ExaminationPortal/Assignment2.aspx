<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment2.aspx.cs" Inherits="ExaminationPortal.Assignment2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Implementation Drop Dawn list</h2><br />
            <br />
            Selsect your degree :
            <asp:DropDownList ID="ddlDegree" runat="server" OnSelectedIndexChanged="ddDegree_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>UG</asp:ListItem>
                <asp:ListItem>PG</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Select your branch :
            <asp:DropDownList ID="ddlSelectBranch" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            Upload student photo :
            <asp:FileUpload ID="FileUpload1" runat="server" />
            &nbsp;<asp:Button ID="btnUpload" runat="server" Text="Upload photo" OnClick="btnUpload_Click" />
            <br />
            <br />
            Select your photo :
            <asp:DropDownList ID="ddlSelectPic" runat="server" OnSelectedIndexChanged="ddlSelectPic_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Image ID="iiCandidateImage" runat="server" Height="346px" Width="412px" />
            <br />
            <br />
            <asp:Label ID="lblimageName" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnDisplayNextPage" runat="server" Text="Display next" OnClick="btnDisplayNextPage_Click" />
        </div>
    </form>
</body>
</html>
