using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
		public IActionResult Index(Writer p)
		{
            p.WriterStatus = true;
            p.WriterAbout = "Deneme Teset";
            wm.WriterAdd(p);
			return RedirectToAction("Index","Blog");
		}
		
	}
}
