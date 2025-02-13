using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExamModule
{
    public partial class Exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // checking that user came from right path if user coming directly to exam page withaut having their name and credentials
                // if user came using invalid way not aloving to give exam 
                if(Session["name"].ToString() != "")
                {
                    // if we have user credential 
                    lblName.Text = Session["name"].ToString();
                    lblEmail.Text = Session["email"].ToString();  
                }
               
            }
            catch(Exception)
            {
                //any case if weare having trouble serving user moving to default page
                //so he.she will add proper credential and information and came again
                Response.Redirect("default.aspx");
            }
            
        }

        protected void btnTestStart_Click(object sender, EventArgs e)
        {
            try
            {
                //we collect all informations inside session if user entered data inside field
                if (txtCollageName.Text != "" && txtBranchName.Text != "" && ddlSemister.Text != "")
                {
                    Session["collageName"] = txtCollageName.Text;
                    Session["branch"] = txtBranchName.Text;
                    Session["semister"] = ddlSemister.Text;
                    //if evrything wass good then moving user forword to test screen so he will foccus on exam 
                    Response.Redirect("TestScreen.aspx");
                }
                else
                {
                    //showing erro inside lable in red colour
                    lblError.Text = "Fields Cant be empty! 😣";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                //showing erro inside lable in red colour
                lblError.Text = "Fields Cant be empty Try agian! 😣";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}