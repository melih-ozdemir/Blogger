using Blogger.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web
{
    public partial class ReadArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var articleId = Convert.ToInt32(Request.QueryString["id"]);
            LoadArticle(articleId);
        }

        private void LoadArticle(int id)
        {
            ArticleService articleService = new ArticleService();
            var article = articleService.Get(id);
            imgCoverImage.ImageUrl = $"/Uploads/{article.CoverImage}";
            lblCategoryName.Text = article.CategoryName;
            lblTitle.Text = article.Title;
            lblCreationTime.Text = article.CreationTime.ToString();
            lblContent.Text = article.Content;
        }
    }
}