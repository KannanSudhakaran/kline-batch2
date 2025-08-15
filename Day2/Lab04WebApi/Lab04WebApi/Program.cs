using Lab04WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICustomerService, CustomerInMemoryService>();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.Run();
