using AwidServer.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var clients = "_OriginsClients";
// Add services to the container.

builder.Services.AddDbContext<AwidContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AwidDB")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: clients,
        policy =>
        {
            policy.WithOrigins("http://127.0.0.1:5173");
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(clients);

app.UseAuthorization();

app.MapControllers();

app.Run();
