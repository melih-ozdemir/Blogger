using Blogger.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            CategoryService categoryService = new CategoryService();
            var list = categoryService.GetAll();
            rptCategories.DataSource = list;
            rptCategories.DataBind();
        }

        protected void rptCategories_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "Delete")
            {
                var categoryId = Convert.ToInt32(e.CommandArgument);
                new CategoryService().Delete(categoryId);
            }

            //Response.Redirect("/Admin/Categories.aspx");
            LoadCategories();
        }
    }
}