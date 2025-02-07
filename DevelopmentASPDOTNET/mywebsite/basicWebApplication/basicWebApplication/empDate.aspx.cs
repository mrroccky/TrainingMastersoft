using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class empDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //display curent date and time 
            Label1.Text = DateTime.Now.ToString();
            //display only date
            Label1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //dispaly current month MMMM -> full month name , MM->numberical ,MMM ->feb 
            Label1.Text = DateTime.Now.ToString("MMMM");
            //display year
            Label1.Text = DateTime.Now.ToString("yyyy");
            //how to incrise month 
            Label1.Text = DateTime.Now.AddMonths(2).ToString("MMMM");
            Label1.Text = DateTime.Now.AddYears(2).ToString("yyyy");
            //add days 
            Label1.Text = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy");

        }
    }
}