using BienesRaicesWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace BienesRaicesWeb.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        if (context.Propiedades.Any())
            return;

        var propiedades = new List<Propiedad>
        {
            new Propiedad
            {
                Titulo = "Casa Moderna en Juriquilla #001",
                Descripcion = "Casa moderna ubicada en Juriquilla. Cuenta con 3 recámaras, 3 baños, 145 m² de construcción, alberca privada, jardín amplio y terraza. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Juriquilla",
                Precio = 2272500m,
                ImagenUrl = "/images/propiedades/casa/casa-001.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Contemporánea en Jurica #002",
                Descripcion = "Casa contemporánea ubicada en Jurica. Cuenta con 4 recámaras, 4 baños, 150 m² de construcción, roof garden, jacuzzi y vista panorámica. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Jurica",
                Precio = 2345000m,
                ImagenUrl = "/images/propiedades/casa/casa-002.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Minimalista en Zibatá #003",
                Descripcion = "Casa minimalista ubicada en Zibatá. Cuenta con 5 recámaras, 5 baños, 155 m² de construcción, cocina integral, sala de doble altura y estudio. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Zibatá",
                Precio = 2417500m,
                ImagenUrl = "/images/propiedades/casa/casa-003.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Residencial en Zakía #004",
                Descripcion = "Casa residencial ubicada en Zakía. Cuenta con 6 recámaras, 2 baños, 160 m² de construcción, cochera para tres autos, bodega y área de lavado. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Zakía",
                Precio = 2490000m,
                ImagenUrl = "/images/propiedades/casa/casa-004.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Campestre en El Refugio #005",
                Descripcion = "Casa campestre ubicada en El Refugio. Cuenta con 2 recámaras, 3 baños, 165 m² de construcción, paneles solares, iluminación inteligente y cámaras de seguridad. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "El Refugio",
                Precio = 2562500m,
                ImagenUrl = "/images/propiedades/casa/casa-005.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Colonial en Cumbres del Lago #006",
                Descripcion = "Casa colonial ubicada en Cumbres del Lago. Cuenta con 3 recámaras, 4 baños, 170 m² de construcción, jardín interior, terraza con asador y salón de juegos. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Cumbres del Lago",
                Precio = 2635000m,
                ImagenUrl = "/images/propiedades/casa/casa-006.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Mediterránea en Centro Histórico #007",
                Descripcion = "Casa mediterránea ubicada en Centro Histórico. Cuenta con 4 recámaras, 5 baños, 175 m² de construcción, gimnasio, oficina privada y recámara en planta baja. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Centro Histórico",
                Precio = 2707500m,
                ImagenUrl = "/images/propiedades/casa/casa-007.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Ecológica en Carretas #008",
                Descripcion = "Casa ecológica ubicada en Carretas. Cuenta con 5 recámaras, 2 baños, 180 m² de construcción, acabados premium, vestidor y balcón principal. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Carretas",
                Precio = 2780000m,
                ImagenUrl = "/images/propiedades/casa/casa-008.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Familiar en Milenio III #009",
                Descripcion = "Casa familiar ubicada en Milenio III. Cuenta con 6 recámaras, 3 baños, 185 m² de construcción, área para mascotas, parque cercano y acceso controlado. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Milenio III",
                Precio = 2852500m,
                ImagenUrl = "/images/propiedades/casa/casa-009.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa De lujo en Centro Sur #010",
                Descripcion = "Casa de lujo ubicada en Centro Sur. Cuenta con 2 recámaras, 4 baños, 190 m² de construcción, amplios ventanales, diseño abierto y excelente iluminación natural. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Centro Sur",
                Precio = 2925000m,
                ImagenUrl = "/images/propiedades/casa/casa-010.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Moderna en El Mirador #011",
                Descripcion = "Casa moderna ubicada en El Mirador. Cuenta con 3 recámaras, 5 baños, 195 m² de construcción, alberca privada, jardín amplio y terraza. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "El Mirador",
                Precio = 2997500m,
                ImagenUrl = "/images/propiedades/casa/casa-011.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Contemporánea en Vista Real #012",
                Descripcion = "Casa contemporánea ubicada en Vista Real. Cuenta con 4 recámaras, 2 baños, 200 m² de construcción, roof garden, jacuzzi y vista panorámica. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Vista Real",
                Precio = 3070000m,
                ImagenUrl = "/images/propiedades/casa/casa-012.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Minimalista en Corregidora #013",
                Descripcion = "Casa minimalista ubicada en Corregidora. Cuenta con 5 recámaras, 3 baños, 205 m² de construcción, cocina integral, sala de doble altura y estudio. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Corregidora",
                Precio = 3142500m,
                ImagenUrl = "/images/propiedades/casa/casa-013.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Residencial en San Miguel de Allende #014",
                Descripcion = "Casa residencial ubicada en San Miguel de Allende. Cuenta con 6 recámaras, 4 baños, 210 m² de construcción, cochera para tres autos, bodega y área de lavado. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "San Miguel de Allende",
                Precio = 3215000m,
                ImagenUrl = "/images/propiedades/casa/casa-014.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Campestre en Bernal #015",
                Descripcion = "Casa campestre ubicada en Bernal. Cuenta con 2 recámaras, 5 baños, 215 m² de construcción, paneles solares, iluminación inteligente y cámaras de seguridad. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Bernal",
                Precio = 3287500m,
                ImagenUrl = "/images/propiedades/casa/casa-015.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Colonial en Amealco #016",
                Descripcion = "Casa colonial ubicada en Amealco. Cuenta con 3 recámaras, 2 baños, 220 m² de construcción, jardín interior, terraza con asador y salón de juegos. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Amealco",
                Precio = 3360000m,
                ImagenUrl = "/images/propiedades/casa/casa-016.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Mediterránea en Valle de Bravo #017",
                Descripcion = "Casa mediterránea ubicada en Valle de Bravo. Cuenta con 4 recámaras, 3 baños, 225 m² de construcción, gimnasio, oficina privada y recámara en planta baja. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Valle de Bravo",
                Precio = 3432500m,
                ImagenUrl = "/images/propiedades/casa/casa-017.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Ecológica en Sierra Gorda #018",
                Descripcion = "Casa ecológica ubicada en Sierra Gorda. Cuenta con 5 recámaras, 4 baños, 230 m² de construcción, acabados premium, vestidor y balcón principal. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Sierra Gorda",
                Precio = 3505000m,
                ImagenUrl = "/images/propiedades/casa/casa-018.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Familiar en Cancún #019",
                Descripcion = "Casa familiar ubicada en Cancún. Cuenta con 6 recámaras, 5 baños, 235 m² de construcción, área para mascotas, parque cercano y acceso controlado. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Cancún",
                Precio = 3577500m,
                ImagenUrl = "/images/propiedades/casa/casa-019.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa De lujo en Tulum #020",
                Descripcion = "Casa de lujo ubicada en Tulum. Cuenta con 2 recámaras, 2 baños, 240 m² de construcción, amplios ventanales, diseño abierto y excelente iluminación natural. Ideal para familias que buscan comodidad, seguridad y una excelente ubicación.",
                Tipo = "Casa",
                Ubicacion = "Tulum",
                Precio = 3650000m,
                ImagenUrl = "/images/propiedades/casa/casa-020.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Inteligente en El Campanario #021",
                Descripcion = "Residencia equipada con sistema domótico, 4 recámaras, cine en casa, alberca climatizada y acabados premium.",
                Tipo = "Casa",
                Ubicacion = "El Campanario",
                Precio = 5350000m,
                ImagenUrl = "/images/propiedades/casa/casa-021.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa de Campo en Tequisquiapan #022",
                Descripcion = "Casa de descanso con amplios jardines, terraza, chimenea y vista a los viñedos.",
                Tipo = "Casa",
                Ubicacion = "Tequisquiapan",
                Precio = 3890000m,
                ImagenUrl = "/images/propiedades/casa/casa-022.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Boutique en Álamos #023",
                Descripcion = "Residencia con diseño arquitectónico contemporáneo, cocina gourmet y roof garden.",
                Tipo = "Casa",
                Ubicacion = "Álamos",
                Precio = 4680000m,
                ImagenUrl = "/images/propiedades/casa/casa-023.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Familiar en El Pueblito #024",
                Descripcion = "Casa amplia con 5 recámaras, jardín trasero, estudio y cochera para cuatro vehículos.",
                Tipo = "Casa",
                Ubicacion = "El Pueblito",
                Precio = 3520000m,
                ImagenUrl = "/images/propiedades/casa/casa-024.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa de Lujo en Balvanera #025",
                Descripcion = "Residencia con vista al campo de golf, alberca infinita, cava y gimnasio privado.",
                Tipo = "Casa",
                Ubicacion = "Balvanera",
                Precio = 8900000m,
                ImagenUrl = "/images/propiedades/casa/casa-025.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Premium en Altozano #026",
                Descripcion = "Propiedad con doble altura, cocina italiana, jardín y paneles solares.",
                Tipo = "Casa",
                Ubicacion = "Altozano",
                Precio = 6120000m,
                ImagenUrl = "/images/propiedades/casa/casa-026.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Moderna en Zákia Premium #027",
                Descripcion = "Residencia con diseño minimalista, roof garden y acabados de lujo.",
                Tipo = "Casa",
                Ubicacion = "Zákia Premium",
                Precio = 4180000m,
                ImagenUrl = "/images/propiedades/casa/casa-027.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Residencial en Preserve Juriquilla #028",
                Descripcion = "Casa con terraza panorámica, jardín, estudio y seguridad las 24 horas.",
                Tipo = "Casa",
                Ubicacion = "Preserve Juriquilla",
                Precio = 4860000m,
                ImagenUrl = "/images/propiedades/casa/casa-028.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Colonial en Peña de Bernal #029",
                Descripcion = "Casa estilo colonial mexicano con patio central y espectacular vista al monolito.",
                Tipo = "Casa",
                Ubicacion = "Peña de Bernal",
                Precio = 3720000m,
                ImagenUrl = "/images/propiedades/casa/casa-029.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Campestre en Ezequiel Montes #030",
                Descripcion = "Casa rodeada de naturaleza con amplios jardines y terraza para eventos.",
                Tipo = "Casa",
                Ubicacion = "Ezequiel Montes",
                Precio = 3340000m,
                ImagenUrl = "/images/propiedades/casa/casa-030.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Frente al Mar en Puerto Escondido #031",
                Descripcion = "Residencia con acceso directo a la playa, alberca infinita y terraza panorámica.",
                Tipo = "Casa",
                Ubicacion = "Puerto Escondido",
                Precio = 9850000m,
                ImagenUrl = "/images/propiedades/casa/casa-031.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Náutica en La Paz #032",
                Descripcion = "Casa con muelle privado, vista al mar y acabados de lujo.",
                Tipo = "Casa",
                Ubicacion = "La Paz",
                Precio = 10350000m,
                ImagenUrl = "/images/propiedades/casa/casa-032.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Sustentable en Bacalar #033",
                Descripcion = "Construcción sustentable con paneles solares y acceso a la laguna.",
                Tipo = "Casa",
                Ubicacion = "Bacalar",
                Precio = 4650000m,
                ImagenUrl = "/images/propiedades/casa/casa-033.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa de Descanso en Valle de Guadalupe #034",
                Descripcion = "Residencia rodeada de viñedos con diseño contemporáneo y cava privada.",
                Tipo = "Casa",
                Ubicacion = "Valle de Guadalupe",
                Precio = 5780000m,
                ImagenUrl = "/images/propiedades/casa/casa-034.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa de Autor en Lomas de Angelópolis #035",
                Descripcion = "Diseño arquitectónico exclusivo con doble altura y acabados importados.",
                Tipo = "Casa",
                Ubicacion = "Lomas de Angelópolis",
                Precio = 6250000m,
                ImagenUrl = "/images/propiedades/casa/casa-035.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Exclusiva en Bosque Real #036",
                Descripcion = "Residencia de lujo con vista al campo de golf y gimnasio privado.",
                Tipo = "Casa",
                Ubicacion = "Bosque Real",
                Precio = 11200000m,
                ImagenUrl = "/images/propiedades/casa/casa-036.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Vista Lago en Avándaro #037",
                Descripcion = "Casa con espectacular vista al lago, jacuzzi y terraza panorámica.",
                Tipo = "Casa",
                Ubicacion = "Avándaro",
                Precio = 7980000m,
                ImagenUrl = "/images/propiedades/casa/casa-037.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Mediterránea en Ajijic #038",
                Descripcion = "Residencia con jardín tropical, alberca y acabados mediterráneos.",
                Tipo = "Casa",
                Ubicacion = "Ajijic",
                Precio = 5920000m,
                ImagenUrl = "/images/propiedades/casa/casa-038.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Panorámica en San Cristóbal de las Casas #039",
                Descripcion = "Casa de montaña con amplios ventanales y terraza con vista natural.",
                Tipo = "Casa",
                Ubicacion = "San Cristóbal de las Casas",
                Precio = 4280000m,
                ImagenUrl = "/images/propiedades/casa/casa-039.jpg"
            },
            new Propiedad
            {
                Titulo = "Casa Exclusiva en Valle Poniente #040",
                Descripcion = "Residencia premium con acabados de mármol, alberca y jardín de diseño.",
                Tipo = "Casa",
                Ubicacion = "Valle Poniente",
                Precio = 8450000m,
                ImagenUrl = "/images/propiedades/casa/casa-040.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Penthouse en Juriquilla #041",
                Descripcion = "Departamento penthouse ubicado en Juriquilla. Cuenta con 2 recámaras, 2 baños, 68 m² de construcción, alberca, gimnasio y salón de usos múltiples. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Juriquilla",
                Precio = 1508500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-001.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Loft en Centro Histórico #042",
                Descripcion = "Departamento loft ubicado en Centro Histórico. Cuenta con 3 recámaras, 3 baños, 71 m² de construcción, balcón privado, estacionamiento y vigilancia 24 horas. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Centro Histórico",
                Precio = 1567000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-002.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Ejecutivo en Milenio III #043",
                Descripcion = "Departamento ejecutivo ubicado en Milenio III. Cuenta con 4 recámaras, 1 baños, 74 m² de construcción, roof garden, elevador y acceso controlado. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Milenio III",
                Precio = 1625500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-003.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Moderno en Centro Sur #044",
                Descripcion = "Departamento moderno ubicado en Centro Sur. Cuenta con 1 recámaras, 2 baños, 77 m² de construcción, cocina equipada, área de lavado y bodega. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Centro Sur",
                Precio = 1684000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-004.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Residencial en Zibatá #045",
                Descripcion = "Departamento residencial ubicado en Zibatá. Cuenta con 2 recámaras, 3 baños, 80 m² de construcción, vista panorámica, terraza y acabados de lujo. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Zibatá",
                Precio = 1742500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-005.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento De lujo en El Refugio #046",
                Descripcion = "Departamento de lujo ubicado en El Refugio. Cuenta con 3 recámaras, 1 baños, 83 m² de construcción, coworking, gimnasio y área de asadores. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "El Refugio",
                Precio = 1801000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-006.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Con terraza en Corregidora #047",
                Descripcion = "Departamento con terraza ubicado en Corregidora. Cuenta con 4 recámaras, 2 baños, 86 m² de construcción, estacionamiento techado, lobby y seguridad. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Corregidora",
                Precio = 1859500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-007.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Con vista panorámica en San Miguel de Allende #048",
                Descripcion = "Departamento con vista panorámica ubicado en San Miguel de Allende. Cuenta con 1 recámaras, 3 baños, 89 m² de construcción, amenidades exclusivas, elevador y terraza común. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "San Miguel de Allende",
                Precio = 1918000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-008.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Amueblado en Cancún #049",
                Descripcion = "Departamento amueblado ubicado en Cancún. Cuenta con 2 recámaras, 1 baños, 92 m² de construcción, mobiliario contemporáneo y excelente iluminación. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Cancún",
                Precio = 1976500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-009.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Minimalista en Playa del Carmen #050",
                Descripcion = "Departamento minimalista ubicado en Playa del Carmen. Cuenta con 3 recámaras, 2 baños, 95 m² de construcción, ubicación céntrica, servicios cercanos y acceso rápido. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Playa del Carmen",
                Precio = 2035000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-010.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Penthouse en Tulum #051",
                Descripcion = "Departamento penthouse ubicado en Tulum. Cuenta con 4 recámaras, 3 baños, 98 m² de construcción, alberca, gimnasio y salón de usos múltiples. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Tulum",
                Precio = 2093500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-011.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Loft en Puerto Vallarta #052",
                Descripcion = "Departamento loft ubicado en Puerto Vallarta. Cuenta con 1 recámaras, 1 baños, 101 m² de construcción, balcón privado, estacionamiento y vigilancia 24 horas. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Puerto Vallarta",
                Precio = 2152000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-012.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Ejecutivo en Mazatlán #053",
                Descripcion = "Departamento ejecutivo ubicado en Mazatlán. Cuenta con 2 recámaras, 2 baños, 104 m² de construcción, roof garden, elevador y acceso controlado. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Mazatlán",
                Precio = 2210500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-013.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Moderno en Valle de Bravo #054",
                Descripcion = "Departamento moderno ubicado en Valle de Bravo. Cuenta con 3 recámaras, 3 baños, 107 m² de construcción, cocina equipada, área de lavado y bodega. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Valle de Bravo",
                Precio = 2269000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-014.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Residencial en Querétaro Centro #055",
                Descripcion = "Departamento residencial ubicado en Querétaro Centro. Cuenta con 4 recámaras, 1 baños, 110 m² de construcción, vista panorámica, terraza y acabados de lujo. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Querétaro Centro",
                Precio = 2327500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-015.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento De lujo en Juriquilla #056",
                Descripcion = "Departamento de lujo ubicado en Juriquilla. Cuenta con 1 recámaras, 2 baños, 113 m² de construcción, coworking, gimnasio y área de asadores. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Juriquilla",
                Precio = 2386000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-016.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Con terraza en Centro Histórico #057",
                Descripcion = "Departamento con terraza ubicado en Centro Histórico. Cuenta con 2 recámaras, 3 baños, 116 m² de construcción, estacionamiento techado, lobby y seguridad. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Centro Histórico",
                Precio = 2444500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-017.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Con vista panorámica en Milenio III #058",
                Descripcion = "Departamento con vista panorámica ubicado en Milenio III. Cuenta con 3 recámaras, 1 baños, 119 m² de construcción, amenidades exclusivas, elevador y terraza común. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Milenio III",
                Precio = 2503000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-018.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Amueblado en Centro Sur #059",
                Descripcion = "Departamento amueblado ubicado en Centro Sur. Cuenta con 4 recámaras, 2 baños, 122 m² de construcción, mobiliario contemporáneo y excelente iluminación. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Centro Sur",
                Precio = 2561500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-019.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Minimalista en Zibatá #060",
                Descripcion = "Departamento minimalista ubicado en Zibatá. Cuenta con 1 recámaras, 3 baños, 125 m² de construcción, ubicación céntrica, servicios cercanos y acceso rápido. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Zibatá",
                Precio = 2620000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-020.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Penthouse en El Refugio #061",
                Descripcion = "Departamento penthouse ubicado en El Refugio. Cuenta con 2 recámaras, 1 baños, 128 m² de construcción, alberca, gimnasio y salón de usos múltiples. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "El Refugio",
                Precio = 2678500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-021.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Loft en Corregidora #062",
                Descripcion = "Departamento loft ubicado en Corregidora. Cuenta con 3 recámaras, 2 baños, 131 m² de construcción, balcón privado, estacionamiento y vigilancia 24 horas. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Corregidora",
                Precio = 2737000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-022.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Ejecutivo en San Miguel de Allende #063",
                Descripcion = "Departamento ejecutivo ubicado en San Miguel de Allende. Cuenta con 4 recámaras, 3 baños, 134 m² de construcción, roof garden, elevador y acceso controlado. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "San Miguel de Allende",
                Precio = 2795500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-023.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Moderno en Cancún #064",
                Descripcion = "Departamento moderno ubicado en Cancún. Cuenta con 1 recámaras, 1 baños, 137 m² de construcción, cocina equipada, área de lavado y bodega. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Cancún",
                Precio = 2854000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-024.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Residencial en Playa del Carmen #065",
                Descripcion = "Departamento residencial ubicado en Playa del Carmen. Cuenta con 2 recámaras, 2 baños, 140 m² de construcción, vista panorámica, terraza y acabados de lujo. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Playa del Carmen",
                Precio = 2912500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-025.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento De lujo en Tulum #066",
                Descripcion = "Departamento de lujo ubicado en Tulum. Cuenta con 3 recámaras, 3 baños, 143 m² de construcción, coworking, gimnasio y área de asadores. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Tulum",
                Precio = 2971000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-026.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Con terraza en Puerto Vallarta #067",
                Descripcion = "Departamento con terraza ubicado en Puerto Vallarta. Cuenta con 4 recámaras, 1 baños, 146 m² de construcción, estacionamiento techado, lobby y seguridad. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Puerto Vallarta",
                Precio = 3029500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-027.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Con vista panorámica en Mazatlán #068",
                Descripcion = "Departamento con vista panorámica ubicado en Mazatlán. Cuenta con 1 recámaras, 2 baños, 149 m² de construcción, amenidades exclusivas, elevador y terraza común. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Mazatlán",
                Precio = 3088000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-028.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Amueblado en Valle de Bravo #069",
                Descripcion = "Departamento amueblado ubicado en Valle de Bravo. Cuenta con 2 recámaras, 3 baños, 152 m² de construcción, mobiliario contemporáneo y excelente iluminación. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Valle de Bravo",
                Precio = 3146500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-029.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Minimalista en Querétaro Centro #070",
                Descripcion = "Departamento minimalista ubicado en Querétaro Centro. Cuenta con 3 recámaras, 1 baños, 155 m² de construcción, ubicación céntrica, servicios cercanos y acceso rápido. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Querétaro Centro",
                Precio = 3205000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-030.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Penthouse en Juriquilla #071",
                Descripcion = "Departamento penthouse ubicado en Juriquilla. Cuenta con 4 recámaras, 2 baños, 158 m² de construcción, alberca, gimnasio y salón de usos múltiples. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Juriquilla",
                Precio = 3263500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-031.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Loft en Centro Histórico #072",
                Descripcion = "Departamento loft ubicado en Centro Histórico. Cuenta con 1 recámaras, 3 baños, 161 m² de construcción, balcón privado, estacionamiento y vigilancia 24 horas. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Centro Histórico",
                Precio = 3322000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-032.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Ejecutivo en Milenio III #073",
                Descripcion = "Departamento ejecutivo ubicado en Milenio III. Cuenta con 2 recámaras, 1 baños, 164 m² de construcción, roof garden, elevador y acceso controlado. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Milenio III",
                Precio = 3380500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-033.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Moderno en Centro Sur #074",
                Descripcion = "Departamento moderno ubicado en Centro Sur. Cuenta con 3 recámaras, 2 baños, 167 m² de construcción, cocina equipada, área de lavado y bodega. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Centro Sur",
                Precio = 3439000m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-034.jpg"
            },
            new Propiedad
            {
                Titulo = "Departamento Residencial en Zibatá #075",
                Descripcion = "Departamento residencial ubicado en Zibatá. Cuenta con 4 recámaras, 3 baños, 170 m² de construcción, vista panorámica, terraza y acabados de lujo. Excelente opción para vivir o invertir.",
                Tipo = "Departamento",
                Ubicacion = "Zibatá",
                Precio = 3497500m,
                ImagenUrl = "/images/propiedades/departamentos/departamento-035.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Residencial en Amealco #076",
                Descripcion = "Terreno residencial ubicado en Amealco, con una superficie de 285 m². Cuenta con servicios de agua, luz y drenaje disponibles. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Amealco",
                Precio = 692000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-001.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Campestre en Bernal #077",
                Descripcion = "Terreno campestre ubicado en Bernal, con una superficie de 320 m². Cuenta con acceso pavimentado y excelente ubicación. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Bernal",
                Precio = 734000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-002.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Comercial en Sierra Gorda #078",
                Descripcion = "Terreno comercial ubicado en Sierra Gorda, con una superficie de 355 m². Cuenta con uso de suelo residencial y documentación en regla. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Sierra Gorda",
                Precio = 776000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-003.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno En esquina en San Joaquín #079",
                Descripcion = "Terreno en esquina ubicado en San Joaquín, con una superficie de 390 m². Cuenta con ideal para proyecto comercial o habitacional. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "San Joaquín",
                Precio = 818000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-004.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Con servicios en Corregidora #080",
                Descripcion = "Terreno con servicios ubicado en Corregidora, con una superficie de 425 m². Cuenta con vista panorámica y entorno natural. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Corregidora",
                Precio = 860000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-005.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Para inversión en Huimilpan #081",
                Descripcion = "Terreno para inversión ubicado en Huimilpan, con una superficie de 460 m². Cuenta con frente amplio y topografía regular. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Huimilpan",
                Precio = 902000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-006.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Frente a carretera en El Marqués #082",
                Descripcion = "Terreno frente a carretera ubicado en El Marqués, con una superficie de 495 m². Cuenta con ubicación estratégica para inversión. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "El Marqués",
                Precio = 944000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-007.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Con vista panorámica en Colón #083",
                Descripcion = "Terreno con vista panorámica ubicado en Colón, con una superficie de 530 m². Cuenta con acceso por carretera y servicios cercanos. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Colón",
                Precio = 986000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-008.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Urbanizado en Tequisquiapan #084",
                Descripcion = "Terreno urbanizado ubicado en Tequisquiapan, con una superficie de 565 m². Cuenta con zona de crecimiento con alta plusvalía. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Tequisquiapan",
                Precio = 1028000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-009.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Para desarrollo en San Miguel de Allende #085",
                Descripcion = "Terreno para desarrollo ubicado en San Miguel de Allende, con una superficie de 600 m². Cuenta con ideal para construir casa de descanso. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "San Miguel de Allende",
                Precio = 1070000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-010.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Residencial en Valle de Bravo #086",
                Descripcion = "Terreno residencial ubicado en Valle de Bravo, con una superficie de 635 m². Cuenta con servicios de agua, luz y drenaje disponibles. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Valle de Bravo",
                Precio = 1112000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-011.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Campestre en Tulum #087",
                Descripcion = "Terreno campestre ubicado en Tulum, con una superficie de 670 m². Cuenta con acceso pavimentado y excelente ubicación. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Tulum",
                Precio = 1154000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-012.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Comercial en Playa del Carmen #088",
                Descripcion = "Terreno comercial ubicado en Playa del Carmen, con una superficie de 705 m². Cuenta con uso de suelo residencial y documentación en regla. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Playa del Carmen",
                Precio = 1196000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-013.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno En esquina en Amealco #089",
                Descripcion = "Terreno en esquina ubicado en Amealco, con una superficie de 740 m². Cuenta con ideal para proyecto comercial o habitacional. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Amealco",
                Precio = 1238000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-014.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Con servicios en Bernal #090",
                Descripcion = "Terreno con servicios ubicado en Bernal, con una superficie de 775 m². Cuenta con vista panorámica y entorno natural. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Bernal",
                Precio = 1280000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-015.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Para inversión en Sierra Gorda #091",
                Descripcion = "Terreno para inversión ubicado en Sierra Gorda, con una superficie de 810 m². Cuenta con frente amplio y topografía regular. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Sierra Gorda",
                Precio = 1322000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-016.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Frente a carretera en San Joaquín #092",
                Descripcion = "Terreno frente a carretera ubicado en San Joaquín, con una superficie de 845 m². Cuenta con ubicación estratégica para inversión. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "San Joaquín",
                Precio = 1364000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-017.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Con vista panorámica en Corregidora #093",
                Descripcion = "Terreno con vista panorámica ubicado en Corregidora, con una superficie de 880 m². Cuenta con acceso por carretera y servicios cercanos. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Corregidora",
                Precio = 1406000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-018.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Urbanizado en Huimilpan #094",
                Descripcion = "Terreno urbanizado ubicado en Huimilpan, con una superficie de 915 m². Cuenta con zona de crecimiento con alta plusvalía. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Huimilpan",
                Precio = 1448000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-019.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Para desarrollo en El Marqués #095",
                Descripcion = "Terreno para desarrollo ubicado en El Marqués, con una superficie de 950 m². Cuenta con ideal para construir casa de descanso. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "El Marqués",
                Precio = 1490000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-020.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Residencial en Colón #096",
                Descripcion = "Terreno residencial ubicado en Colón, con una superficie de 985 m². Cuenta con servicios de agua, luz y drenaje disponibles. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Colón",
                Precio = 1532000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-021.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Campestre en Tequisquiapan #097",
                Descripcion = "Terreno campestre ubicado en Tequisquiapan, con una superficie de 1020 m². Cuenta con acceso pavimentado y excelente ubicación. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Tequisquiapan",
                Precio = 1574000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-022.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Comercial en San Miguel de Allende #098",
                Descripcion = "Terreno comercial ubicado en San Miguel de Allende, con una superficie de 1055 m². Cuenta con uso de suelo residencial y documentación en regla. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "San Miguel de Allende",
                Precio = 1616000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-023.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno En esquina en Valle de Bravo #099",
                Descripcion = "Terreno en esquina ubicado en Valle de Bravo, con una superficie de 1090 m². Cuenta con ideal para proyecto comercial o habitacional. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Valle de Bravo",
                Precio = 1658000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-024.jpg"
            },
            new Propiedad
            {
                Titulo = "Terreno Con servicios en Tulum #100",
                Descripcion = "Terreno con servicios ubicado en Tulum, con una superficie de 1125 m². Cuenta con vista panorámica y entorno natural. Excelente oportunidad para construcción o inversión.",
                Tipo = "Terreno",
                Ubicacion = "Tulum",
                Precio = 1700000m,
                ImagenUrl = "/images/propiedades/terrenos/terreno-025.jpg"
            }
        };

        context.Propiedades.AddRange(propiedades);
        context.SaveChanges();
    }
}