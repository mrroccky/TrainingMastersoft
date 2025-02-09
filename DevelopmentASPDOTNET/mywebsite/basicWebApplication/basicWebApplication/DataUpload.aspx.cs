using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class DataUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //data upload concept
            FileUpload1.SaveAs(Server.MapPath("~") +"//pictures//" +FileUpload1.FileName); // ~/pictures/a.jpg
            //preview image
            //property of image (url)
            Image1.ImageUrl = "~/pictures/" + FileUpload1.FileName;
            //display name of picture 
            Label1.Text = FileUpload1.FileName;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //upload doccument
            FileUpload1.SaveAs(Server.MapPath("~") + "//resume//" + FileUpload1.FileName);
            //dawnold doccument
            HyperLink1.Text= "Dawnload Document";
            HyperLink1.NavigateUrl= "~/resume/" +FileUpload1.FileName;
        }
    }
}