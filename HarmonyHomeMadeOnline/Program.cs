using HarmonyHomeMadeOnline.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connection = @"server=(LocalDb)\MSSQLLocalDB);Database=HarmonyHomeMadeOnline;Trusted_Connection=True;ConnectRetryCount=0";

builder.Services.AddDbContext<OnlineContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));
var app = builder.Build();


//services.AddDBcontect


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=LoginPage}/{id?}");

app.Run();
