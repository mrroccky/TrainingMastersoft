using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // acess and show session data inside 
            Label1.Text = (string)Session["emailId"];
            Label2.Text = (string)Session["mobile"];
            //chech the session
            if (Session["emailId"]==null)
            {
                Response.Redirect("Page1.aspx");
            }
            else
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
        }
    }
}