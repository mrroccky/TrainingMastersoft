using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class City : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //insert new city
            DropDownList1.Items.Add(TextBox1.Text);
            //
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index change event is index change
            //TextBox2.Text= DropDownList1.Text;
            //Match dropdown list element
            if(DropDownList1.SelectedIndex == 1)
            {
                TextBox2.Text = "Welcome to pune User";
            }
            else
            {
                TextBox2.Text = "invalid";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //dropdown list clear element
            DropDownList1.Items.Clear();
        }
    }
}