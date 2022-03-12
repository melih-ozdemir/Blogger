using System.Data.SqlClient;

namespace Blogger.Domain.Context
{
    public class BloggerContext
    {
        private readonly string _connectionString;
        public SqlConnection SqlConnection { get; private set; }
        public BloggerContext()
        {
            _connectionString = @"Data source=DESKTOP-6NIP90O\SQLEXPRESS; Initial Catalog=MyBlog; Integrated Security=True";
            SqlConnection = new SqlConnection(_connectionString);
        }
    }
}
