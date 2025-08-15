using Lab02MiddlewareAndDepedencyInjections.Extensions;
using Lab02MiddlewareAndDepedencyInjections.Middlewares;
using Lab02MiddlewareAndDepedencyInjections.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IEmailService, AmazonSES>();
builder.Services.AddTransient<IEmailService, AmazonSES>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

//IEnumerable<string> names = new string[] { "Alice", "Bob", "Charlie" };
//names.HowdyKline();

//app.UseMiddleware<KlineMiddleware>();

app.UseMyKlineMiddleware();

//app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();
//{controller=Home}/{action=Index}/{id?}

app.Run();
