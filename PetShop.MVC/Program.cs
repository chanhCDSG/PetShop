using PetShop.Models;
using PetShop.MVC.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddHttpClient<IPetService, IPetService>(c =>
    c.BaseAddress = new Uri($"http://localhost:40080/")
);
builder.Services.AddScoped<IPetService, PetService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//app.MapControllerRoute(
//    name: "Pets",
//    pattern: "{controller=Pet}/{action=Pets}/{id?}"
//    );
app.MapDefaultControllerRoute();

app.Run();
