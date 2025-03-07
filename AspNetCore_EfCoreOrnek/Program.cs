using AspNetCore_EfCoreOrnek.Models.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<KullaniciDbContext>(opt =>
{
    //opt.UseSqlServer("connectionstring buraya");
    // connection sgringlerimizi appsettings.json dosyasının içerisinede yazabiliriz. (önerilen)
    opt.UseSqlServer(builder.Configuration.GetConnectionString("kullaniciCon")); // appsettings.json dosyasındaki connectionstring düğümü
});

var app = builder.Build();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
