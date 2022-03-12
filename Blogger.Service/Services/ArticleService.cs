using Blogger.Domain.Models;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace Blogger.Service.Services
{
    public class ArticleService : BaseService
    {
        public Article Create(Article article)
        {
            string commandText = "Insert into Article(CategoryId,Title,Content,Summary,CoverImage,ManagerId,CreationTime,ReadCount,LikeCount,IsActive) Values(@CategoryId,@Title,@Content,@Summary,@CoverImage,@ManagerId,@CreationTime,@ReadCount,@LikeCount,@IsActive) select @@IDENTITY";
            article.Id = BloggerContext.SqlConnection.Query<int>(commandText, article).Single();
            return article;
        }

        public List<Article> GetAll()
        {
            string commandText = "Select a.*,c.Name as CategoryName from Article a inner join Category c on a.CategoryId = c.Id ";
            var result = BloggerContext.SqlConnection.Query<Article>(commandText).ToList();
            return result;
        }

        public List<Article> GetAllIsActive()
        {
            string commandText = "Select a.*,c.Name as CategoryName from Article a inner join Category c on a.CategoryId = c.Id where a.IsActive=1";
            var result = BloggerContext.SqlConnection.Query<Article>(commandText).ToList();
            return result;
        }

        public List<Article> GetAllIsActiveByCategory(int categoryId)
        {
            string commandText = "Select a.*,c.Name as CategoryName from Article a inner join Category c on a.CategoryId = c.Id where a.IsActive=1 and a.CategoryId=@catId";
            var result = BloggerContext.SqlConnection.Query<Article>(commandText, new { @catId = categoryId }).ToList();
            return result;
        }

        public List<Article> GetAllIsActiveLastThreePost()
        {
            string commandText = "Select top 3 a.*,c.Name as CategoryName from Article a inner join Category c on a.CategoryId = c.Id where a.IsActive = 1 order by Id desc";
            var result = BloggerContext.SqlConnection.Query<Article>(commandText).ToList();
            return result;
        }
        public Article Get(int id)
        {
            string commandText = "Select a.*,c.Name as CategoryName from Article a inner join Category c on a.CategoryId = c.Id where a.Id = @id";
            var result = BloggerContext.SqlConnection.Query<Article>(commandText, new { @id = id }).Single();
            return result;
        }

        public Article Update(Article article)
        {
            string commandText = "Update Article set CategoryId = @CategoryId,Title =@Title ,Content=@Content,Summary=@Summary,CoverImage=@CoverImage,ReadCount=@ReadCount,LikeCount=@LikeCount,IsActive = @IsActive where Id=@Id";
            BloggerContext.SqlConnection.Query(commandText, article);
            return article;
        }

        public void Delete(int id)
        {
            string commandText = "Delete from Article Where Id=@id";
            BloggerContext.SqlConnection.Query(commandText, new { @id = id });
        }
    }
}
