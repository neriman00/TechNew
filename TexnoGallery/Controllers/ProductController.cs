using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TexnoGallery.ViewModel.Default;
using TexnoGallery.Models;
namespace TexnoGallery.Controllers
{
    public class ProductController : Controller
    {
        TexnoGalleryEntities db = new TexnoGalleryEntities();
        // GET: Product
        public ActionResult Product()
        {
            var defaultModel = new DefaultViewModel
            {
                CategoryName = db.Category.ToList(),
                SubCategoryName=db.SubCategory.ToList()
            };
            return View();
        }
    }
}