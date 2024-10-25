using BlogApp.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<BlogContex>(options =>{
   var config = builder.Configuration;
   var conenctionString = config.GetConnectionString("sql_connection");
   options.UseSqlite(conenctionString);
});


var app = builder.Build();

SeedData.TestVerileriniDoldur(app);



app.MapDefaultControllerRoute();

app.Run();