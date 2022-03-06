using Blogger.Domain.Models;
using Dapper;
using System.Linq;

namespace Blogger.Service.Services
{
    public class ManagerService : BaseService
    {
        public Manager Authenticate(string email, string password)
        {
            string commandText = "Select * from Manager where Email=@email and Password=@pass and IsActive=1";
            Manager result = BloggerContext.SqlConnection.Query<Manager>(commandText, new { @email = email, @pass = password }).FirstOrDefault();
            if (result != null)
                result.Password = null;
            return result;
        }
    }
}
