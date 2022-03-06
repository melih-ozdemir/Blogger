using Blogger.Domain.Models;
using Blogger.Service.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web.Admin
{
    public partial class CreateArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    int articleId = Convert.ToInt32(Request.QueryString["id"]);
                    GetArticle(articleId);
                }
                LoadCategories();
            }
        }


        private void GetArticle(int id)
        {
            ArticleService articleService = new ArticleService();
            var article = articleService.Get(id);
            txtTitle.Text = article.Title;
            drpCategories.SelectedValue = article.CategoryId.ToString();
            txtContent.Text = article.Content;
            txtSummary.Text = article.Summary;
            hdnId.Value = article.Id.ToString();
            imgCoverImage.ImageUrl = $"../Uploads/{article.CoverImage}";
            imgCoverImage.Visible = true;
            chkIsActive.Checked = article.IsActive;
        }

        private void LoadCategories()
        {
            CategoryService categoryService = new CategoryService();
            var list = categoryService.GetAllIsActive();
            drpCategories.DataValueField = "Id";
            drpCategories.DataTextField = "Name";
            drpCategories.DataSource = list;
            drpCategories.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ArticleService articleService = new ArticleService();
            Article article = new Article();
            article.CreationTime = DateTime.Now;
            if (!string.IsNullOrWhiteSpace(hdnId.Value))
            {
                var articleId = Convert.ToInt32(hdnId.Value);
                article = articleService.Get(articleId);
            }
            article.CategoryId = Convert.ToInt32(drpCategories.SelectedValue);
            article.Content = txtContent.Text;
            article.Summary = txtSummary.Text;
            article.Title = txtTitle.Text;
            article.IsActive = chkIsActive.Checked;
            if (flCoverImage.HasFile)
            {
                var fileName = flCoverImage.FileName;
                var extension = new FileInfo(fileName).Extension;
                var newFileName = $"{Guid.NewGuid()}{extension}";
                var filePath = $"{Server.MapPath("~/Uploads/")}{newFileName}";
                flCoverImage.SaveAs(filePath);
                article.CoverImage = newFileName;
            }
            if (!string.IsNullOrWhiteSpace(hdnId.Value))
            {
                articleService.Update(article);
            }
            else
            {
                articleService.Create(article);
            }
        }
    }
}