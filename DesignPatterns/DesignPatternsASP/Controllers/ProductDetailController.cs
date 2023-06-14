using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternsASP.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            //factories
            LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);

            ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.20m, 33);

            //products
            var LocalEarn = localEarnFactory.GetEarn();
            var foreignEarn = foreignEarnFactory.GetEarn();

            //total
            ViewBag.totalLocal = total + LocalEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);
            return View();
        }
    }
}
