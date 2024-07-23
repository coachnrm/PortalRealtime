using Microsoft.EntityFrameworkCore;
using PortalRealTime.Hubs;
using PortalRealTime.MiddlewareExtensions;
using PortalRealTime.Models;
using PortalRealTime.SubscribeTableDependencies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSignalR();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<mycontext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Singleton);
builder.Services.AddControllersWithViews();

// DI
builder.Services.AddSingleton<StudentHub>();
builder.Services.AddSingleton<SubscribeStudentTableDependency>();

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
app.MapHub<StudentHub>("/studentHub");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=student}/{action=Index}/{id?}");

app.UseSqlTableDependency<SubscribeStudentTableDependency>(connectionString);

//app.Urls.Add("http://*:80");
app.Run();
