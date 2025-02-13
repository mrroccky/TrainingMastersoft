using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExamModule
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //on pag load adding current date  to date text field
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
                        //setting image inside student folder
                        btnBrowseImage.SaveAs(Server.MapPath("~") + "//student-image//" + btnBrowseImage.FileName);
                        //creating session and assigning value of image file 
                        Session["ImageName"] = btnBrowseImage.FileName;
                        lblError.Text = "Picture uploaded Sucessfully 🥳";
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
                //on click of login button we check if any feild is empty or not
                    if (txtName.Text != "" && txtEmail.Text != "" && txtPassword.Text != "" && txtMobile.Text != "" && txtDate.Text != "" && Session["ImageName"].ToString() != "")
                    {
                    //if all feilds contain data then we move user on login screen and 
                    //whaterver created data we have get added inside session
                        Session["name"] = txtName.Text;
                        Session["email"] = txtEmail.Text;
                        Session["password"] = txtPassword.Text;
                        Session["mobile"] = txtMobile.Text;
                        Session["date"] = txtDate.Text;
                        Response.Redirect("Login.aspx");
                     }
                    else
                    {
                        lblError.Text = "Fields cant be empty🤯";
                    }                     
            }
            catch(Exception)
            {
                lblError.Text = "Error processing data fill all feils 😣";
            }
                       
        }
    }
}