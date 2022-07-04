using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentaRide.Webpages
{
    public partial class AdminDashBoard : System.Web.UI.Page
    {
        String name;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = (String)(Session["ses"]);
            lbl_admin.Text = name;

        }
    }
}