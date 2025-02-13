using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExamModule
{
    public partial class TestScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     
            try
            {
                //keeping button hidden im giving dynamic value to set button visiblity
                btnSubmit.Visible = Convert.ToBoolean(ViewState["allSolved"]);
                //checking that we have proper name inside session if not we are not allowing user to take exam 
                if (Session["name"].ToString() != "")
                {
                    lblStudentName.Text = Session["name"].ToString();
                    lblStudentEmail.Text = Session["email"].ToString();
                    //showing image 
                    iiCandidateImage.ImageUrl = "~/student-image/" + Session["ImageName"].ToString();
                    lblNameOfCollage.Text = Session["collageName"].ToString();
                    lblStudentBranch.Text = Session["branch"].ToString();
                    lblStudentSemester.Text = Session["semister"].ToString();
                }
                else
                {
                    lblError.Text = "Error: Please add your details. We regret that we cannot move you forward. 😣";
                    lblError.ForeColor = System.Drawing.Color.Red;
                    //incase we dont have user information redirecting to default page
                    Response.Redirect("default.aspx");
                }
            }
            catch (Exception)
            {
                //incase we dont have user information redirecting to default page
               lblError.Text = "Error: Please add your details. We regret that we cannot move you forward. 😣";
               lblError.ForeColor = System.Drawing.Color.Red;
               Response.Redirect("default.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //making array of answer buttons so wi will loop them and check it has value or it is null
            RadioButtonList[] rblAns = { rblA1, rblA2, rblA3, rblA4, rblA5, rblA6, rblA7, rblA8, rblA9};
            //created list of checked indexes so we push user selected answers inside clickedIndex variable
            List<int> clickedIndex = new List<int>();
            //boolean at creation having value as true
            //why? because this button will activated only if user has attempted all answers
            bool allAnswered = true;
            //once again checking all answers are attempted
            for (int i = 0; i < rblAns.Length; i++)
            {
                if (rblAns[i].SelectedIndex == -1)  
                {
                    lblError.Text = "Please solve all questions.";
                    allAnswered = false;
                    break; //if single question not attempted 
                }
                else
                {
                    clickedIndex.Add(rblAns[i].SelectedIndex);
                }
            }

            if (allAnswered)
            {
                //Example: Checking answers (Assuming correct answers are stored in an array)
                int[] correctAnswers = { 1, 2, 0, 1, 3, 2, 0, 1, 2 }; // Example correct answers

                int score = 0;
                for (int i = 0; i < rblAns.Length; i++)
                {
                    //looping trhough rediobutton  list and checking selected index was equal to correct answers array 
                    if (rblAns[i].SelectedIndex == correctAnswers[i])
                    {
                        //if selected and answer was same then  assigning +1 value to score
                        score++;
                    }
                }

                lblError.Text = $"Your score: {score}/{rblAns.Length}";
                lblResultBox.Visible = true;
                lblScore.Text = $"{score}/{rblAns.Length}";
                lblGrade.Text = grade(score);
            }

        }
        //this function will give grade as string 
        string grade(int score)
        {
            if (score >= 8)
            {
                return "A";
            }else if(score >= 5 && score < 8)
            {
                return "B";
            }
            else
            {
                return "Fail";
            }
        }
        protected void btnans1_Click(object sender, EventArgs e)
        {
            //setting exam pannel value onclick of all 10 buttons same logic was applied for all 
            MultiViewExamPannel.ActiveViewIndex = 0;
            
        }

        protected void rblA1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //in case picklist having selected index then setting buttn backgraund colour
            btnans1.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans2_Click(object sender, EventArgs e)
        {
            MultiViewExamPannel.ActiveViewIndex = 1;
           
        }

        protected void rblA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans2.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans3_Click(object sender, EventArgs e)
        {
            MultiViewExamPannel.ActiveViewIndex = 2;
           
        }

        protected void rblA3_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans3.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans4_Click(object sender, EventArgs e)
        {
            MultiViewExamPannel.ActiveViewIndex = 3;
            
        }

        protected void rblA4_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans4.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans5_Click(object sender, EventArgs e)
        {
            MultiViewExamPannel.ActiveViewIndex = 4;
          
        }

        protected void rblA5_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans5.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans6_Click(object sender, EventArgs e)
        {
            MultiViewExamPannel.ActiveViewIndex = 5;
           
        }

        protected void rblA6_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans6.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans7_Click(object sender, EventArgs e)
        {
            MultiViewExamPannel.ActiveViewIndex = 6;
           
        }

        protected void rblA7_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans7.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans8_Click(object sender, EventArgs e)
        {
            MultiViewExamPannel.ActiveViewIndex = 7;
           
        }

        protected void rblA8_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans8.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans9_Click(object sender, EventArgs e)
        {
            MultiViewExamPannel.ActiveViewIndex = 8;
            
        }

        protected void rblA9_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans9.BackColor = System.Drawing.Color.Green;
        }

        protected void btnans10_Click(object sender, EventArgs e)
        {
           
            MultiViewExamPannel.ActiveViewIndex = 9;
            //int case all question was atempted setting visiblity of button as true else keeping it unvisible
            btnSubmit.Visible = checkAllSolved();
            //assigninng values to viewState so we use it even if pare gate reloaded 
            ViewState["allSolved"]=checkAllSolved();


        }

        protected void rblA10_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnans10.BackColor = System.Drawing.Color.Green;

        }
        //checking all redio buttons was selected ro not accordingly sending boolian value to keep button visiblity dynamic
        bool checkAllSolved()
        {
            RadioButtonList[] rblAns = { rblA1, rblA2, rblA3, rblA4, rblA5, rblA6, rblA7, rblA8, rblA9, rblA10 };

            foreach (RadioButtonList rbl in rblAns)
            {
                if (rbl.SelectedIndex == -1)  // If any question is unanswered
                {
                    return false; // if not  answered
                }
            }

            return true; // All questions are answered
        }

    }
}