using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoleBaseLogin
{
    public partial class Manager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = "<b><font color=Brown>" + "WELCOME: " + "</font>" + "<b><font color=Red>" + Session["UserName"] + "</font>";
        }
    }
}