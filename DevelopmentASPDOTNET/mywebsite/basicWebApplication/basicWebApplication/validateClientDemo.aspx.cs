using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class validateClientDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //implement button event  of javascript
            btnSubmit.Attributes.Add("onClick", "javascrept:return ValidationCheck()");
            Response.Write("page Success");


        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}