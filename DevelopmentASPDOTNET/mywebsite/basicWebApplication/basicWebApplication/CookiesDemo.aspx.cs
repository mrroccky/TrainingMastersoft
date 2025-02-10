using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class CookiesDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //creating cookies  
            Response.Cookies["name"].Value = TextBox1.Text;
            //expire cookies in one minutes
            Response.Cookies["name"].Expires = DateTime.Now.AddMinutes(1);
            Label1.Text = "Cookies Created";
            TextBox1.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //get cookies data ;
            if (Request.Cookies["name"].Value == null)
            {
                TextBox2.Text = "Cookies Not Found";
            }
            else
            {
                TextBox2.Text = Request.Cookies["name"].Value;
            }
           
        }
    }
}