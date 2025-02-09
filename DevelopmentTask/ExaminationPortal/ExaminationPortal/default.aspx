<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ExaminationPortal._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Online Examination Portal</title>
    <style type="text/css">
        body {
            background-color: rgb(30, 59, 73);;
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }

        .studentregistrationform, .viewOne, .viewTwo, .viewThree, .viewFour {
            width: 80%;
            margin: auto;
            background: white;
            padding: 30px;
            margin-top:3%;
            margin-bottom:3%;
        }

        .viewOne, .viewTwo, .viewThree, .viewFour {
            margin-top: 2%;
        }

        .heading1 {
            color: #333;
            text-transform: uppercase;
            text-align: center;
        }

        .heading2 {
            text-align: center;
            color: #444;
            margin-bottom: 20px;
        }

        .thxBox {
            height: 30px;
            border: 1px solid gray;
            border-radius: 12px;
            width: 80%;
            padding: 5px;
            margin: 10px auto;
            display: block;
        }

            .thxBox:hover {
                border-color: green;
            }

        .btn {
            text-transform: uppercase;
            font-weight: bold;
            background-color: aqua;
            color: black;
            border: none;
            border-radius: 6px;
            height: 40px;
            width: 200px;
            margin-top: 10px;
            cursor: pointer;
            display: block;
            margin-left: auto;
            margin-right: auto;
        }


            .btn:hover {
                color: aqua;
                background-color: black;
            }

        .picklist {
            margin-top: 10px;
            width: 50%;
            height: 35px;
            border-radius: 5px;
            border: 1px solid gray;
        }

        asp:Image {
            margin: 10px auto;
            display: block;
        }

    </style>
</head>

