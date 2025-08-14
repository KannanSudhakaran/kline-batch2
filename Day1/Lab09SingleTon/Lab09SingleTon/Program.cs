

using Lab09SingleTon;

ServiceRegistry reg1 =  ServiceRegistry.CreateInstance();
ServiceRegistry reg2 =  ServiceRegistry.CreateInstance();

reg1.DoLookup();
reg2.DoLookup();

Console.WriteLine(reg1.GetHashCode()) ;
Console.WriteLine(reg2.GetHashCode());
