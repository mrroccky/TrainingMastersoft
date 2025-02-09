using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;

namespace ExaminationPortal
{
    public partial class Assignment2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlSelectBranch.Items.Clear();

            if (ddlDegree.SelectedValue == "UG")
            {
                ddlSelectBranch.Items.Add("B.Tech");
                ddlSelectBranch.Items.Add("B.E.");
                ddlSelectBranch.Items.Add("B.A.");
                ddlSelectBranch.Items.Add("B.Com");
            }
            else if (ddlDegree.SelectedValue == "PG")
            {
                ddlSelectBranch.Items.Add("M.Tech");
                ddlSelectBranch.Items.Add("M.Sc");
                ddlSelectBranch.Items.Add("MCA");
                ddlSelectBranch.Items.Add("M.Com");
            }

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            ArrayList imagesArray = new ArrayList();
            try
            {
                FileUpload1.SaveAs(Server.MapPath("~") + "//student-image//" + FileUpload1.FileName);

                imagesArray.Add(FileUpload1.FileName);
                Session["imagesArray"] = imagesArray;
                for(int i= 0; i < imagesArray.Count; i++)
                {
                    ddlSelectPic.Items.Add(imagesArray[i].ToString());
                }
               
                //perform logic for uploading image image will be stored inside student-image fold
                //lblimageName.ImageUrl = "~/student-image/" + btnImageSelect.FileName;
                //creating session because we need information in other context
                //Session["ImageName"] = btnImageSelect.FileName;
            }
            catch (Exception)
            {
                Response.Write("<script language='JavaScript'> alert('Upload Picture properly');</script>");
            }
        }

        protected void ddlSelectPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string urlpath;
            urlpath = ddlSelectPic.SelectedValue;
            iiCandidateImage.ImageUrl ="~/student-image/"+ urlpath;
            lblimageName.Text = urlpath;
            Session["currentImageUrlPath"] = "~/student-image/" + urlpath;
            //TextBox1.Text=ddlSelectPic.Text;
        }

        protected void btnDisplayNextPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("NextPageImage.aspx");
        }
    }
}