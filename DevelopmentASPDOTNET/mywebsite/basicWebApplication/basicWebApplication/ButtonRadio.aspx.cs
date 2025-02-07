using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class ButtonRadio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RadioButtonList1.Items.Add(TextBox1.Text);
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 1)
            {
                TextBox1.Text = "This Is Amazing City Pune";
            }
            else
            {
                TextBox1.Text = "invalid Selection";
            }
        }
    }
}