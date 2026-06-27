// 1. LOS USING VAN HASTA ARRIBA DEL TODO
using TallerApp.Application;
using TallerApp.Domain;
using TallerApp.Infrastructure;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IOrdenRepository, JsonOrdenRepository>();
builder.Services.AddScoped<OrdenService>();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();