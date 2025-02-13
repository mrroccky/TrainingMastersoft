<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestScreen.aspx.cs" Inherits="OnlineExamModule.TestScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .exam-header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding-bottom: 10px;
        }

        h2 {
            text-align: center;
        }

        .header-left {
            flex: 1;
        }

        .header-right {
            display: flex;
            align-items: center;
        }

        .details {
            text-align: left;
            margin-right: 20px;
        }

        .image {
            width: 170px;
            height: 200px;
            border: 2px solid darkcyan;
        }

        .exam-container {
            display: flex;
            justify-content: space-between;
            width: 100%;
        }

        .multi-view {
            width: 90%;
            padding: 20px;
        }

        .submit-btn {
            position: fixed;
            bottom: 20px;
            left: 50%;
            transform: translateX(-50%);
            padding: 10px;
            border-radius: 16px;
            background-color: darkred;
            color: white;
            border: none;
        }

            .submit-btn:hover {
                color: black;
            }

        .button-panel {
            padding-top: 3%;
            display: grid;
            grid-template-columns: repeat(3, 1fr);
            gap: 10px;
            justify-content: center;
        }

        .num-btn {
            width: 100%;
            padding: 10px;
        }

        .error-message {
            color: red;
            font-size: 18px;
            display: block;
            margin-top: 3px;
        }

        .result-container {
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            background: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 4px 10px rgba(0, 0, 0, 0.3);
            text-align: center;
            width: 300px;
        }

        .result-heading {
            font-size: 24px;
            font-weight: bold;
            text-transform: uppercase;
        }

        .score-label {
            font-size: 18px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <asp:Label  ID="lblResultBox" runat="server" class="result-container" Visible="False">
        <h2 class="result-heading">RESULT</h2>
        <p class="score-label">Score:
            <asp:Label ID="lblScore" runat="server" Text="0"></asp:Label></p>
        <p class="score-label">Grade:
            <asp:Label ID="lblGrade" runat="server" Text="0"></asp:Label></p>
    </asp:Label>

    <form id="form1" runat="server">
        <div class="exam-header">
            <div class="header-left">
                <h2>Online Exam Module</h2>
                <div class="college-name">
                    <h2>
                        <asp:Label ID="lblNameOfCollage" runat="server" Text="Label"></asp:Label></h2>

                </div>
            </div>
            <div class="header-right">
                <div class="details">
                    <p>
                        <strong>Name:</strong>
                        <asp:Label ID="lblStudentName" runat="server" Text="Label"></asp:Label>
                    </p>
                    <p>
                        <strong>Email:</strong>
                        <asp:Label ID="lblStudentEmail" runat="server" Text="Label"></asp:Label>
                    </p>
                    <p>
                        <strong>Branch:</strong>
                        <asp:Label ID="lblStudentBranch" runat="server" Text="Label"></asp:Label>
                    </p>
                    <p>
                        <strong>Semester:</strong>
                        <asp:Label ID="lblStudentSemester" runat="server" Text="Label"></asp:Label>
                    </p>
                </div>
                <div class="image">
                    <asp:Image ID="iiCandidateImage" runat="server" Height="200px" Width="170px" />
                </div>
            </div>
        </div>
        <hr />
        <div class="exam-container">
            <div class="multi-view">
                <label for="txtEmailCheck">

                    <asp:Label ID="lblError" runat="server" CssClass="error-message"></asp:Label>

                </label>
                <br />
                <asp:MultiView ID="MultiViewExamPannel" runat="server" ActiveViewIndex="0">
                    <asp:View ID="View1" runat="server">
                        <asp:Label ID="lblQ1" runat="server" Text="1. What is the default access modifier for a class in C#?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA1" runat="server" OnSelectedIndexChanged="rblA1_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) Public</asp:ListItem>
                            <asp:ListItem>b) Private</asp:ListItem>
                            <asp:ListItem>c) Internal</asp:ListItem>
                            <asp:ListItem>d) Protected</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <asp:Label ID="lblQ2" runat="server" Text="2. Which keyword is used to define a method in C#?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA2" runat="server" OnSelectedIndexChanged="rblA2_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) function</asp:ListItem>
                            <asp:ListItem>b) define</asp:ListItem>
                            <asp:ListItem>c) method</asp:ListItem>
                            <asp:ListItem>d) void</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View3" runat="server">
                        <asp:Label ID="lblQ3" runat="server" Text="3. What is the base class for all .NET classes?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA3" runat="server" OnSelectedIndexChanged="rblA3_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) System.Object</asp:ListItem>
                            <asp:ListItem>b) System.Base</asp:ListItem>
                            <asp:ListItem>c) System.Parent</asp:ListItem>
                            <asp:ListItem>d) System.Root</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View4" runat="server">
                        <asp:Label ID="lblQ4" runat="server" Text="4. What is the size of an int in C#?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA4" runat="server" OnSelectedIndexChanged="rblA4_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) 2 bytes</asp:ListItem>
                            <asp:ListItem>b) 4 bytes</asp:ListItem>
                            <asp:ListItem>c) 8 bytes</asp:ListItem>
                            <asp:ListItem>d) 16 bytes</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View5" runat="server">
                        <asp:Label ID="lblQ5" runat="server" Text="5. Which keyword is used to inherit a class in C#?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA5" runat="server" OnSelectedIndexChanged="rblA5_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) inherit</asp:ListItem>
                            <asp:ListItem>b) base</asp:ListItem>
                            <asp:ListItem>c) extends</asp:ListItem>
                            <asp:ListItem>d) :</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View6" runat="server">
                        <asp:Label ID="lblQ6" runat="server" Text="6. Which access modifier allows a class to be accessed only within the same assembly?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA6" runat="server" OnSelectedIndexChanged="rblA6_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) Public</asp:ListItem>
                            <asp:ListItem>b) Private</asp:ListItem>
                            <asp:ListItem>c) Internal</asp:ListItem>
                            <asp:ListItem>d) Protected</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View7" runat="server">
                        <asp:Label ID="lblQ7" runat="server" Text="7. What is the purpose of the 'using' statement in C#?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA7" runat="server" OnSelectedIndexChanged="rblA7_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) Import namespaces</asp:ListItem>
                            <asp:ListItem>b) Dispose objects</asp:ListItem>
                            <asp:ListItem>c) Both a and b</asp:ListItem>
                            <asp:ListItem>d) None of the above</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View8" runat="server">
                        <asp:Label ID="lblQ8" runat="server" Text="8. Which type is used for handling exceptions in C#?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA8" runat="server" OnSelectedIndexChanged="rblA8_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) Error</asp:ListItem>
                            <asp:ListItem>b) Exception</asp:ListItem>
                            <asp:ListItem>c) Throwable</asp:ListItem>
                            <asp:ListItem>d) Catchable</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View9" runat="server">
                        <asp:Label ID="lblQ9" runat="server" Text="9. Which collection type maintains key-value pairs in C#?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA9" runat="server" OnSelectedIndexChanged="rblA9_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) List</asp:ListItem>
                            <asp:ListItem>b) Dictionary</asp:ListItem>
                            <asp:ListItem>c) Array</asp:ListItem>
                            <asp:ListItem>d) Stack</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                    <asp:View ID="View10" runat="server">
                        <asp:Label ID="lblQ10" runat="server" Text="10. What is the default value of a bool in C#?"></asp:Label>
                        <br />
                        <asp:RadioButtonList ID="rblA10" runat="server" OnSelectedIndexChanged="rblA10_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>a) true</asp:ListItem>
                            <asp:ListItem>b) false</asp:ListItem>
                            <asp:ListItem>c) null</asp:ListItem>
                            <asp:ListItem>d) 0</asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:View>
                </asp:MultiView>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit Score" class="submit-btn" OnClick="btnSubmit_Click" />
            </div>

            <div class="button-panel">
                <asp:Button ID="btnans1" runat="server" Text="1" class="num-btn" OnClick="btnans1_Click" />
                <asp:Button ID="btnans2" runat="server" Text="2" class="num-btn" OnClick="btnans2_Click" />
                <asp:Button ID="btnans3" runat="server" Text="3" class="num-btn" OnClick="btnans3_Click" />
                <asp:Button ID="btnans4" runat="server" Text="4" class="num-btn" OnClick="btnans4_Click" />
                <asp:Button ID="btnans5" runat="server" Text="5" class="num-btn" OnClick="btnans5_Click" />
                <asp:Button ID="btnans6" runat="server" Text="6" class="num-btn" OnClick="btnans6_Click" />
                <asp:Button ID="btnans7" runat="server" Text="7" class="num-btn" OnClick="btnans7_Click" />
                <asp:Button ID="btnans8" runat="server" Text="8" class="num-btn" OnClick="btnans8_Click" />
                <asp:Button ID="btnans9" runat="server" Text="9" class="num-btn" OnClick="btnans9_Click" />
                <asp:Button ID="btnans10" runat="server" Text="10" class="num-btn" OnClick="btnans10_Click" />
            </div>
        </div>
    </form>

</body>
</html>
