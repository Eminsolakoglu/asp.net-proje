using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using EntityLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation;
using FluentValidation.Results;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController1 : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i=id;
            var values=bm.GetBlogByID(id);
            return View(values);
        }
        
        public IActionResult BlogListByWriter()
        {
            var values=bm.GetBlogListByWriter(6);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {   BlogValidator bv=new BlogValidator();
            ValidationResult results=bv.Validate(p);
           
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate= DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 6;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "BlogController1");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
        

    
}
