using Core;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IMongoClient>(s =>
    new MongoClient(builder.Configuration.GetValue<string>("StudentStoreDatabaseSettings:ConnectionString")));

builder.Services.AddSingleton<ILibraryDatabaseSettings>(sp => sp.GetRequiredService<IOptions<LibraryDatabaseSettings>>().Value);

builder.Services.Configure<LibraryDatabaseSettings>(builder.Configuration.GetSection(nameof(LibraryDatabaseSettings)));

builder.Services.AddScoped<IBookRepository, BookRepository>();



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
