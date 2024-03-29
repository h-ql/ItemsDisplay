using ItemsDisplay.Data;
using ItemsDisplay.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.ConfigureSerilog();
builder.Services.ConfigureSQLite(builder.Configuration);
builder.Services.ConfigureDI();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // Cloud run:
    var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
    var url = $"http://0.0.0.0:{port}";
    builder.WebHost.UseUrls(url);

    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    
}

// Configure OpenAPI
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Character}/{action=Index}/{id?}");

app.Run();
