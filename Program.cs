using StudentPortal.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services (dependency injection)
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IStudentService, InMemoryStudentService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

// Default route: {controller}/{action}/{id?}
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
