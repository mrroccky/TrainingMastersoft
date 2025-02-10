<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validateClientDemo.aspx.cs" Inherits="basicWebApplication.validateClientDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="JavaScript">
        function ValidationCheck() {
            var summary="";
            summary += isUserValid();
            summary += isValidFname();

            if (summary != "") {
                alert(summary);
                return false;
            } else {
                return true;
            }

            function isUserValid() {
                var id;
                var temp = document.getElementById("<%=txtUName.ClientID %>");
                id = temp.value;
                if (id == "") {
                    return ("Please input valid User");
                } else {
                    return "";
                }
            }
            function isValidFname() {
                var id; 
                var temp = document.getElementById("<%=txtFName.ClientID %>");
                id = temp.value;
                if (id == "") {
                    return ("Please enter valid frist name ");
                } else {
                    return "";
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Client Side validatios<br />
            <br />
            User name :
            <asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
            <br />
            Frist name :
            <asp:TextBox ID="txtFName" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
