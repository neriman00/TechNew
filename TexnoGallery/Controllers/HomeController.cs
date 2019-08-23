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
           Product selectedProduct = db.Product.FirstOrDefault();
            ViewBag.listpro = db.ProductImage.Select(pr => pr.Product.Name).Distinct().ToList();
            var defaultModel = new DefaultViewModel
            {
                SlideImage = db.Slide.ToList(),
                CategoryImage = db.ImageCategory.ToList(),
                BrendPhoto = db.Brend.ToList(),
                CategoryName = db.Category.ToList(),
                productList = db.Product.OrderByDescending(pr => pr.Id).Take(10).ToList(),
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