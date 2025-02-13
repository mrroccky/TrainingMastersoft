<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="OnlineExamModule.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }

        .container {
            width: 300px;
            padding: 20px;
            background-color: white;
            text-align: center;
        }

        h2 {
            margin-bottom: 20px;
            color: #333;
        }

        .form-group {
            margin-bottom: 15px;
            text-align: left;
        }

        label {
            font-size: 14px;
            font-weight: bold;
            color: #555;
        }

        .input-field {
            border-radius:12px;
            width: 92%;
            padding: 8px;
            border: 1px solid #ccc;
            font-size: 14px;
            background-color: white;
            display: block;
            margin: auto;
        }

        .error-message {
            color: red;
            font-size: 12px;
        }

         .btn {
            background-color: darkcyan;
            border-radius:16px;
            color: white;
            border: none;
            padding: 10px;
            width: 80%;
            margin-top: 15px;
            cursor: pointer;
            border-radius: 5px;
            font-size: 16px;
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Log In</h2>
            <div class="form-group">
                <label for="txtEmailCheck">

            <asp:Label ID="lblError" runat="server" CssClass="error-message"></asp:Label>

                <br />
                Enter Email:</label>
                <asp:TextBox ID="txtEmailCheck" runat="server" CssClass="input-field"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                    runat="server" ControlToValidate="txtEmailCheck" CssClass="error-message" 
                    ErrorMessage="Enter a valid Email" 
                    ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>

            <div class="form-group">
                <label for="txtPassCheck">Enter Password:</label>
                <asp:TextBox ID="txtPassCheck" runat="server" CssClass="input-field" TextMode="Password"></asp:TextBox>
            </div>

            <asp:Button ID="btnLogIn" runat="server" CssClass="btn" Text="Create Exam" OnClick="btnLogIn_Click1" />

            <asp:HyperLink ID="linkGotoCreateAccount" runat="server" CssClass="link" NavigateUrl="~/default.aspx">
                Create an account
            </asp:HyperLink>
        </div>
    </form>
</body>
</html>
