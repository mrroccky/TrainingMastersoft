<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Task1DesignStudentGradeSystem._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body{
            background-color:bisque;
        }
        .wrapper{
            margin-left:25%;
            margin-right:25%;
            align-items:center;
            align-self:center;
            justify-content:center;
        }
        h1{
            background-color:aqua;
            font-weight:bold;
            text-align:center;

        }
        .input{
            width:100%;
            height:40px;
            border-radius:12px;
            border:1px solid gray;
        }
        .btn{
            width:100%;
            height:40px;
            background-color:aqua;
            border-radius:12px;
            text-transform:uppercase;
        }
        .btn:hover{
            background-color:aquamarine;
        }
        
    </style>
    <script language="JavaScript">

    </script>
</head>
<body >
    <form id="form1" runat="server">
        <div class="wrapper">
            <h1 >Student Grade System</h1>
            <br />
            Enter roll number :&nbsp; <asp:TextBox CssClass="input" ID="txtRoll" runat="server" OnTextChanged="txtRoll_TextChanged"></asp:TextBox>
            <br />
            Enter Candidate Name :&nbsp; <asp:TextBox CssClass="input" ID="txtName" runat="server"></asp:TextBox>
            <br />
            Enter Branch :&nbsp;
            <asp:TextBox CssClass="input" ID="txtBranch" runat="server"></asp:TextBox>
            <br />
            Enter Subject 1 Marks :&nbsp;
            <asp:TextBox CssClass="input" ID="txtSub1marks" runat="server"></asp:TextBox>
            <br />
            EnterSubject 2 Marks :&nbsp;
            <asp:TextBox CssClass="input" ID="txtSub2marks" runat="server"></asp:TextBox>
            <br />
            Enter Subject 3 Marks :&nbsp;
            <asp:TextBox CssClass="input" ID="txtSub3marks" runat="server"></asp:TextBox>
            <br />
            Enter Subject 4 Marks:&nbsp;
            <asp:TextBox CssClass="input" ID="txtSub4marks" runat="server"></asp:TextBox>
            <br />
            Enter SubjectEnter Subject 5 Marks:&nbsp;
            <asp:TextBox CssClass="input" ID="txtSub5marks" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button CssClass="btn" ID="btnCalculateTotal" runat="server" Text="Calculate Total" OnClick="btnCalculateTotal_Click" />
            <br />
            <br />
            Total Marks is:&nbsp;
            <asp:TextBox CssClass="input" ID="txtTotalMarks" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button  CssClass="btn" ID="btnGenrateGrade" runat="server" Text="Genrate Grade" OnClick="btnGenrateGrade_Click" />
            <br />
            <br />
            Your Grade: <asp:TextBox CssClass="input" ID="txtGrade" runat="server"></asp:TextBox>
            <br />
        </div>
        <div>
            <br />
        </div>
    </form>
</body>
</html>
