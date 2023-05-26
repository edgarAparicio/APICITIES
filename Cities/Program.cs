using EdgarAparicio.Cities.Manager.Interfaces;
using EdgarAparicio.Cities.Manager.IOC;
using EdgarAparicio.Cities.Manager.Manager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//En el proyecto IOC en la clase Dependence se agrega la inyeccion de dependencia para configurar la concexion a SQL SERVER
//Se hace el llamado al metodo AgregarDBContextCiudades pasandoile el parametro builder.configuration
builder.Services.AgregarDBContextCiudades(builder.Configuration);


//Ejemplo de DBContext Para hacerlo aqui directo en la clase program pero no es recomendable cuando se usa el proyecto en capas porque al proyecto UI se agregaria
//la referencia del proyecto Repository y estas capas no pueden comunicarse entre si por proteccion de los datos, necesitan una caopa intermedia,
//En este caso usamos el poryecto de arriba IOC que es el que comunica a ambas capas
//builder.Services.AddDbContext<CityContext>(
//    options => options.Uses(
//        builder.Configuration["CadenaCiudades"]));



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Se agrega en la capa IOC en la clase dependencias
//builder.Services.AddScoped(typeof(ICityManager), typeof(CityManager));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
