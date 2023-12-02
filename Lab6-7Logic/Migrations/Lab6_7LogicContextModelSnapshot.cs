﻿// <auto-generated />
using System;
using Lab6_7Logic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lab6_7Logic.Migrations
{
    [DbContext(typeof(Lab6_7LogicContext))]
    partial class Lab6_7LogicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Lab6_7Logic.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly?>("ReleaseDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
