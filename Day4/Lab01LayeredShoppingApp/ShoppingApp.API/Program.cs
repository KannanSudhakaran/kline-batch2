using Microsoft.EntityFrameworkCore;
using ShoppingApp.BusinessObjects;
using ShoppingApp.EFRepositories;
using ShoppingApp.GenericRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<KlineAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Lab01Connection"));
});

builder.Services.AddScoped<ICatalogItemRepository, CatalogItemEFRepository>();
builder.Services.AddScoped<ICatalogItemBO,CatalogItemBO>();
var app = builder.Build();



using (var scope = app.Services.CreateScope())
{

    var provider = scope.ServiceProvider;
    var dbcontext = provider.GetRequiredService<KlineAppDbContext>();
    DBInitializer.SeedAsync(dbcontext).Wait();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
