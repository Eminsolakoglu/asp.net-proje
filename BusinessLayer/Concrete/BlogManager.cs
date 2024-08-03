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

        public void BlogAdd(Blog Blog)
        {
            _blogDal.Insert(Blog);
        }

        public void BlogDelete(Blog Blog)
        {
            _blogDal.Delete(Blog);
        }

        public void BlogUpdate(Blog Blog)
        {
            _blogDal.Update(Blog);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetByID(int id)
        {
            return _blogDal.GetByID(id);
        }
        public List<Blog> GetBlogByID(int id) 
        {
            return _blogDal.GetListAll(x=>x.BlogID == id);
        }        

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDal.GetListAll(x=> x.WriterID == id);
		}
	}
}
