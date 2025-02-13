using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentLockingSystem
{
    public partial class Doccument : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //catching session values whenewer screen gets load 
            try {
                lblName.Text = Session["name"].ToString();
                lblEmail.Text = Session["email"].ToString();
                iiImage.ImageUrl = "~/student-image/" + Session["ImageName"].ToString();
               // btnUpload.Attributes.Add("onclick", "validationCheckedAllowOnlyJpg()");

            } catch(Exception)
            {
                //in case we dont have value in session so simplay redirecting user to registration page (default page)
                Response.Redirect("default.aspx");
            }
           
        }

        protected void btnGoToDawnloadFormPage_Click(object sender, EventArgs e)
        {
            //creating chech so user cant navigate furter before uploading data 
            try
            {
                if (Session["resume-file"].ToString() != "" && Session["degree-fileName"].ToString() != "")
                {
                    //precheck for password so the user enter proper password and we create sessions before navigating user
                    if(txtPassProtectResume.Text  !=null && txtPassProtectDegree.Text != null)
                    {
                        Session["resume-pass"] = txtPassProtectResume.Text;
                        Session["degree-pass"] = txtPassProtectDegree.Text;
                        Response.Redirect("DoccDawnload.aspx");
                    }
                    else
                    {
                        lblError.Text = "Protect files with password 😣";
                        lblError.ForeColor = System.Drawing.Color.Red;
                    }
                    
                }
                else
                {
                    lblError.Text = "Protect files with password 😣";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                //keeping user informed
                Response.Write($"<script language='JavaScript'> alert('Files not found !');</script>");
            }
          
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //onclick of this buton setting user inside resum-file location
            //and creating session 
            try
            {
                if (btnFileBrows.FileName !="" ) // Check if a file is selected
                {
                    string fileName = btnFileBrows.FileName;
                    string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();

                    if (fileExtension == ".pdf") // Allow only PDFs
                    {
                        string savePath = Server.MapPath("~") + "//resum-file//" + fileName;
                        btnFileBrows.SaveAs(savePath);

                        // Store the uploaded file in session
                        Session["resume-file"] = fileName;

                        lblError.Text = fileName + " uploaded successfully! 🥳";
                        lblError.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblError.Text = "Invalid file type! Please upload a PDF file. 😣";
                        lblError.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    lblError.Text = "Please choose a file before uploading. 😣";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                lblError.Text = "Error uploading file! Please try again. 😣";
                lblError.ForeColor = System.Drawing.Color.Red;
            }


            //call to chech pdf was in 
        }

        protected void btnUpload2_Click(object sender, EventArgs e)
        {
            //onclick of this buton setting user inside degree-image location
            //and creating session 
            string fileName = btnFileBrows2.FileName;
            string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
            try
            {
                if (btnFileBrows2.FileName != "" )
                {
                    if (fileExtension == ".jpg")
                {
                    btnFileBrows2.SaveAs(Server.MapPath("~") + "//degree-image//" + btnFileBrows2.FileName);
                    Session["degree-fileName"] = btnFileBrows2.FileName;
                    lblError.Text = btnFileBrows2.FileName + "Picture uploaded Sucessfully 🥳";
                    lblError.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblError.Text = "Error uploading file try file with Jpg extension 😣";
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

            //call to chech pdf was in 
        }
    }
}