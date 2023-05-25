using EdgarAparicio.Cities.Manager.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Repository.Context
{
    public class CitiesContext : DbContext
    {
        //Se necesita instalar el paquete Microsoft.EntityFrameworkCore
        //Metodo para DbContext por medio del contructor
        public CitiesContext(DbContextOptions<CitiesContext> options) : base(options)
        {

        }
        //Se puede ignorar la advertencia que manda visual en los dbset
        //esto es porque los Dbset no se han inicializado y pueden venir nulos despues de dejar el constructor
        //Solo que La clase DBContext ya los inicializa pero visual studio lo ignora
        //para quitar esa advertencia se agrega los siguiente
        //= null!;

        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;


        //Metodo para SQLLIte sin usar constructor

        //protected override void OnConfigurin(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("CadenaCiudades");
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
