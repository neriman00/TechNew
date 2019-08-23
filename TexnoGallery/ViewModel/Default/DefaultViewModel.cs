using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TexnoGallery.Models;

namespace TexnoGallery.ViewModel.Default
{

    public class DefaultViewModel
    {
        public List<Slide> SlideImage;
        public List<ImageCategory> CategoryImage;
        public AboutUs aboutTech;
        public Contact contactTech;
        public List<Brend> BrendPhoto;
        public List<Product> productList;
        public List<ProductImage> ProImage; 
        public Product ProductDetail;
        public List<Category> CategoryName;
        public List<SubCategory> SubCategoryName;
    }
}