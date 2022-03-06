using Blogger.Domain.Models;
using Blogger.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogger.Web.Admin
{
    public partial class CreateCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString.Count > 0)
                {
                    var categoryId = Convert.ToInt32(Request.QueryString["id"]);
                    GetCategory(categoryId);
                }
            }
        }

        private void GetCategory(int id)
        {
            CategoryService categoryService = new CategoryService();
            var category = categoryService.GetById(id);
            chkIsActive.Checked = category.IsActive;
            txtName.Text = category.Name;
            hdnId.Value = category.Id.ToString();
        }

        protected void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsActive.Checked)
            {
                chkIsActive.Text = " Aktif";
            }
            else
            {
                chkIsActive.Text = " Pasif";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.Name = txtName.Text;
                category.IsActive = chkIsActive.Checked;
                CategoryService categoryService = new CategoryService();
                if (string.IsNullOrWhiteSpace(hdnId.Value))
                {
                    categoryService.Create(category);
                }
                else
                {
                    category.Id = Convert.ToInt32(hdnId.Value);
                    categoryService.Update(category);
                }
                txtName.Text = string.Empty;
                pnlSuccess.Visible = true;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                pnlError.Visible = true;
            }
            finally
            {
                Response.Redirect("/Admin/Categories.aspx");
                //Hata olsa da olmasa da çalışır.
            }
        }
    }
}