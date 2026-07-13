using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BienesRaicesWeb.Data;
using BienesRaicesWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Configurar la conexión a la base de datos SQLite
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

// 2. Agregar servicios al contenedor de dependencias (MVC)
builder.Services.AddControllersWithViews();

// 3. Registro de tus servicios y repositorios genéricos
builder.Services.AddScoped<IPropiedadService, PropiedadService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

// 4. Bloque automático para sembrar los 100 registros si la base de datos está vacía
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    DbInitializer.Initialize();
}

// 5. Configurar el pipeline de solicitudes HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();