using Hangfire;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//hangfire di services
var hangfireCon = builder.Configuration.GetConnectionString("Hangfirelocalconnection");
builder.Services.AddHangfire(config => config.UseSqlServerStorage(hangfireCon));
builder.Services.AddHangfireServer();

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

//hangifre dashboard
app.UseHangfireDashboard("/hangfire");

app.Run();
