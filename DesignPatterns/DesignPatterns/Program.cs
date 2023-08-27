// See https://aka.ms/new-console-template for more information
using DesignPatterns.FactoryPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.Singleton;

using (var context = new DesignPatternsContext())
{
    BeerRepository beerRepository = new BeerRepository(context);
    var beer = new Beer();
    beer.Name = "Jever";
    beer.Style = "Strong";

    beerRepository.Add(beer);
    beerRepository.Save();

    foreach (var b in beerRepository.Get())
    {
        Console.WriteLine(b.Name + " - " + b.Style);
    }
    Console.ReadLine();

}

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
