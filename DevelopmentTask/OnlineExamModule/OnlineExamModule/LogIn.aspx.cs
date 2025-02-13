using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExamModule
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click1(object sender, EventArgs e)
        {
            try
            {
                //checking that user having right credentials to move forward
                if(Session["email"].ToString() == txtEmailCheck.Text  && Session["password"].ToString() == txtPassCheck.Text)
                {
                    // is user is authenticated using credentials moving to exam page
                    Response.Redirect("Exam.aspx");
                }
                else
                {
                    //showing erro using lable for user convience
                    lblError.Text = "Incorrect Credentials 🤭";
                }
            }
            catch (Exception){
                //incase other error to keep user engage giving another update for try again
                lblError.Text = "Credentials Credenttials Not Match tray again!";
            }
           
        }
    }
}