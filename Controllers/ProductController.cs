using AdvertisementsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdvertisementsAPI.Controllers
{
    [Route("api/[controller]/[action]")]

    public class ProductController : Controller
    {

        private readonly AdvertisementsDBContext _advertisementsDBContext;

        public ProductController(AdvertisementsDBContext advertisementsDBContext)
        {
            _advertisementsDBContext = advertisementsDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(Productdetail productdetail)
        {
            try
            {
                Productdetail Pro = new Productdetail();
                if (productdetail.ProductName != null)
                {

                    Pro.ProductName = productdetail.ProductName;
                    Pro.ProductPrice = productdetail.ProductPrice;
                    Pro.ProductCategory = productdetail.ProductCategory;

                    _advertisementsDBContext.Productdetails.Add(Pro);
                    _advertisementsDBContext.SaveChanges();
                    return View();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return View("AddProduct");

        }

        private IQueryable<Productdetail> MapProducts()
        {
            return from p in _advertisementsDBContext.Productdetails
                   select new Productdetail()

                   {
                       ProductId = p.ProductId,
                       ProductName = p.ProductName,
                       ProductPrice = p.ProductPrice,
                       ProductCategory = p.ProductCategory
                   };
        }
        [HttpGet]
        public IEnumerable<Productdetail> GetProducts()
        {
            return MapProducts().AsEnumerable();
        }

        //[HttpGet]
        //public async Task<IActionResult> GetProducts()
        //{
        //  Productdetail list = new Productdetail();

        //    return View(list);
        //}


    }
}
