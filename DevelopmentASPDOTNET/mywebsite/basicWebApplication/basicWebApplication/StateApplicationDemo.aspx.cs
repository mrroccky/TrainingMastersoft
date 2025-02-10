using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class StateApplicationDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //number of visitor count
            int count = 0;
            if (Application["visit"] != null) //chechk the url
            {
                count = int.Parse(Application["visit"].ToString());

            }
            //increment count 
            count = count + 1;
            //update application variable
            Application["visit"] = count;
            //print number of visitor
            Label1.Text = count.ToString();

            //sesion ---- data between multiple page
            //queryString to pass data between page using url
            //
        }
    }
}