using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternsASP.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly EarnFactory _localEarnFactory;
        private readonly ForeignEarnFactory _foreignEarnFactory;
        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }
        public IActionResult Index(decimal total)
        {


            //factories
           // LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            //ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.20m, 33);

            //products
            var LocalEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            //total
            ViewBag.totalLocal = total + LocalEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);
            return View();
        }
    }
}
