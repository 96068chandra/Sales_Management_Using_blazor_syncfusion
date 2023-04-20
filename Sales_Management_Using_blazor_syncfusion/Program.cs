using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Sales_Management_Using_blazor_syncfusion.Data;
using Sales_Management_Using_blazor_syncfusion.Services;
using Sales_Management_Using_blazor_syncfusion.Services.Contracts;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);
var connectionstring = builder.Configuration.GetConnectionString("SalesManagementDbConnection")
                       ?? throw new InvalidOperationException("Connection 'SalesManagementDbConnection' not found");
builder.Services.AddDbContext<SalesManagementDbContext>(
    options =>options.UseSqlServer(connectionstring));
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<IEmployeeManagementService, EmployeeManagementService>();

var app = builder.Build();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHFqVkNrWE5GdUBAXWFKblJ8RGpTfl1gBShNYlxTR3ZcQFljSHxTd0BgWHtf;MTQ0NjE3NEAzMjMxMmUzMTJlMzMzNVFsWGtrS1loR3lyT2d1ZkVNeVMzNHp2aVNZWXorZWljWWtqQlVEY3lZSGs9");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
