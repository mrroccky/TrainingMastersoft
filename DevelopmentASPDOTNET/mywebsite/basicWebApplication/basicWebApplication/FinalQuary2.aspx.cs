using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class FinalQuary2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["email"];
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FinalQuary3.aspx?mobile=" + TextBox1.Text+ "&email"+Label1.Text);
        }
    }
}