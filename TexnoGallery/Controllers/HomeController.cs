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
                SlideImage = db.Slide.ToList(),
                CategoryImage = db.ImageCategory.ToList(),
                BrendPhoto = db.Brend.ToList(),
                CategoryName = db.Category.ToList(),
                productList = db.Product.OrderByDescending(pr => pr.Id).Take(10).ToList(),
            };
            return View(defaultModel);
        }
        public ActionResult SearchPro(string searchText)
        {
            var defaultModel = new DefaultViewModel
            {
                ProImage = db.ProductImage.Where(pr => pr.BaseImg == 1 && pr.Product.SubCategory.Name.Contains(searchText)).Take(10).ToList(),
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