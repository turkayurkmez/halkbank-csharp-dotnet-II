
var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConsole();

builder.Services.AddControllersWithViews();



var app = builder.Build();

app.MapControllerRoute("default", pattern: "{controller=AnaSayfa}/{action=Giris}/{id?}");


app.Run();
