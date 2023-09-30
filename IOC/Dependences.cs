using EdgarAparicio.Cities.Manager.Interfaces;
using EdgarAparicio.Cities.Manager.Manager;
using EdgarAparicio.Cities.Repository.Context;
using EdgarAparicio.Cities.Repository.Interfaces;
using EdgarAparicio.Cities.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Manager.IOC
{

    //Por ser metodo de extension se tiene que agregar la palabra reservada static
    public static class Dependences
    {

        //Agregar paquete SqlServer y EntityFrameworkCore
        //En el proyecto Repository en la clase CitiesContext se encuentra la configracion del DBContext
        public static void AgregarDBContextCiudades(this IServiceCollection services, IConfiguration configuration)
        {
            //Linea de tutoriales puntos de venta youtube
            services.AddDbContext<CitiesContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("CadenaCiudades")));

            //Linea Pluralsight
            //services.AddDbContext<CitiesContext>(options => options.UseSqlite("Data Source= CityInfo.dbo"));

            services.AddScoped(typeof(ICityRepository), typeof(CityRepository));
            services.AddScoped(typeof(IPointOfInterestRepository), typeof(PointOfInterestRepository));
            services.AddScoped<ICityManager, CityManager>();
            services.AddScoped<IPointOfInterestManager, PointOfInterestManager>();

        }
    }
}
