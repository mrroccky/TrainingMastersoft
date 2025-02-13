<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="OnlineExamModule._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Exam Module</title>
    <style type="text/css">
        body {
            background-color: #f5f5f5;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        .container {
           
            text-align: center;
        }

        h2 {
            text-align: center;
            color: #333;
            text-transform: uppercase;
        }

        .form-group {
            margin-bottom: 12px;
            text-align: left;
        }

        label {
            font-size: 14px;
            font-weight: bold;
            color: #555;
        }

        .txtinput {
            width: 94%;
            padding: 8px;
            border-radius: 12px;
            border: 1px solid #ccc;
            font-size: 14px;
            background-color: white;
            display: block;
            margin: auto;
        }

        .error-message {
            color: red;
            font-size: 12px;
            display: block;
            margin-top: 3px;
        }

          .btn {
            padding: 10px;
             border-radius: 16px;
            background-color: darkcyan;
            color: white;
            font-size: 16px;
            border: none;
            margin-top: 10px;
        }

        .btn:hover {
           color:black;
        }

        .link {
            display: block;
            margin-top: 10px;
            font-size: 14px;
            text-decoration: none;
        }

        .link:hover {
            text-decoration: underline;
        }

        .upload-section {
            text-align: left;
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Online Exam Module</h2>

            <div class="form-group">
                <label for="txtName">Enter Name:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="txtinput"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                    CssClass="error-message" ErrorMessage="Enter name"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtEmail">Enter Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="txtinput" TextMode="Email"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail"
                    CssClass="error-message" ErrorMessage="Enter proper email"
                    ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>

            <div class="form-group">
                <label for="txtPassword">Enter Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="txtinput" type="password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                    CssClass="error-message" ErrorMessage="Password required"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <label for="txtMobile">Enter Mobile:</label>
                <asp:TextBox ID="txtMobile" runat="server" CssClass="txtinput"></asp:TextBox>
                <asp:RegularExpressionValidator ID="mobileexpressionValidator" runat="server" ControlToValidate="txtMobile"
                    CssClass="error-message" ErrorMessage="Allowed 10 digit mobile number" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="errorMessage" runat="server" ControlToValidate="txtMobile" CssClass="error-message" ErrorMessage="number cant be null"></asp:RequiredFieldValidator>
            </div>

            <div class="upload-section">
                <label for="btnBrowseImage">
                <label for="txtEmailCheck">

            <asp:Label ID="lblError" runat="server" CssClass="error-message"></asp:Label>

                </label>
                Upload Photo:</label>
                <asp:FileUpload ID="btnBrowseImage" runat="server" />
                <asp:Button ID="btnUpload" runat="server" Text="Upload" CssClass="btn" OnClick="btnUpload_Click" />
            </div>

            <div class="form-group">
                <label for="txtDate">Date of Registration:</label>
                <asp:TextBox ID="txtDate" runat="server" CssClass="txtinput" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDate"
                    CssClass="error-message" ErrorMessage="Date can't be empty"></asp:RequiredFieldValidator>
            </div>

            <asp:Button ID="btnLogIn" runat="server" CssClass="btn" Text="Log In" OnClick="btnLogIn_Click" />

            <asp:HyperLink ID="linkGotoCreateAccount" runat="server" CssClass="link" NavigateUrl="~/LogIn.aspx">
                Already have an account?
            </asp:HyperLink>
        </div>
    </form>
</body>
</html>
