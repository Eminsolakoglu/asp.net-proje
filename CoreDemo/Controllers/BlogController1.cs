using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController1 : Controller
    {
        IBlogDal _blogdal;
        public IActionResult Index()
        {
            return View();
        }
    }
}
