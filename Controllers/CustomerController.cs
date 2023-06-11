using AdvertisementsAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdvertisementsAPI.Controllers
{
    [Route("api/[controller]/[action]")]

    public class CustomerController : Controller
    {

        private readonly AdvertisementsDBContext _advertisementsDBContext;

        public CustomerController(AdvertisementsDBContext advertisementsDBContext)
        {
            _advertisementsDBContext = advertisementsDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Customer customer)
        {
            try
            {
                Customer EL = new Customer();
                if (customer.CustomerName != null)
                {
                    EL.CustomerName = customer.CustomerName;
                    EL.CustomerAddress = customer.CustomerAddress;
                    _advertisementsDBContext.Customers.Add(EL);
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

        public IActionResult login(string name)
        {

            try
            {
                var customer = _advertisementsDBContext.Customers.Where(x => x.CustomerName == name).FirstOrDefaultAsync();
                if (customer == null)
                {
                    return View();
                }
                else
                {
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
