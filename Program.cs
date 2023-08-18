var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
// mvc yapısını dahil ettik
// mvc
app.UseStaticFiles();// static dosyaların aktif edilmesi middleware

app.UseRouting();

// {controller=Home}/{action=Index}/id?
//  app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
