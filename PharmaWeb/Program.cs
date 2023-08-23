using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;
using PharmaWeb.Data;
using PharmaWeb.Models;
using PharmaWeb.Service;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Globalization;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<IProductService, Productservice>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddSession();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 7;
}).AddEntityFrameworkStores<ApplicationDbContext>();


//ADD POLICIES
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policyBuilder => policyBuilder.RequireClaim("CanEditProduct"));
   
});

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddMvc().AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var cultures = new List<CultureInfo>
    { new CultureInfo("en"),
      new CultureInfo("fr"),
      new CultureInfo("nl")

    };

    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedCultures = cultures;
    options.SupportedUICultures = cultures;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetService<UserManager<ApplicationUser>>();
    if (userManager.FindByEmailAsync("admin@test.be").Result == null)
    {
        //ADMIN 
        ApplicationUser adminAdult = new ApplicationUser();
        adminAdult.UserName = "admin@test.be";
        adminAdult.Email = "admin@test.be";
        adminAdult.FirstName = "soufiane";
        adminAdult.LastName = "bayoud";
        adminAdult.EmailConfirmed = true; //nodig om check te bypassen

        //save user with password
        var result = userManager.CreateAsync(adminAdult, "Admin123@").Result;

        if (result.Succeeded)
        {
            //define claims for user
            Claim[] claimsAdminAdult = new Claim[] {
                new Claim("CanEditProduct", string.Empty)
                };
            //add array of claims to user
            userManager.AddClaimsAsync(adminAdult, claimsAdminAdult).Wait();
        }
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//USE SESSION
app.UseSession();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
//var cultures = new[] { "en", "fr", "nl" };
//var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(cultures[0])
//    .AddSupportedCultures(cultures)
//    .AddSupportedUICultures(cultures);

app.UseRequestLocalization(app.Services.CreateScope().ServiceProvider.
    GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
