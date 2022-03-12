using Blogger.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web
{
    public partial class User : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadRecentsPost();
        }

        private void LoadRecentsPost()
        {
            ArticleService articleService = new ArticleService();
            var articles = articleService.GetAllIsActiveLastThreePost();
            lstRecentsPost.DataSource = articles;
            lstRecentsPost.DataBind();
        }

        private void LoadCategories()
        {
            CategoryService categoryService = new CategoryService();
            var categories = categoryService.GetAllIsActive();
            rptCategories.DataSource = categories;
            rptCategories.DataBind();
        }
    }
}