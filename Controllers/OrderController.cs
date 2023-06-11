using AdvertisementsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdvertisementsAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {
        private readonly AdvertisementsDBContext _advertisementsDBContext;

        public OrderController(AdvertisementsDBContext advertisementsDBContext)
        {
            _advertisementsDBContext = advertisementsDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult AddOrder()
        {
            return View();
        }


        [HttpPost]
        public  async Task<IActionResult> AddOrder(Order order)
        {
            try
            {  
                var proId = _advertisementsDBContext.Productdetails.Where(x=> x.ProductId == order.ProductId).FirstOrDefault();
                Order ord = new Order();
                if (order.OrderId == 0)
                {

                    ord.ProductId = proId.ProductId;
                    ord.ItemNumber = order.ItemNumber;
                    ord.Quality = order.Quality;
                    ord.Price = order.Price;

                    _advertisementsDBContext.Orders.Add(order);
                    _advertisementsDBContext.SaveChanges();
                    return View();

                }
            }
            catch (Exception)
            {

                throw;
            }
            return View();

        }
    }
}
