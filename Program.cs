using Microsoft.EntityFrameworkCore;
using TodoListApi.Db;
using TodoListApi.Repositories;
using TodoListApi.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var services = builder.Services;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TodoContext>(options =>
        options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
services.AddScoped<ITodoRepository, TodoRepository>();
services.AddScoped<ITodoService, TodoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if(app.Environment.IsDevelopment())
{
    var serviceProvider = new ServiceCollection()
        .AddDbContext<TodoContext>(options =>
        {
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            options.EnableServiceProviderCaching(false);
        })
        .BuildServiceProvider();

    using (var scope = serviceProvider.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<TodoContext>();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
