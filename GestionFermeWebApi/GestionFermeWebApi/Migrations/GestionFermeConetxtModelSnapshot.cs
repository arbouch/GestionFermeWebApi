﻿// <auto-generated />
using GestionFermeWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionFermeWebApi.Migrations
{
    [DbContext(typeof(GestionFermeConetxt))]
    partial class GestionFermeConetxtModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionFermeWebApi.Models.Ferme", b =>
                {
                    b.Property<int>("FermeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cinPopr")
                        .HasColumnType("int");

                    b.Property<string>("dateAdhesion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("delegation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gouveroratFerme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomFerme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomProp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numTelProp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FermeId");

                    b.ToTable("Ferme");
                });

            modelBuilder.Entity("GestionFermeWebApi.Models.RACE", b =>
                {
                    b.Property<int>("idRace")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idRace");

                    b.ToTable("race");
                });

            modelBuilder.Entity("GestionFermeWebApi.Models.VETERINAIRE", b =>
                {
                    b.Property<int>("IDVet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("num1")
                        .HasColumnType("int");

                    b.Property<int>("num2")
                        .HasColumnType("int");

                    b.Property<string>("prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDVet");

                    b.ToTable("veterinaire");
                });
#pragma warning restore 612, 618
        }
    }
}
