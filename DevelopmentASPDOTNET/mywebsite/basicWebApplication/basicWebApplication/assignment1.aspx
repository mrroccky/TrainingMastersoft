<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="assignment1.aspx.cs" Inherits="basicWebApplication.assignment1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Online Examination System<br />
            <br />
            Studen Registaration<br />
            <br />
            Enter Roll Number :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter Name :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Branch :
            <br />
            Ennter Email:&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Enter Mobile :&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Select City
Select City
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
&nbsp; (Nagpur mumbai puna)<br />
            Upload student photo:
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;<asp:Button ID="Button6" runat="server" Text="Upload" />
&nbsp;<br />
            <asp:Image ID="Image2" runat="server" Height="260px" Width="338px" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Go to Exam Page" />
&nbsp;//if user can click this button then display view 1 0&nbsp; view1 index
            <br />
            <br />
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View1" runat="server">
                    Student Profile<br />
                    <br />
                    Name of student :
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    (Automatic)<br /> Student email :
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    &nbsp;(automatic)<br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Continue and Next" />
                    &nbsp; when user this buton then open view 2
                </asp:View>
                <asp:View ID="View2" runat="server">
                    Student Accademic Details<br />
                    <br />
                    Student email id :
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    &nbsp;(Automatic)<br /> Student branch :&nbsp;
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                    &nbsp;(CSE IT MCA) get from user<br /> Collage name :
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    &nbsp;get from user<br /> Persantage :
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    &nbsp;get from iuser<br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Genrate Exam" />
                    &nbsp;if user can click this button then open view 3
                </asp:View>
                <asp:View ID="View3" runat="server">
                    Welcome Student
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    &nbsp;(display Student Name Automatically),<br />
                    <br />
                    Q1. Integer is used to
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>String</asp:ListItem>
                        <asp:ListItem>Number</asp:ListItem>
                        <asp:ListItem>Charector</asp:ListItem>
                        <asp:ListItem>All</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    &nbsp;<br />
                    <br />
                    Q2. Class is a collection of
                    <br />
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                        <asp:ListItem>Array</asp:ListItem>
                        <asp:ListItem>Structure</asp:ListItem>
                        <asp:ListItem>Member and method</asp:ListItem>
                        <asp:ListItem>All</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Q3. make more like this 10<br />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="Genrate score card" />
                    &nbsp; on click of this show view 4 , open view 4 on all question attempt
                </asp:View>
                <asp:View ID="View4" runat="server">
                    Score card<br />
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="271px" Width="382px" />
                    <br />
                    <br />
                    Name of student :
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <br />
                    Email :
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    <br />
                    Branch :
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    <br />
                    Total score:
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    <br />
                    Grade is :
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Button5" runat="server" Text="Print grade card" />
                    &nbsp;total&gt;8 then A if total&gt;5&amp;&amp;&lt;8 then B else fail&nbsp;&nbsp; and window.print()
                </asp:View>
            </asp:MultiView>
            <br />
        </div>
    </form>
</body>
</html>
