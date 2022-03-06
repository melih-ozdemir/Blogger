using Blogger.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blogger.Service.Services
{
    public class CategoryService : BaseService
    {
        public Category Create(Category category)
        {
            //try
            //{
            BloggerContext.SqlConnection.Open();
            string commandText = "insert into Category(Name,IsActive) values(@name,@isActive) select @@IDENTITY";
            SqlCommand command = new SqlCommand(commandText, BloggerContext.SqlConnection);
            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@isActive", category.IsActive);
            int id = Convert.ToInt32(command.ExecuteScalar());
            category.Id = id;
            BloggerContext.SqlConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            return category;
        }

        public List<Category> GetAll(bool getAll = true)
        {
            BloggerContext.SqlConnection.Open();
            string commandText = "Select Id,Name,IsActive from Category";
            if(getAll == false)
            {
                commandText += " Where IsActive=1";
            }
            SqlCommand command = new SqlCommand(commandText, BloggerContext.SqlConnection);
            var reader = command.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
                categories.Add(category);
            }
            BloggerContext.SqlConnection.Close();
            return categories;
        }

        public List<Category> GetAllIsActive()
        {
            BloggerContext.SqlConnection.Open();
            string commandText = "Select Id,Name,IsActive from Category where IsActive=1";
            SqlCommand command = new SqlCommand(commandText, BloggerContext.SqlConnection);
            var reader = command.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
                categories.Add(category);
            }
            BloggerContext.SqlConnection.Close();
            return categories;
        }

        public Category GetById(int id)
        {
            BloggerContext.SqlConnection.Open();
            string commandText = "Select Id,Name,IsActive from Category Where Id=@id";
            SqlCommand command = new SqlCommand(commandText, BloggerContext.SqlConnection);
            command.Parameters.AddWithValue("@id", id);
            var reader = command.ExecuteReader();
            Category category = new Category();
            while (reader.Read())
            {
                category = new Category(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));
            }
            BloggerContext.SqlConnection.Close();
            return category;
        }

        public Category Update(Category category)
        {
            BloggerContext.SqlConnection.Open();
            string commandText = "Update Category Set Name=@name,IsActive=@isActive Where Id=@id";
            SqlCommand command = new SqlCommand(commandText, BloggerContext.SqlConnection);
            command.Parameters.AddWithValue("@name", category.Name);
            command.Parameters.AddWithValue("@isActive", category.IsActive);
            command.Parameters.AddWithValue("@id", category.Id);
            command.ExecuteNonQuery();
            BloggerContext.SqlConnection.Close();
            return category;
        }

        public void Delete(int id)
        {
            BloggerContext.SqlConnection.Open();
            string commandText = "Delete from Category Where Id=@id";
            SqlCommand command = new SqlCommand(commandText, BloggerContext.SqlConnection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            BloggerContext.SqlConnection.Close();
        }
    }
}
