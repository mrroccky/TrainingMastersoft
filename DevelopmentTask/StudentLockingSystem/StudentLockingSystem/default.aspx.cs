using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentLockingSystem
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //we need textfeild value as today date as page get load 
            txtDate.Text = (string)DateTime.Now.ToString("dd/MM/yyyy");
            ViewState["ImageName"] = false;
        }


        protected void btnUpload_Click(object sender, EventArgs e)
        {


            string fileName = btnBrowseImage.FileName;
            string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
            try
            {
                if (btnBrowseImage.FileName != "")
                {
                    if (fileExtension == ".jpg")
                    {
                        ViewState["ImageName"] = true;
                        btnBrowseImage.SaveAs(Server.MapPath("~") + "//student-image//" + btnBrowseImage.FileName);
                        Session["ImageName"] = btnBrowseImage.FileName;
                        lblError.Text = btnBrowseImage.FileName + "uploaded Sucessfully 🥳";
                        lblError.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblError.Text = "Error uploading file try file with jpg extension 😣";
                        lblError.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    lblError.Text = "Please Chose file!. 😣";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                lblError.Text = "Error uploading file try again 😣";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {

            try
            {
                
                //check that nnothing will be kept empty before redirecting to login page 
                if (txtName.Text != "" && txtEmail.Text != "" && txtMobile.Text != "" && txtPassword.Text != "" && txtDate.Text != "" && ViewState["ImageName"].ToString() !="false" )
                {
                    //creating session and asigning user input for further checks and use   
                    //its wrong approach to set password value before hashing but it will workin demo project
                    Session["name"] = txtName.Text;
                    Session["moile"] = txtMobile.Text;
                    Session["email"] = txtEmail.Text;
                    Session["password"] = txtPassword.Text;
                    Session["date"] = txtDate.Text;
                    //if all condition are good then redirecting to login page
                    Response.Redirect("LogInPage.aspx");
                }
                else
                {
                    lblError.Text = "Fields Cant be empty !😣";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch(Exception)
            {
                lblError.Text = "Error try again !😣";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
            

        }
    }
}