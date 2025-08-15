using Lab02MiddlewareAndDepedencyInjections.Extensions;
using Lab02MiddlewareAndDepedencyInjections.Middlewares;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//IEnumerable<string> names = new string[] { "Alice", "Bob", "Charlie" };
//names.HowdyKline();

//app.UseMiddleware<KlineMiddleware>();

app.UseMyKlineMiddleware();

app.MapGet("/", () => "Hello World!");

app.Run();
