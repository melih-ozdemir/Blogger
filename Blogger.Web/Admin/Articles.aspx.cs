using Blogger.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web.Admin
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadArticles();
        }

        private void LoadArticles()
        {
            ArticleService articleService = new ArticleService();
            var list = articleService.GetAll();
            rptArticles.DataSource = list;
            rptArticles.DataBind();
        }

        protected void rptArticles_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if(e.CommandName == "Delete")
            {
                int articleId = Convert.ToInt32(e.CommandArgument);
                ArticleService articleService = new ArticleService();
                articleService.Delete(articleId);
            }
            LoadArticles();
        }
    }
}