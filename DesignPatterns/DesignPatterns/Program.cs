// See https://aka.ms/new-console-template for more information
using DesignPatterns.BuilderPattern;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.Singleton;
using DesignPatterns.StrategyPattern;
using DesignPatterns.UnitOfWorkPattern;


var builder = new PreparedAlcoholicDrinkConcreteBuilder();

builder.AddIngredients("Tequila");
builder.SetAlcohol(1);
builder.Mix();
builder.Rest(500);

var preparedDrink = builder.GetPreparedDrink();

Console.WriteLine(preparedDrink.Result);
Console.ReadKey();

// Ahora con el agregado del Director

Director director = new Director(builder);

director.PrepararMargerita();
preparedDrink = builder.GetPreparedDrink();
Console.WriteLine(preparedDrink.Result);

director.PrepararPiñaColada();
preparedDrink = builder.GetPreparedDrink();
Console.WriteLine(preparedDrink.Result);
Console.ReadKey();


#region Strategy
//var context = new Context(new CarStrategy());
//context.Run();

//context.Strategy = new BikeStrategy();
//context.Run();

//context.Strategy = new BicycleStrategy();
//context.Run();

//Console.ReadKey();

#endregion

# region UnitOfWork

//using (var context = new DesignPatternsContext())
//{
//    var unitOfWork = new UnitOfWork(context);

//    var beers = unitOfWork.Beers;

//    var beer = new Beer();
//    beer.Name = "Norte";
//    beer.Style = "Porter";

//    beers.Add(beer);

//    var brands = unitOfWork.Brands;
//    var brand = new Brand();
//    brand.Name = "Salta";

//    brands.Add(brand);

//    unitOfWork.Save();

//}

#endregion
#region Repository Pattern
//using (var context = new DesignPatternsContext())
//{


//    var beerRepository = new Repository<Beer>(context);

//    var beer = new Beer()
//    {
//        Name = "Palermo",
//        Style = "Premium"
//    };

//    beerRepository.Add(beer);
//    beerRepository.Save();

//    foreach (var b in beerRepository.Get())
//    {
//        Console.WriteLine($"{b.Name} - {b.Style}");
//    }

//    var brandRepository = new Repository<Brand>(context);
//    Brand brand = new Brand();
//    brand.Name = "Corona";

//    brandRepository.Add(brand);
//    brandRepository.Save();

//    foreach (var b in brandRepository.Get())
//    {
//        Console.WriteLine($"{b.Name}");
//    }
//    Console.ReadLine();
//}
#endregion

#region EntityFramework example
//using (var context = new DesignPatternsContext())
//{
//    var list = context.Beers.ToList();

//    foreach( var beer in list)
//    {
//        Console.WriteLine(beer.Name + " - " + beer.Style);
//    }
//    Console.ReadLine();
//}
#endregion

#region Primera parte

//Console.WriteLine("Hello, World!");

//var singleton = Singleton.Instance;

//var log = Log.Instance;

//log.Save("Prueba");

//var a = Singleton.Instance;
//var b = Singleton.Instance;

////verifico si es el mismo objeto
//Console.WriteLine(a == b);

//Console.WriteLine(" ---- Factory Patterns ---- ");

//// no puedo crear un objeto de la clase abstracta, pero si de sus hijos
//SaleFactory storeSaleFactory = new StoreSaleFactory(10);

//SaleFactory internetSaleFactory = new InternetSaleFactory(5);

//ISale saleA = storeSaleFactory.GetSale();
//saleA.Sell(100);

//ISale saleB = internetSaleFactory.GetSale();
//saleB.Sell(100);
#endregion
