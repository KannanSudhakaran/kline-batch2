using Lab03ActionsAndFilters.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDataService,DataService>();
var app = builder.Build();


app.UseStaticFiles();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=Index}/{id?}"
);

app.Run();
