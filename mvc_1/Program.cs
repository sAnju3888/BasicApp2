using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using NorthwindDemoEFCoreDependencyInjection2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<NorthwindDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("nwCnString")));
builder.Services.AddScoped<ICategoryRepository, CategoryService>();
//builder.Services.AddScoped<IProductRepository, ProductService>();
builder.Services.AddScoped<IRegistrationRepo, RegisterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
    {
    app.UseExceptionHandler(errorapp =>
        errorapp.Run(async context =>
        {
            context.Response.StatusCode = 500;
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync("<html lang=\"en\"><body>\r\n");
            await context.Response.WriteAsync("ERROR! <br> <br> \r\n");
            var exceptionHandlerPathFeature =
            context.Features.Get<IExceptionHandlerPathFeature>();
            if (exceptionHandlerPathFeature?.Error is ArgumentNullException)
                {
                await context.Response.WriteAsync("File Error Thrown!<br> <br>\r\n");
                }
            await context.Response.WriteAsync("File Error Thrown!<br> <br>\r\n");
            await context.Response.WriteAsync("<a href=\"/\">Home </a> <br> \r\n");
            await context.Response.WriteAsync("</body><h/html>\r\n");
            await context.Response.WriteAsync(new string(' ', 512));


        }
    )
    );
    app.UseHsts();

    
    }
else
    {
    //app.UseExceptionHandler("Developer/Exception/Page");
    
    app.UseStatusCodePagesWithReExecute("/Error/{0}");
    }

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Categories}/{action=Index}/{id?}");

app.Run();
