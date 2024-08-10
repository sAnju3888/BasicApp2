using Microsoft.EntityFrameworkCore;
using NorthwindDemoEFCoreDependencyInjection2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<NorthwindDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("nwCnString")));
builder.Services.AddScoped<ICategoryRepository, CategoryService>();
//builder.Services.AddScoped<IProductRepository, ProductService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
    {
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    }
else
    {
    //app.UseExceptionHandler("Developer/Exception/Page");
    
    app.UseDeveloperExceptionPage();
    }

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Categories}/{action=Index}/{id?}");

app.Run();
