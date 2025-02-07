using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//

namespace basicWebApplication
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //addition of two numbers
            int a, b, c;
            //check textbox controll 
            if (txtNum1.Text == "" || txtNum2.Text =="")
            {
                Response.Write("<script language='JavaScript'>alert('enter number properly')</script>");

            }
            else
            {
                //initializing variable with value
                a = int.Parse(txtNum1.Text);
                b = int.Parse(txtNum2.Text);
                //performing plus opration
                c = a + b;
                // all type of numerical and decimal data is to be converted into string by usint ToString()
                txtResult.Text = c.ToString();
                //clearing data from text box controll
                txtNum1.Text = "";
                txtNum2.Text = "";
                //setting focus on textbox 1 
                txtNum1.Focus();
                //change the backgraud color
                //
                txtResult.BackColor = System.Drawing.Color.Azure;
            }
            



        }

        protected void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {

        }
    }
}