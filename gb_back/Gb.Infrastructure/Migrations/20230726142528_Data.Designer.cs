﻿// <auto-generated />
using System;
using Gb.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gb.Infrastructure.Migrations
{
    [DbContext(typeof(GbDbContext))]
    [Migration("20230726142528_Data")]
    partial class Data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gb.Domain.DbEntities.DbComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("Getutcdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("87f7a435-53e1-4fd1-9eef-be987b721ec8"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John1",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("1f7a3a59-51d7-47e8-bcb4-0dcb817516a7"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John2",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("569a832f-8e25-4eb0-be89-29d841c8b4ba"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John3",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("2cb6e5a7-1653-4df4-baae-c6405436aeb9"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John4",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("a40caa46-f378-4b7e-b1fa-6ed9e90464fb"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John5",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("84280c21-49a1-4f44-a6ef-e6bdfea9b0ab"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John6",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("b4f4e2ae-7032-42fa-882c-47d8dece6532"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John7",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("93ffef0a-5bca-4f8c-a064-9b5b6645d243"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John8",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("14b78268-d5c8-4fef-8f9d-0d2af152ecbe"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John9",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("af6519d8-2163-46a6-b5ab-01706d1dc6f6"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John10",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("dbed867a-a607-4dd4-93aa-c71e4619e556"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John11",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("0319f450-5166-4e60-93b7-4bd563acfdca"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John12",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("66348dfd-cf4f-46e4-a2d9-edce86838289"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John13",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("cb48c089-f391-4913-a255-914d179e0be5"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John14",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("948f7b11-58f6-4fd8-8423-56ddaafe5b19"),
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "John15",
                            Text = "Niccccccccccccccccceeeeeeeeeeeee"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
