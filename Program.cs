using htt_test_case.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
string connection = @"Server=(localdb)\mssqllocaldb;Database=Test_case_db;Trusted_Connection=True;";
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Goods}");


app.Run();
