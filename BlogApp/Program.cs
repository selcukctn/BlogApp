using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<BlogContext>(options =>{
   var config = builder.Configuration;
   var conenctionString = config.GetConnectionString("sql_connection");
   options.UseSqlite(conenctionString);
});

builder.Services.AddScoped<IPostRepository,EfPostRepository>();

var app = builder.Build();

SeedData.TestVerileriniDoldur(app);

app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();