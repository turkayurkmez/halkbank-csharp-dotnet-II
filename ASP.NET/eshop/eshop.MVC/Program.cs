using AutoMapper;
using eshop.DataAccess.DataContext;
using eshop.DataAccess.Repositories;
using eshop.Services;
using eshop.Services.MapperProfiles;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

//IIS ya da appsettings veya launchsettings
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, EFProductRepository>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, EFCategoryRepository>();
builder.Services.AddScoped<IUserService, UserService>();


builder.Services.AddAutoMapper(typeof(MapperProfiler));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = "/users/login";
                    option.ReturnUrlParameter = "gidilecekUrl";
                    option.AccessDeniedPath = "/users/accessdenied";
                });


builder.Services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(5));

var connectionString = builder.Configuration.GetConnectionString("db");

builder.Services.AddDbContext<EshopDbContext>(option => option.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute("paginate", "Page{page}", defaults: new { controller = "Home", action = "Index", page = 1 });


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
