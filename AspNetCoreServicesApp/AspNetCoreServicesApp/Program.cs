using AspNetCoreServicesApp.Services.Interfaces;
using AspNetCoreServicesApp.Services;
using Microsoft.EntityFrameworkCore;
using AspNetCoreServicesApp.Models;
using AspNetCoreServicesApp.Repositories.Interfaces;
using AspNetCoreServicesApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LocationContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocationDb")));

builder.Services.Add(new ServiceDescriptor(typeof(ILog), new ConsoleLogger()));
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
builder.Services.AddScoped<ILocationService, LocationService>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllers();

app.Run();
