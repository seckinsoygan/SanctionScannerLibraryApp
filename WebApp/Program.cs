using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Shared;
using Entities;
using FluentValidation;
using FluentValidation.AspNetCore;
using WebApp.Mapping;
using WebApp.Models.ViewModels;
using WebApp.ValidationRules.BookLendValidationRules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IValidator<LendBookViewModel>, LendBookValidator>();
builder.Services.AddTransient<IValidator<Book>, AddBookValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<AppDbContext>();

builder.Services.AddScoped<IBookService, BookManager>();
builder.Services.AddScoped<IBookDal, EfBookDal>();

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

builder.Services.AddLogging(x =>
{
    x.ClearProviders();
    x.SetMinimumLevel(LogLevel.Debug);
    x.AddDebug();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Book}/{action=Index}/{id?}");

app.Run();
