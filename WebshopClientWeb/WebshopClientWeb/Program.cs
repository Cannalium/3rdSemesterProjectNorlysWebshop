using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebshopClientWeb.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configure DbContext with SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Identity configuration
builder.Services.AddControllersWithViews();
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    // Configuration for Identity user
    options.SignIn.RequireConfirmedAccount = false; // Account confirmation not required
    options.User.RequireUniqueEmail = true; // Require unique email addresses
})
    .AddEntityFrameworkStores<ApplicationDbContext>(); // Use Entity Framework with ApplicationDbContext

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint(); // Enable the Migrations End Point in development
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Handle exceptions and redirect to error page
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts(); // Use HTTP Strict Transport Security (HSTS) in non-development environments
}

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseStaticFiles(); // Serve static files (e.g., images, CSS, JavaScript)

app.UseRouting();

app.UseAuthentication(); // Enable authentication
app.UseAuthorization(); // Enable authorization

// Map default controller route and Razor pages
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Person}/{action=Profile}/{id?}");
app.MapRazorPages();

app.Run(); // Start the application
