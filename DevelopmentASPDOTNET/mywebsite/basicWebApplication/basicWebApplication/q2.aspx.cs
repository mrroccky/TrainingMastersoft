﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basicWebApplication
{
    public partial class q2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //access query sring
            Label1.Text = Request.QueryString["email"];
            Label2.Text = Request.QueryString["mobile"];
        }
    }
}