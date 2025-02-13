<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="OnlineExamModule.Exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exam Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
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
            margin-bottom: 20px;
            color: #333;
        }
        .input-box {
            border-radius:12px;
            width: 100%;
            padding: 8px;
            margin: 8px 0;
            border: 1px solid #ccc;
        }
        
        .btn {
            padding: 10px;
            border-radius:16px;
            background-color:darkcyan;
            color: white;
            font-size: 16px;
            border: none;
            margin-top: 10px;
        }

        .btn:hover {
           color:black;
        }
        .dropdown {
            border-radius:12px;
        }
    
        .error-message {
            color: red;
            font-size: 12px;
        }

         </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Student Examination Form</h2>
            <p><strong>Student Name:</strong> <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></p>
            <p><strong>Student Email:</strong> <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label></p>
            
            <asp:TextBox type="text" id="txtCollageName" runat="server" class="input-box" placeholder="Enter College Name" ></asp:TextBox>
            <asp:TextBox type="text" id="txtBranchName" runat="server" class="input-box" placeholder="Enter Branch Name" ></asp:TextBox>
            
            <label><strong>
            <br />
                <label for="txtEmailCheck">

            <asp:Label ID="lblError" runat="server" CssClass="error-message"></asp:Label>

            </label>
                <br />
            Semester:</strong></label>
            <asp:DropDownList ID="ddlSemister" runat="server" CssClass="dropdown" Height="29px" Width="167px">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
            </asp:DropDownList>

            &nbsp;<br />
            <br />
            <br />


            <asp:Button ID="btnTestStart" runat="server" Text="Start Examination" CssClass="btn" OnClick="btnTestStart_Click" />
        </div>
    </form>
</body>
</html>
