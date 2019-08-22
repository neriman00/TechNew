using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TexnoGallery.ViewModel.Default;
using TexnoGallery.Models;
namespace TexnoGallery.Controllers
{
    public class HomeController : Controller
    {
        TexnoGalleryEntities db = new TexnoGalleryEntities();
        
        public ActionResult Index()
        {
            var defaultModel = new DefaultViewModel
            {
                SlideImage = db.Slide.ToList()
            };
            return View(defaultModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}