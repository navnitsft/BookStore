using Microsoft.EntityFrameworkCore;
using navnitsft.BookStore.Data;
using navnitsft.BookStore.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<BookStoreContext>(options => options.UseSqlServer("LAPTOP-8P2PT8CB; Database=BookStore; User Id=sa; Password=123; Trusted_Connection=True; TrustServerCertificate=True;"));
builder.Services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("dev_constr")));

// to use dependency injection
builder.Services.AddScoped<BookRepository, BookRepository>();

// Enable Runtime Compilation for Development
//var mvcBuilder = builder.Services.AddRazorPages();
//if (builder.Environment.IsDevelopment())
//{
//    mvcBuilder.AddRazorRuntimeCompilation();
//}




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
