
using Lab01ConsoleEFCore.Data;
using Lab01ConsoleEFCore.Domain;
using Microsoft.EntityFrameworkCore;

//CaseStudy1();
//CaseStudy2();

//CaseStudy3();
//CaseStudy4();



//CaseStudy5();

CaseStudy6();

void CaseStudy6()
{


    var db = new KlineAppDbContext();
    var customerWithOrders= db.Customers
                              .Include(c=>c.Orders)
                              .ToList();

    foreach (var customer in customerWithOrders)
    {
        Console.WriteLine(customer);

        foreach (var order in customer.Orders)
        {
            Console.WriteLine(order);
        }

    
    }

}

void CaseStudy5()
{

    var c1 = new Customer { FullName="Kline Singapore" };
    var order1 = new Order
    {
        TotalAmount = 100,
        Description="Order1"
    };
    var order2 = new Order
    {
        TotalAmount = 200,
        Description = "Order2"
    };
    c1.Orders.Add(order1);
    c1.Orders.Add(order2);

    var db = new KlineAppDbContext();
    db.Customers.Add(c1);
    db.SaveChanges();
    Console.WriteLine("end of castudy5");
}

void CaseStudy4()
{
    //Iqueryable get translated to sql query
    var db = new KlineAppDbContext();
    var lastNames = db.Customers
                   .ToList()
                  .Where(c => c.FullName.ToLower().Split()[1].Contains("h"));
                  

    foreach (var name in lastNames)
        Console.WriteLine(name);

}

void CaseStudy3()
{

    var db = new KlineAppDbContext();
    var customerNamesWithY = db.Customers
                               .ToList()
                              .Where((c) => c.FullName.Contains("Y"));

    Customer c = customerNamesWithY.FirstOrDefault();

    Console.WriteLine(c);


}

void CaseStudy2()
{

    var db = new KlineAppDbContext();
    //IQueryable(sql expression)
    var customers = db.Customers;//deferred execution,lazy,delayed

    //IEnumerable(in memory)
    //var customerList = customers.ToList();//immediate execution

    // Console.WriteLine(customerList);

    foreach (var customer in customers)
    {
        Console.WriteLine(customer);
    }

}

void CaseStudy1()
{

    var c1 = new Customer
    {
        FullName = "Norizuan Abaha"
    };
    var c2 = new Customer
    {
        FullName = "Yee Hui"
    };
    var c3 = new Customer
    {
        FullName = "Ping Hui"
    };

    var db = new KlineAppDbContext();
    db.Customers.Add(c1);
    db.Customers.Add(c2);
    db.Customers.Add(c3);

    db.SaveChanges();
    Console.WriteLine("end of casestudy1");

}