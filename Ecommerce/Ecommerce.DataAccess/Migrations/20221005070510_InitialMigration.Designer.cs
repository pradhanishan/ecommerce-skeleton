﻿// <auto-generated />
using System;
using Ecommerce.DataAccess.ApplicationDataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221005070510_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ecommerce.Models.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Fashion",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7250), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7252), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Mobiles and Tablets",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Consumer Electronics",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7254), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Books",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Movie Tickets",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7256), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7257), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Baby Products",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7257), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Groceries",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7261), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Food Takeaway/Delivery",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Home Furnishings",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7263), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 0, 0, 0, 0)),
                            IsActive = true,
                            Name = "Jewelry",
                            UpdatedDate = new DateTimeOffset(new DateTime(2022, 10, 5, 7, 5, 10, 424, DateTimeKind.Unspecified).AddTicks(7265), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });
#pragma warning restore 612, 618
        }
    }
}