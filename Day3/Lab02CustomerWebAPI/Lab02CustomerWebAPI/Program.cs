using Lab02CustomerWebAPI.Data;
using Lab02CustomerWebAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var loclConnectionString = builder.Configuration.GetConnectionString("KlineLocalDbConnection");

builder.Services.AddDbContext<KlineAppDbContext>(
    (options) =>
    {
        options.UseSqlServer(loclConnectionString);
    }
);

//builder.Services.AddSingleton<ICustomerRepository, CustomerInMemoryRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerEFRepository>();

var app = builder.Build();

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
