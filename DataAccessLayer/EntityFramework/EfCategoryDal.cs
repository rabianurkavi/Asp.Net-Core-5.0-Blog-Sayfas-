using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
        Context context = new Context();
        public int GetBlogCount()
        {
            var result = context.Blogs.Include(x => x.Category).Count();
            return result;
        }
    }
}
