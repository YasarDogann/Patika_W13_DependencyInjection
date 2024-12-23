using patika_w13_DependencyInjection.Interfaces;
using patika_w13_DependencyInjection.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Default bir öðretmen oluþtur ve DI container'a kaydet
builder.Services.AddSingleton<ITeacher>(new Teacher
{
    FirstName = "Mauro",
    LastName = "Icardi"
}); 



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
