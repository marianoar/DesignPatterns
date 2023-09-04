using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsASP.Models.ViewModels;
using DesignPatternsASP.Strategies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPatternsASP.Controllers
{
    public class BeerController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = d.BeerId,
                                                   Name = d.Name,
                                                   Style = d.Style
                                               };
            return View("Index", beers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            GetBrandsData();
            return View();
        }
        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVM)
        {
            if (!ModelState.IsValid)
            {
                GetBrandsData();

                return View("Add", beerVM);
            }

            var context = beerVM.BrandId == null ? 
                                        new BeerContext(new BeerWidthBrandStrategy()):
                                        new BeerContext(new BeerStrategy());

            context.Add(beerVM, _unitOfWork);

            return RedirectToAction("Index");
        }
        #region Helpers
        private void GetBrandsData()
        {
            var brands = _unitOfWork.Beers.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }

        #endregion
    }
}
