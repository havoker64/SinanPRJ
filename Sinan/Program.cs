using Microsoft.EntityFrameworkCore;
using Sinan.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option=> { option.LoginPath = "/Usuarios/Login";
        option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    });

builder.Services.AddDbContext<AppDBcontext>(options =>
    options.UseMySql("server=localhost;initial catalog=sinan;uid=root;pwd=GMnoctua270502",
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql")));

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

app.UseAuthentication();

app.UseAuthentication(); // Adicione a autenticação antes do Authorization
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuarios}/{action=Login}/{id?}");

app.Run();