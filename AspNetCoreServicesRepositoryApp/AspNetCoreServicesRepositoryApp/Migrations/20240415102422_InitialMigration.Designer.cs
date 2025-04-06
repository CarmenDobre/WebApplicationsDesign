﻿// <auto-generated />
using AspNetCoreServicesRepositoryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreServicesRepositoryApp.Migrations
{
    [DbContext(typeof(LocationContext))]
    [Migration("20240415102422_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetCoreServicesRepositoryApp.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<bool>("IsNumber")
                        .HasColumnType("bit");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            IsNumber = true,
                            LocationName = "Location 1"
                        },
                        new
                        {
                            LocationId = 2,
                            IsNumber = true,
                            LocationName = "Location 2"
                        },
                        new
                        {
                            LocationId = 3,
                            IsNumber = false,
                            LocationName = "Location A"
                        },
                        new
                        {
                            LocationId = 4,
                            IsNumber = false,
                            LocationName = "Location B"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
