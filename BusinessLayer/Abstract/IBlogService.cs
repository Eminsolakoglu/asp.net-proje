using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog Blog);
		void BlogDelete(Blog Blog);
		void BlogUpdate(Blog Blog);
		List<Blog> GetList();
		Blog GetByID(int id);
		List<Blog> GetBlogListWithCategory();
		
	}
	
}
