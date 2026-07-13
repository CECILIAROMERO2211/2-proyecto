using BienesRaicesWeb.Data;
using BienesRaicesWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// Configuración de MVC
builder.Services.AddControllersWithViews();

// Registro de Repositorio Genérico (Singleton para conservar datos en memoria)
builder.Services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));

// Registro de la Capa de Negocio
builder.Services.AddScoped<IPropiedadService, PropiedadService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// Ruta por defecto apuntando al controlador de Bienes Raíces
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Propiedades}/{action=Index}/{id?}");

app.Run();