using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExaminationPortal
{
    public partial class NextPageImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            iipicture.ImageUrl = (string)Session["currentImageUrlPath"];
        }
    }
}