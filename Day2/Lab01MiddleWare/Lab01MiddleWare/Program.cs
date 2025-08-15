var builder = WebApplication.CreateBuilder(args);


//all DI container objects are registered here
var app = builder.Build();
//middleware pipeline is built here


app.Use(async (context,nextMiddlware) => {

    Console.WriteLine("preprocessing for Middleware1");
    await nextMiddlware();
    Console.WriteLine("postprocessing for Middleware1");

});

app.Use(async (context, nextMiddlware) => {
    Console.WriteLine("preprocessing for Middleware2");
    await nextMiddlware();
    Console.WriteLine("postprocessing for Middleware2");

});


app.MapGet("/", () => "Hello World!");

//app.Run(async(context) => { 

//  await  context.Response.WriteAsync("<h1>Inside Run1</h1>");
//});
//app.Run(async (context) => {

//    await context.Response.WriteAsync("<h1>Inside Run2</h1>");
//});

app.MapGet("/howdy",() =>  Results.Content("<h1>Howdy Kline!</h1>","text/html"));

app.Run();
