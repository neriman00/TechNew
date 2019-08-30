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
        texnoEntities db = new texnoEntities();
        // GET: Product
        public ActionResult ProPage()
        {
            var defaultModel = new DefaultViewModel
            {
                CategoryName = db.Category.ToList(),
                SubCategoryName = db.SubCategory.ToList(),
                productList=db.Product.ToList(),
                ProImage=db.ProductImage.Where(pr=>pr.BaseImg==1).ToList(),
            };
            return View(defaultModel);
        }
        public ActionResult PcTopla()
        {
            return View();
        }
    }
}