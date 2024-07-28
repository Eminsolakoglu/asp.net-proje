﻿using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;

namespace CoreDemo.Controllers
{
    public class BlogController1 : Controller
    {
         BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogDetails(int id)
        {
            return View();
        }

    }
}
