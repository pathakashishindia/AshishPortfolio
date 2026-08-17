var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages and MVC Controllers
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// Enable static file serving (wwwroot)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Route mappings for MVC & Razor Pages
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();