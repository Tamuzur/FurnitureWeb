﻿// <auto-generated />
using System;
using FurnitureStore.api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FurnitureStore.api.Data.Migrations
{
    [DbContext(typeof(FurnitureStoreContext))]
    [Migration("20250324180953_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("FurnitureStore.api.Entities.FType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Garden table"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Garden chair"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hammock"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Bench"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Bed"
                        });
                });

            modelBuilder.Entity("FurnitureStore.api.Entities.Furniture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FTypeId");

                    b.ToTable("Furnitures");
                });

            modelBuilder.Entity("FurnitureStore.api.Entities.Furniture", b =>
                {
                    b.HasOne("FurnitureStore.api.Entities.FType", "FType")
                        .WithMany()
                        .HasForeignKey("FTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FType");
                });
#pragma warning restore 612, 618
        }
    }
}
