using Project.Repoitory.Implementations;
using Project.Repoitory.Interfaces;
using Simple_project_using_pattern.Data;
using Simple_project_using_pattern.Interface;
using Simple_project_using_pattern.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Register the service with its interface
builder.Services.AddTransient<IUserTestService, UserTestService>();
builder.Services.AddTransient<IUserTestRepository, UserTestRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();                                      
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();

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