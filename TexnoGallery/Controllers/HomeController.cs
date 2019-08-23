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
        TexnoGalleryEntities1 db = new TexnoGalleryEntities1();
        
        public ActionResult Index()
        {
            var defaultModel = new DefaultViewModel
            {
                SlideImage = db.Slide.ToList(),
                BrendPhoto=db.Brend.ToList()


            };
            return View(defaultModel);
        }

        public ActionResult About()
        {
            var defaultModel = new DefaultViewModel
            {
                aboutTech = db.AboutUs.Find(1)

            };
            return View(defaultModel);
        }
        public ActionResult Contact()
        {
            var defaultModel = new DefaultViewModel
            {
                contactTech = db.Contact.Find(1)
            };
            return View(defaultModel);
        }
    }
}