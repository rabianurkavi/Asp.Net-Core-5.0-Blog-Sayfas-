using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {

        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.List(x => x.BlogId == id);
        }
        public Blog GetById(int id)
        {
            return _blogDal.Get(x => x.BlogId == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.List();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.List().TakeLast(3).ToList();
        }
        public List<Blog> GetLastBlog()
        {
            return _blogDal.List().TakeLast(1).ToList();
        }


        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.List(x => x.WriterId == id);
        }
        public List<Blog> GetBlogListWithCategoryByWriter(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
