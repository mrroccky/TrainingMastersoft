using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class ViewSateDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Store Data in view State
            ViewState["name"] = TextBox1.Text;
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //printing data inside lable
            Label1.Text = ViewState["name"].ToString();
        }
    }
}