using Cosmetics_Perfumes.Data;
using Cosmetics_Perfumes.Data.Interfaces;
using Cosmetics_Perfumes.Data.Repository;
using Cosmetics_Perfumes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region My_config_services
//Строка подключения
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Представление базы данных
builder.Services.AddTransient<IAllProducts, ProductRepository>();
builder.Services.AddTransient<IProductsCategory, CategoryRepository>();
builder.Services.AddTransient<IAllOrders, OrderRepository>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => ShopCart.GetCart(sp));
#endregion

builder.Services.AddControllersWithViews();

builder.Services.AddMvc();

builder.Services.AddMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

#region My_app_config
using (var scope = app.Services.CreateScope())
{
    AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    DbObjects.Initial(context);
}
#endregion

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "categoryFilter",
    pattern: "{controller=Products}/{action=List}/{category?}");


app.Run();
