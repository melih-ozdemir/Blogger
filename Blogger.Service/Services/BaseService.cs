using Blogger.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Service.Services
{
    public class BaseService
    {
        protected BloggerContext BloggerContext { get; private set; }
        public BaseService()
        {
            BloggerContext = new BloggerContext();
        }
    }
}
