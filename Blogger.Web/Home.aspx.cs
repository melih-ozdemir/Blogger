using Blogger.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web
{
    public partial class Home1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString.Count > 0)
            {
                int categoryId = Convert.ToInt32(Request.QueryString["categoryId"]);
                LoadArticles(categoryId);
            }
            else
            {
                LoadArticles();
            }
        }

        private void LoadArticles()
        {
            ArticleService articleService = new ArticleService();
            var articles = articleService.GetAllIsActive();
            rptArticles.DataSource = articles;
            rptArticles.DataBind();
        }

        private void LoadArticles(int categoryId)
        {
            ArticleService articleService = new ArticleService();
            var articles = articleService.GetAllIsActiveByCategory(categoryId);
            rptArticles.DataSource = articles;
            rptArticles.DataBind();
        }
    }
}