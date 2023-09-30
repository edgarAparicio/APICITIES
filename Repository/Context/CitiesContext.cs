using EdgarAparicio.Cities.Manager.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Repository.Context
{

    //Si heredas de una clase que no este en tu proyecto pero tienes otra clase con el mismo nombre, te marcar error 
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


        //Por cada entidad se agrega un DBSet
        public DbSet<City> Cities { get; set; } = null!;

        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;


        //Metodo para SQLLIte sin usar constructor

        //protected override void OnConfigurin(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("CadenaCiudades");
        //    base.OnConfiguring(optionsBuilder);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    //Aqui se le pasa el nombre de la ciudad porque la entidad tiene un constructor que recibe un nombre, sino se lo pasamos nos marca error.
        //    //De esta manera ya no se egrega el nombre dentro de las llaves. 
        //    modelBuilder.Entity<City>()
        //     .HasData(
        //        new City("New York City")
        //        {
        //            Id = 1,
        //            //Description = "The one with that big park"
        //            Description = "Putoo"
        //        },
        //        new City("Antwerp")
        //        {
        //            Id = 2,
        //            //Description = "The one with the cathedral that was never really finished."
        //            Description = "Mamon"
        //        },
        //        new City("Paris")
        //        {
        //            Id = 3,
        //            //Description = "The one with that big tower."
        //            Description = "Jotooooooo"
        //        });

        //    modelBuilder.Entity<PointOfInterest>()
        //     .HasData(
        //        new PointOfInterest("Central Park")
        //        {
        //            Id = 1,
        //            CityId = 1,
        //            Description = "The most visited urban park in the United States."
        //        },
        //        new PointOfInterest("Empire State Building")
        //        {
        //            Id = 2,
        //            CityId = 1,
        //            Description = "A 102-story skycraper located in MidTown Manhttan."
        //        },
        //        new PointOfInterest("Cathedral")
        //        {
        //            Id = 3,
        //            CityId = 2,
        //            Description = "A Gothic style cathedral, conceived by architects Jan."
        //        },
        //        new PointOfInterest("Urban Park")
        //        {
        //            Id = 4,
        //            CityId = 3,
        //            Description = "The most visited urban park in the United States."
        //        },
        //        new PointOfInterest("The Texas Paso")
        //        {
        //            Id = 5,
        //            CityId = 3,
        //            Description = "The most visited paso in the United States."
        //        },
        //        new PointOfInterest("Eiffel tower")
        //        {
        //            Id = 6,
        //            CityId = 3,
        //            Description = "A wrought iron lattice tower on the Champ de Mars."
        //        },
        //        new PointOfInterest("The Louvre")
        //        {
        //            Id = 7,
        //            CityId = 2,
        //            Description = "The world's largest museum'."
        //        }); 
                
                


        //    base.OnModelCreating(modelBuilder);
        //}





    }
}
