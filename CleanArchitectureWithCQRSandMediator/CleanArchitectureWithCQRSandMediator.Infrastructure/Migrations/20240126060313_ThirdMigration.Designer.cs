﻿// <auto-generated />
using CleanArchitectureWithCQRSandMediator.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArchitectureWithCQRSandMediator.Infrastructure.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20240126060313_ThirdMigration")]
    partial class ThirdMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("CleanArchitectureWithCQRSandMediator.Domain.Entity.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Author1",
                            Description = "A very interesting book",
                            Name = "Name1"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Author2",
                            Description = "A very interesting book",
                            Name = "Name2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Author3",
                            Description = "A very interesting book",
                            Name = "Name3"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Author4",
                            Description = "A very interesting book",
                            Name = "Name4"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Author5",
                            Description = "A very interesting book",
                            Name = "Name5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
