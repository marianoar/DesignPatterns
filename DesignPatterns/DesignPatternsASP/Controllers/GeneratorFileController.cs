using DesignPatterns.Repository;
using Microsoft.AspNetCore.Mvc;
using Tools.Generator;

namespace DesignPatternsASP.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private GeneratorConcreteBuilder _generatorConcreteBuilder;
        public GeneratorFileController(IUnitOfWork unitOfWork, GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(x => x.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";

                var director = new GeneratorDirector(_generatorConcreteBuilder);

                if(optionFile == 1)
                {
                    director.CreateSimpleJsonGenerator(content, path);
                }
                else
                {
                    director.CreateSimplePipeGenerator(content, path);
                }

                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();
                return Json("File Created");
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
