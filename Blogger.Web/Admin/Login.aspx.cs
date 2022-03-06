using Blogger.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            ManagerService managerService = new ManagerService();
            var manager = managerService.Authenticate(email, password);
            if(manager != null)
            {
                //Başarılı giriş
                Session.Add("username", manager.Name + " " + manager.Surname);
                Session.Add("userId", manager.Id);
                Session.Add("userEmail", manager.Email);
                Session.Add("userPhoneNumber", manager.PhoneNumber);
                Response.Redirect("/Admin/CreateCategory.aspx");
            }
            else
            {
                lblErrorMessage.Text = "Kullanıcı email ya da parola bilgisi hatalıdır";
                lblErrorMessage.Visible = true;
            }
        }
    }
}