﻿// <auto-generated />
using System;
using EdgarAparicio.Cities.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EdgarAparicio.Cities.Repository.Migrations
{
    [DbContext(typeof(CitiesContext))]
    [Migration("20230525022637_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EdgarAparicio.Cities.Manager.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The one with that big park",
                            Name = "New York City"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The one with the cathedral that was never really finished.",
                            Name = "Antwerp"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The one with that big tower.",
                            Name = "Paris"
                        });
                });

            modelBuilder.Entity("EdgarAparicio.Cities.Manager.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfInterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "The most visited urban park in the United States.",
                            Name = "Central Park"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "A 102-story skycraper located in MidTown Manhttan.",
                            Name = "Empire State Building"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Description = "A Gothic style cathedral, conceived by architects Jan.",
                            Name = "Cathedral"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 3,
                            Description = "The most visited urban park in the United States.",
                            Name = "Urban Park"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            Description = "The most visited paso in the United States.",
                            Name = "The Texas Paso"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 3,
                            Description = "A wrought iron lattice tower on the Champ de Mars.",
                            Name = "Eiffel tower"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 2,
                            Description = "The world's largest museum'.",
                            Name = "The Louvre"
                        });
                });

            modelBuilder.Entity("EdgarAparicio.Cities.Manager.Entities.PointOfInterest", b =>
                {
                    b.HasOne("EdgarAparicio.Cities.Manager.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("EdgarAparicio.Cities.Manager.Entities.City", b =>
                {
                    b.Navigation("PointsOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}
