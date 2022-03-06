using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web.Admin
{
    public partial class _Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("/Admin/Login.aspx");
            }
            lblUserName.Text = Session["username"]?.ToString();
        }

        protected void hypLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/Admin/Login.aspx");
        }
    }
}