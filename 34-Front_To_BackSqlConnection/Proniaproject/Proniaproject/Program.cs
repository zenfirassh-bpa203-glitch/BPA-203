using Microsoft.EntityFrameworkCore;
using Proniaproject.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlServer(
        "Server=DESKTOP-DQVIFSR\\SQLEXPRESS;" +
        "Database=ProniaDb;" +
        "Trusted_Connection=True;" +
        "TrustServerCertificate=True"
    )
);

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
