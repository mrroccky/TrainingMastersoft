using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create session 
            Session["emailId"] = TextBox1.Text; //session cannot show its data in web url it used to secure data transfer 
            //session is genraly used to transfer secure data
             //getting mobile creating session
              //getting mobile creating session
            Session["mobile"] = TextBox2.Text;
            //visit to next page
            Response.Redirect("Page2.aspx");
        }
    }
}