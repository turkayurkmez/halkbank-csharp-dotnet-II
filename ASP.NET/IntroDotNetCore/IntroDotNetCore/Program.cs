
var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConsole();

builder.Services.AddControllersWithViews();



var app = builder.Build();

//app.UseHttpLogging();
app.UseStaticFiles();

app.MapControllerRoute("default", pattern: "{controller=AnaSayfa}/{action=Giris}/{id?}");


app.Run();
