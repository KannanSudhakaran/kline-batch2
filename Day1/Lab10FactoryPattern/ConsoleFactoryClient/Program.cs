using FactoryCoreLibrary.Factory;
using FactoryCoreLibrary.Products;

var factory = new AutoMobileFactory();
IAutoMobile auto = factory.Make(AutoMobileType.Tesla);
auto.Start();
auto.Stop();
Console.WriteLine(auto.GetType()) ;
