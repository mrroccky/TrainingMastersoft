using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExaminationPortal
{

    public partial class _default : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            mvStudentExamination.ActiveViewIndex = -1;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnUploadImage_Click(object sender, EventArgs e)
        {
            //upload image inside student-image folder
            try
            {
                btnImageSelect.SaveAs(Server.MapPath("~") + "//student-image//" + btnImageSelect.FileName);
                //perform logic for uploading image image will be stored inside student-image fold
                iiCandidatePicture1.ImageUrl = "~/student-image/" + btnImageSelect.FileName;
                //creating session because we need information in other context
                Session["ImageName"] = btnImageSelect.FileName;
            }catch(Exception)
            {
                Response.Write("<script language='JavaScript'> alert('Upload Picture properly');</script>");
            }
           
        }

        protected void btnGoToExamPage_Click(object sender, EventArgs e)
        {
            try
            {
                //chechking all feilds before taking student to next stage
                if (txtName !=null && txtEmail != null && txtRoll !=null && ddlCity !=null && txtMobile !=null && Session["ImageName"] !=null)
                {
                    //this sessions are required in other context at view 4 to display all the information
                    Session["name"] = txtName.Text;
                    Session["email"] = txtEmail.Text;
                    Session["rollNumber"] = txtRoll.Text;
                    Session["city"] = ddlCity.Text;
                    Session["mobile"] = txtMobile.Text;
                    //setting multipageview indes so the next stage is visible
                    mvStudentExamination.ActiveViewIndex = 0;
                   //setting information to text feilds using sessions it conn be done in page_load but we are working on single page so wee need to write it hare 
                    txtNameOut.Text = (string)Session["name"];
                    txtEmailOut1.Text = (string)Session["email"];
                    //hare we are setting visblity of student form as null so user can focus only on view one 
                    Response.Write("<style type='text/css'> .studentregistrationform{display:none} </style>");
                    iiCandidatePicture2.ImageUrl = "~/student-image/" + (string)Session["ImageName"];

                }
                else
                {
                    //there might be some fields are with null value so giving alrert to user
                    Response.Write("<script language='JavaScript'> alert('All feilds are mandetory!');</script>");
                }
               
                
            }catch(Exception)
            {
                //there might be some unknown erorr  we are getting ie server erroer or network will  be catched in this block so the code not broke
                Response.Write("<script language='JavaScript'> alert('All feilds are mandetory!');</script>");
            }
          
        }

        protected void btnContineuAndNext_Click(object sender, EventArgs e)
        {
            // in this context setting form page visiblity ans non 
            Response.Write("<style type='text/css'> .studentregistrationform{display:none} </style>");
            //setting value in email textbox
            txtEmailOut2.Text = (string)Session["email"];
            //visiblity of multivew index setting as one  
            mvStudentExamination.ActiveViewIndex = 1;
        }

        protected void btnGenrateExam_Click(object sender, EventArgs e)
        {
            //information form needs to null in this context also thats why we are setting this responce 
            Response.Write("<style type='text/css'> .studentregistrationform{display:none} </style>");

            mvStudentExamination.ActiveViewIndex = 2;
            //ddlStudentBranch,clgname,persantage
            //if(ddlStudentBranch.Text)
            Session["branch"] = ddlStudentBranch.Text;
            Session["collageName"] = txtCollageName.Text;
            Session["persantage"] = txtPersantage.Text;
            lblStudentNameOut.Text = (string)Session["name"]; 
        }

        protected void btnGenrateScoreCard_Click(object sender, EventArgs e)
        {
            //information form needs to null in this context also thats why we are setting this responce 
            Response.Write("<style type='text/css'> .studentregistrationform{display:none} </style>");
            //giving values to all lable using session
            lblNameOut.Text = (string)Session["name"];
            lblEmalOut.Text = (string)Session["email"];
            lblCollageName.Text = (string)Session["collageName"];
            lblBrachOut.Text = (string)Session["branch"];
            //total grade
            //all corect answers are stored in this array
            int[] answers = { 0, 2, 1, 2, 3, 2, 1, 2, 3, 0 };
            //storing all quastion rediobutton list inside this list
            RadioButtonList[] questionLists = { rblQ1, rblQ2, rblQ3, rblQ4, rblQ5, rblQ6, rblQ7, rblQ8, rblQ9, rblQ10 };
            int totalScore = 0;

            // Check if all questions are answered
            for (int i = 0; i < questionLists.Length; i++)
            {
                if (questionLists[i].SelectedIndex == -1)
                {
                    //if any quastion was missing then showing alert to student
                    Response.Write("<script>alert('All questions are mandatory to solve');</script>");
                    mvStudentExamination.ActiveViewIndex = 2;
                    return;
                }
                else
                {
                    //redirecting user to next view
                    mvStudentExamination.ActiveViewIndex = 3;
                }
            }

            // Calculate total score
            for (int i = 0; i < questionLists.Length; i++)
            {
                //chechking that selected answer and the corrext answer value are same or not
                //if same then insrising total with +1 mark
                if (questionLists[i].SelectedIndex == answers[i])
                {
                    totalScore++;
                }
            }
            //showing result and his information to student 
            //total score function get peramiter as int we are passing value to do furter calculation
            lblTotalScoreOut.Text = totalScore.ToString();
            lblgradeOut.Text= calcGrade(totalScore);

            //Response.Write($"<script>alert('Your Score: {totalScore}/10');</script>");

        }

        protected void btnPrintGrade_Click(object sender, EventArgs e)
        {

        }

        protected void rblQ1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //in this function we are performing logic for grade and returning as string
        public string calcGrade(int totalScore)
        {
            if (totalScore != null)
            {
                if (totalScore >= 8)
                {
                    return "GRADE A";
                }else if(totalScore>=6 && totalScore < 8)
                {
                    return "GRADE B";
                }
                else
                {
                    return "FAIL";
                }
            }
            else
            {
                return "NULL VAL";
            }
        }

        protected void btnShowAnswers_Click(object sender, EventArgs e)
        {
            Response.Write("<style type='text/css'> .studentregistrationform{display:none} </style>");

            string[] answersText = {
                "Central Processing Unit",  // Q1 - Index 0
                "RAM",                      // Q2 - Index 2
                "O(log n)",                 // Q3 - Index 1
                "Oracle",                   // Q4 - Index 2
                "Compilation",              // Q5 - Index 3
                "SMTP",                     // Q6 - Index 2
                "Stack",                    // Q7 - Index 1
                "HyperText Markup Language",// Q8 - Index 2
                "SAN",                      // Q9 - Index 3
                "A unique identifier for a record" // Q10 - Index 0
            };
            TextBox[] txtbox = { txtQ1res, txtQ2res, txtQ3res, txtQ4res, txtQ5res, txtQ6res, txtQ7res, txtQ8res, txtQ9res, txtQ10res };
            RadioButtonList[] questionLists = { rblQ1, rblQ2, rblQ3, rblQ4, rblQ5, rblQ6, rblQ7, rblQ8, rblQ9, rblQ10 };
            try
            {
                for (int i = 0; i < questionLists.Length; i++)
                {
                    if (questionLists[i].SelectedIndex == -1)
                    {
                        //if any quastion was missing then showing alert to student
                        Response.Write("<script>alert('All questions are mandatory to solve befor clicking Answers button');</script>");
                        mvStudentExamination.ActiveViewIndex = 2;
                        return;
                    }
                    else
                    {
                        txtbox[0].Text = answersText[0];
                        txtbox[1].Text = answersText[1];
                        txtbox[2].Text = answersText[2];
                        txtbox[3].Text = answersText[3];
                        txtbox[4].Text = answersText[4];
                        txtbox[5].Text = answersText[5];
                        txtbox[6].Text = answersText[6];
                        txtbox[7].Text = answersText[7];
                        txtbox[8].Text = answersText[8];
                        txtbox[9].Text = answersText[9];
                        //redirecting user to next view
                        mvStudentExamination.ActiveViewIndex = 2;
                    }
                }
            }
            catch (Exception)
            {
                mvStudentExamination.ActiveViewIndex = 2;
                Response.Write("<script>alert('Solave All Questions to chech correct answers !');</script>");
            }
        
            //txtbox[10].Text = answersText[10];
           // mvStudentExamination.ActiveViewIndex = 2;
        }
    }

}
