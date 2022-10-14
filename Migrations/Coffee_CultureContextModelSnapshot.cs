﻿// <auto-generated />
using System;
using Coffee_Culture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coffee_Culture.Migrations
{
    [DbContext(typeof(Coffee_CultureContext))]
    partial class Coffee_CultureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Coffee_Culture.Models.CoffeeBean", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description_Of_Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Manufacture_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Packaging")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Production_Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roasting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Types_Of_Coffee")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Coffee");
                });
#pragma warning restore 612, 618
        }
    }
}