<body>

    <form id="form1" runat="server">
        
        <div class="studentregistrationform">
            <h1 class="heading1">Online Examination Syatem</h1>
            <br />
            <br />
            <h2 class="heading2">Student Registaration Form</h2>
            <br />
            Enter roll number :
                <asp:TextBox CssClass="thxBox" ID="txtRoll" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            Enter name :
                <asp:TextBox CssClass="thxBox" ID="txtName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            Email :
                <asp:TextBox CssClass="thxBox" ID="txtEmail" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            Mobile :
                <asp:TextBox CssClass="thxBox" ID="txtMobile" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            Select your city :
                <asp:DropDownList CssClass="picklist" ID="ddlCity" runat="server">
                    <asp:ListItem>Nagpur</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Puna</asp:ListItem>
                </asp:DropDownList>
            <br />
            Upload student photo :
                <asp:FileUpload ID="btnImageSelect" runat="server" />
            &nbsp;
                <asp:Button CssClass="btn" ID="btnUploadImage" runat="server" Text="UploadImage" OnClick="btnUploadImage_Click" />
            &nbsp;<br />
            <asp:Image ID="iiCandidatePicture1" runat="server" Height="250px" Width="250px" />
            <br />
            <br />
            <asp:Button CssClass="btn" ID="btnGoToExamPage" runat="server" Text="Go to exam Page" OnClick="btnGoToExamPage_Click" />
            <br />
        </div>
        <!-- view page -->
        <asp:MultiView ID="mvStudentExamination" runat="server" ActiveViewIndex="0">
            <!-- fristview -->
            <asp:View ID="viewStudentProfile" runat="server">
                <div class="viewOne">
                    <h2 class="heading2">Student Profile</h2>
                    <br />
                    <br />
                    <asp:Image ID="iiCandidatePicture2" runat="server" Height="250px" Width="250px" />
                    <br />
                    <br />
                    Name of student :
                        <asp:TextBox CssClass="thxBox" ID="txtNameOut" runat="server"></asp:TextBox>
                    <br />
                    Student email :
                        <asp:TextBox CssClass="thxBox" ID="txtEmailOut1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button CssClass="btn" ID="btnContineuAndNext" runat="server" Text="Contineu and next" OnClick="btnContineuAndNext_Click" />
                    <br />
                </div>
            </asp:View>
            <asp:View ID="viewStudentAccademicDetails" runat="server">
                <div class="viewTwo">
                    <h2 class="heading2">Student Accademic Details</h2>
                    <br />
                    <br />
                    Student email Id :
                        <asp:TextBox CssClass="thxBox" ID="txtEmailOut2" runat="server"></asp:TextBox>
                    <br />
                    Student branch :
                        <asp:DropDownList CssClass="picklist" ID="ddlStudentBranch" runat="server">
                            <asp:ListItem>CSE</asp:ListItem>
                            <asp:ListItem>IT</asp:ListItem>
                            <asp:ListItem>MCA</asp:ListItem>
                        </asp:DropDownList>
                    <br />
                    Collage name :
                        <asp:TextBox CssClass="thxBox" ID="txtCollageName" runat="server"></asp:TextBox>
                    <br />
                    Persantage :
                        <asp:TextBox CssClass="thxBox" ID="txtPersantage" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button CssClass="btn" ID="btnGenrateExam" runat="server" Text="Genrate exam" OnClick="btnGenrateExam_Click" />
                    <br />
                </div>
            </asp:View>
            <asp:View ID="viewWelcomeStudent" runat="server">
                <div class="viewThree">
                    Welcome student :
                        <asp:Label ID="lblStudentNameOut" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    Q1. What does CPU stand for?<br />
                    <asp:RadioButtonList ID="rblQ1" runat="server" OnSelectedIndexChanged="rblQ1_SelectedIndexChanged">
                        <asp:ListItem Value="Central Processing Unit">Central Processing Unit</asp:ListItem>
                        <asp:ListItem Value="Computer Processing Unit">Computer Processing Unit</asp:ListItem>
                        <asp:ListItem Value="Central Programming Unit">Central Programming Unit</asp:ListItem>
                        <asp:ListItem>Computer Program Utility</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ1res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q2. Which of the following is a volatile memory?<br />
                    <asp:RadioButtonList ID="rblQ2" runat="server">
                        <asp:ListItem>ROM</asp:ListItem>
                        <asp:ListItem>Hard Disk</asp:ListItem>
                        <asp:ListItem>RAM</asp:ListItem>
                        <asp:ListItem>Flash Memory</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ2res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q3. What is the time complexity of a binary search algorithm in a sorted array?<br />
                    <asp:RadioButtonList ID="rblQ3" runat="server">
                        <asp:ListItem>O(n)</asp:ListItem>
                        <asp:ListItem>O(log n)</asp:ListItem>
                        <asp:ListItem>O(n log n)</asp:ListItem>
                        <asp:ListItem> O(1)</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ3res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q4. Which of the following is not an operating system?<br />
                    <asp:RadioButtonList ID="rblQ4" runat="server">
                        <asp:ListItem>Linux</asp:ListItem>
                        <asp:ListItem>Windows</asp:ListItem>
                        <asp:ListItem>Oracle</asp:ListItem>
                        <asp:ListItem>macOS</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ4res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q5 In Object-Oriented Programming, which of the following is not a feature?<br />
                    <asp:RadioButtonList ID="rblQ5" runat="server">
                        <asp:ListItem> Encapsulation</asp:ListItem>
                        <asp:ListItem> Inheritance</asp:ListItem>
                        <asp:ListItem>Polymorphism</asp:ListItem>
                        <asp:ListItem>Compilation</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ5res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q6. Which protocol is used to send emails?<br />
                    <asp:RadioButtonList ID="rblQ6" runat="server">
                        <asp:ListItem>HTTP</asp:ListItem>
                        <asp:ListItem>FTP</asp:ListItem>
                        <asp:ListItem>SMTP
                        </asp:ListItem>
                        <asp:ListItem>SNMP</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ6res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q7. Which data structure is used for implementing recursion?<br />
                    <asp:RadioButtonList ID="rblQ7" runat="server">
                        <asp:ListItem>Queue</asp:ListItem>
                        <asp:ListItem>Stack</asp:ListItem>
                        <asp:ListItem>Linked List</asp:ListItem>
                        <asp:ListItem>Array</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ7res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q8. What is the full form of HTML?<br />
                    <asp:RadioButtonList ID="rblQ8" runat="server">
                        <asp:ListItem>HyperText Machine Language</asp:ListItem>
                        <asp:ListItem>Hyper Transfer Markup Language</asp:ListItem>
                        <asp:ListItem>HyperText Markup Language</asp:ListItem>
                        <asp:ListItem>High-Level Text Markup Language</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ8res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q9. Which of the following is not a type of computer network?<br />
                    <asp:RadioButtonList ID="rblQ9" runat="server">
                        <asp:ListItem>LAN</asp:ListItem>
                        <asp:ListItem>MAN</asp:ListItem>
                        <asp:ListItem>WAN</asp:ListItem>
                        <asp:ListItem> SAN</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ9res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q10. Which of the following is an example of a primary key in a relational database?<br />
                    <asp:RadioButtonList ID="rblQ10" runat="server">
                        <asp:ListItem>A unique identifier for a record</asp:ListItem>
                        <asp:ListItem>A duplicate value in a column</asp:ListItem>
                        <asp:ListItem>A foreign key reference</asp:ListItem>
                        <asp:ListItem>A NULL value in a row</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="txtQ10res" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button CssClass="btn" ID="ShowAnswers" runat="server" Text="Show Answers" OnClick="btnShowAnswers_Click" />
                    &nbsp;
                    <asp:Button ID="btnGenrateScoreCard" runat="server" CssClass="btn" OnClick="btnGenrateScoreCard_Click" Text="Genrate score card" />
                    <br />
                </div>
            </asp:View>
            <asp:View ID="viewScoreCard" runat="server">
                <div class="viewFour">
                    <h2 class="heading2">Score Card</h2>
                    <br />
                    <br />
                    Name of student :
                        <asp:Label ID="lblNameOut" runat="server" Text="Label"></asp:Label>
                    <br />
                    Email :
                        <asp:Label ID="lblEmalOut" runat="server" Text="Label"></asp:Label>
                    <br />
                    Collage Name :
                        <asp:Label ID="lblCollageName" runat="server" Text="Label"></asp:Label>
                    <br />
                    Branch :
                        <asp:Label ID="lblBrachOut" runat="server" Text="Label"></asp:Label>
                    <br />
                    Total score :
                        <asp:Label ID="lblTotalScoreOut" runat="server" Text="Label"></asp:Label>
                    <br />
                    Grade is :
                        <asp:Label ID="lblgradeOut" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Button CssClass="btn" ID="btnPrintGrade" runat="server" Text="Print Grade" OnClick="btnPrintGrade_Click" />
                    <br />
                </div>
            </asp:View>
        </asp:MultiView>
    </form>
</body>

</html>
